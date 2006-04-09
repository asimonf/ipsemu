using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using D3DDisplayMode = Microsoft.DirectX.Direct3D.DisplayMode;
using System.Xml.Serialization;
using System.IO;

namespace D3D_Plugin
{
    public partial class ConfigurationDialog : Form
    {
        public Capabilities caps;

        private bool supportsHardwareFilters = false;
        private Version minVertexShaderVersion = new Version(1, 1);
        private Version minPixelShaderVersion = new Version(2, 0);

        private List<string> preprocessingFilters = new List<string>();
        private List<string> stretchingFilters = new List<string>();
        private List<string> postprocessingFilters = new List<string>();

        public ConfigurationData confData;

        public ConfigurationDialog()
        {
            InitializeComponent();

            if (File.Exists("d3dFramebuffer.cfg"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ConfigurationData));
                TextReader reader = File.OpenText("d3dFramebuffer.cfg");
                confData = serializer.Deserialize(reader) as ConfigurationData;
                reader.Close();
            }
            else
                confData = new ConfigurationData();
        }

        private void ConfigurationDialog_Load(object sender, EventArgs e)
        {
            List<AdapterInformation> data = new List<AdapterInformation>();

            foreach (AdapterDetails i in Manager.Adapters)
            {
                data.Add(i.Information);
            }

            this.adapterComboBox.DataSource = data;
            this.adapterComboBox.DisplayMember = "Description";
            this.adapterComboBox.SelectedIndex = 0;

            this.preprocessingFiltersCombobox.DataSource = preprocessingFilters;
            this.stretchingFiltersCombobox.DataSource = stretchingFilters;
            this.postprocessingFiltersCombobox.DataSource = postprocessingFilters;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (About b = new About())
            {
                b.ShowDialog(this);
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adapterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.caps = Manager.GetDeviceCapabilities(Manager.Adapters[this.adapterComboBox.SelectedIndex].Adapter, DeviceType.Hardware);

            List<D3DDisplayMode> displayModes = new List<D3DDisplayMode>(Manager.Adapters[this.caps.AdapterOrdinal].SupportedDisplayModes[Format.X8R8G8B8]);

            List<string> displayModesFormated = new List<string>();

            foreach (D3DDisplayMode m in displayModes)
            {
                string s = m.Width + "x" + m.Height + " " + m.RefreshRate + "Hz";
                displayModesFormated.Add(s);
            }

            this.windowedResolutionCombobox.DataSource = displayModesFormated;
            this.fullscreenResolutionCombobox.DataSource = displayModesFormated;

            this.pixelShaderVer.Text = caps.PixelShaderVersion.ToString();
            this.vertexShaderVer.Text = caps.VertexShaderVersion.ToString();

            this.supportsHardwareFilters = caps.PixelShaderVersion > minPixelShaderVersion && caps.VertexShaderVersion > minVertexShaderVersion;

            if (supportsHardwareFilters)
            {
                this.preprocessingFilters.Clear();
                this.preprocessingFilters.Add("Point Sampling");
                this.preprocessingFilters.Add("Bilinear Sampling");
                this.preprocessingFilters.Add("Anisotropic Sampling");

                this.stretchingFilters.Clear();
                this.stretchingFilters.Add("Point Sampling");
                this.stretchingFilters.Add("Bilinear Sampling");
                this.stretchingFilters.Add("Anisotropic Sampling");
                this.stretchingFilters.Add("2xSAI");
                this.stretchingFilters.Add("Scale2x");

                this.postprocessingFilters.Clear();
                this.postprocessingFilters.Add("None");
            }
            else
            {
                this.preprocessingFilters.Clear();
                this.preprocessingFilters.Add("Point Sampling");
                this.preprocessingFilters.Add("Bilinear Sampling");
                this.preprocessingFilters.Add("Anisotropic Sampling");

                this.stretchingFilters.Clear();
                this.stretchingFilters.Add("Point Sampling");
                this.stretchingFilters.Add("Bilinear Sampling");
                this.stretchingFilters.Add("Anisotropic Sampling");

                this.postprocessingFilters.Clear();
                this.postprocessingFilters.Add("None");
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            ConfigurationData d = new ConfigurationData();
            
            d.Adapter = caps.AdapterOrdinal;

            d.Fullscreen = this.fullscreenCheckbox.Checked;
            
            d.fullscreenDisplayMode = new DisplayMode();
            
            string fullscreenDisplay = this.fullscreenResolutionCombobox.SelectedValue as string;
            
            d.fullscreenDisplayMode.Width = int.Parse(fullscreenDisplay.Split('x')[0]);
            d.fullscreenDisplayMode.Height = int.Parse(fullscreenDisplay.Split('x')[1].Split(' ')[0]);
            d.fullscreenDisplayMode.RefreshRate = int.Parse(fullscreenDisplay.Split('x')[1].Split(' ')[1].Split('H')[0]);

            d.windowedDisplayMode = new DisplayMode();

            string windowedDisplay = this.fullscreenResolutionCombobox.SelectedValue as string;

            d.windowedDisplayMode.Width = int.Parse(windowedDisplay.Split('x')[0]);
            d.windowedDisplayMode.Height = int.Parse(windowedDisplay.Split('x')[1].Split(' ')[0]);
            d.windowedDisplayMode.RefreshRate = int.Parse(windowedDisplay.Split('x')[1].Split(' ')[1].Split('H')[0]);

            switch (this.preprocessingFiltersCombobox.SelectedValue as string)
            {
                case "Point Sampling":
                    d.preprocessingFilter = PreprocessingFilter.PointSampling;
                    break;
                case "Bilinear Sampling":
                    d.preprocessingFilter = PreprocessingFilter.BilinearSampling;
                    break;
                case "Anisotropic Sampling":
                    d.preprocessingFilter = PreprocessingFilter.AnisotropicSampling;
                    break;
                default:
                    d.preprocessingFilter = PreprocessingFilter.PointSampling;
                    break;
            }

            switch (this.stretchingFiltersCombobox.SelectedValue as string)
            {
                case "Point Sampling":
                    d.stretchingFilter = StretchingFilter.PointSampling;
                    break;
                case "Bilinear Sampling":
                    d.stretchingFilter = StretchingFilter.BilinearSampling;
                    break;
                case "Anisotropic Sampling":
                    d.stretchingFilter = StretchingFilter.AnisotropicSampling;
                    break;
                case "2xSAI":
                    d.stretchingFilter = StretchingFilter.f2xSAI;
                    break;
                case "Scale2x":
                    d.stretchingFilter = StretchingFilter.Scale2x;
                    break;
                default:
                    d.stretchingFilter = StretchingFilter.PointSampling;
                    break;
            }

            switch (this.postprocessingFiltersCombobox.SelectedValue as string)
            {
                case "None":
                    d.postprocessingFilter = PostprocessingFilter.None;
                    break;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(ConfigurationData));
            TextWriter writer = File.CreateText("d3dFramebuffer.cfg");
            serializer.Serialize(writer, d);
            writer.Close();
        }
    }
}