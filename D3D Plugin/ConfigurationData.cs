using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Schema;
using Microsoft.DirectX.Direct3D;

namespace D3D_Plugin
{
    public enum PreprocessingFilter : byte
    {
        PointSampling,
        BilinearSampling,
        AnisotropicSampling
    }

    public enum StretchingFilter : byte
    {
        PointSampling,
        BilinearSampling,
        AnisotropicSampling,
        Scale2x,
        f2xSAI
    }

    public enum PostprocessingFilter : byte
    {
        None
    }

    public struct DisplayMode
    {
        [XmlAttribute]
        public int Height;

        [XmlAttribute]
        public int Width;

        [XmlAttribute]
        public int RefreshRate;
    }

    [XmlRoot("Configuration")]
    public class ConfigurationData
    {
        [XmlAttribute]
        public int Adapter;

        [XmlElement]
        public PreprocessingFilter preprocessingFilter;
        [XmlElement]
        public PostprocessingFilter postprocessingFilter;
        [XmlElement]
        public StretchingFilter stretchingFilter;

        [XmlElement]
        public DisplayMode windowedDisplayMode;
        [XmlElement]
        public DisplayMode fullscreenDisplayMode;

        [XmlAttribute]
        public bool Fullscreen;

        public ConfigurationData()
        {
            this.preprocessingFilter = PreprocessingFilter.PointSampling;
            this.stretchingFilter = StretchingFilter.PointSampling;
            this.postprocessingFilter = PostprocessingFilter.None;

            this.windowedDisplayMode = new DisplayMode();

            windowedDisplayMode.Width = 640;
            windowedDisplayMode.Height = 480;
            windowedDisplayMode.RefreshRate = 60;

            fullscreenDisplayMode.Width = 640;
            fullscreenDisplayMode.Height = 480;
            fullscreenDisplayMode.RefreshRate = 60;

            Adapter = 0;

            Fullscreen = false;
        }
    }
}
