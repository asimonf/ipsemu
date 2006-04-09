namespace D3D_Plugin
{
    partial class ConfigurationDialog
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.adapterComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pixelShaderVer = new System.Windows.Forms.Label();
            this.vertexShaderVer = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.windowedResolutionCombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fullscreenCheckbox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fullscreenResolutionCombobox = new System.Windows.Forms.ComboBox();
            this.preprocessingFiltersCombobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stretchingFiltersCombobox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.postprocessingFiltersCombobox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vertexShaderVer);
            this.groupBox1.Controls.Add(this.pixelShaderVer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.adapterComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adapter Info";
            // 
            // adapterComboBox
            // 
            this.adapterComboBox.FormattingEnabled = true;
            this.adapterComboBox.Location = new System.Drawing.Point(56, 13);
            this.adapterComboBox.Name = "adapterComboBox";
            this.adapterComboBox.Size = new System.Drawing.Size(217, 21);
            this.adapterComboBox.TabIndex = 3;
            this.adapterComboBox.SelectedIndexChanged += new System.EventHandler(this.adapterComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adapter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pixel Shader version: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vertex Shader version: ";
            // 
            // pixelShaderVer
            // 
            this.pixelShaderVer.AutoSize = true;
            this.pixelShaderVer.Location = new System.Drawing.Point(125, 37);
            this.pixelShaderVer.Name = "pixelShaderVer";
            this.pixelShaderVer.Size = new System.Drawing.Size(16, 13);
            this.pixelShaderVer.TabIndex = 6;
            this.pixelShaderVer.Text = "...";
            // 
            // vertexShaderVer
            // 
            this.vertexShaderVer.AutoSize = true;
            this.vertexShaderVer.Location = new System.Drawing.Point(125, 50);
            this.vertexShaderVer.Name = "vertexShaderVer";
            this.vertexShaderVer.Size = new System.Drawing.Size(16, 13);
            this.vertexShaderVer.TabIndex = 7;
            this.vertexShaderVer.Text = "...";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 278);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Save";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(93, 278);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.postprocessingFiltersCombobox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.stretchingFiltersCombobox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.preprocessingFiltersCombobox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.fullscreenResolutionCombobox);
            this.groupBox2.Controls.Add(this.fullscreenCheckbox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.windowedResolutionCombobox);
            this.groupBox2.Location = new System.Drawing.Point(12, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 184);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adapter Configuration";
            // 
            // windowedResolutionCombobox
            // 
            this.windowedResolutionCombobox.FormattingEnabled = true;
            this.windowedResolutionCombobox.Location = new System.Drawing.Point(128, 19);
            this.windowedResolutionCombobox.Name = "windowedResolutionCombobox";
            this.windowedResolutionCombobox.Size = new System.Drawing.Size(145, 21);
            this.windowedResolutionCombobox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Window Resolution";
            // 
            // fullscreenCheckbox
            // 
            this.fullscreenCheckbox.AutoSize = true;
            this.fullscreenCheckbox.Location = new System.Drawing.Point(9, 70);
            this.fullscreenCheckbox.Name = "fullscreenCheckbox";
            this.fullscreenCheckbox.Size = new System.Drawing.Size(74, 17);
            this.fullscreenCheckbox.TabIndex = 2;
            this.fullscreenCheckbox.Text = "Fullscreen";
            this.fullscreenCheckbox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fullscreen Resolution";
            // 
            // fullscreenResolutionCombobox
            // 
            this.fullscreenResolutionCombobox.FormattingEnabled = true;
            this.fullscreenResolutionCombobox.Location = new System.Drawing.Point(128, 45);
            this.fullscreenResolutionCombobox.Name = "fullscreenResolutionCombobox";
            this.fullscreenResolutionCombobox.Size = new System.Drawing.Size(145, 21);
            this.fullscreenResolutionCombobox.TabIndex = 3;
            // 
            // preprocessingFiltersCombobox
            // 
            this.preprocessingFiltersCombobox.FormattingEnabled = true;
            this.preprocessingFiltersCombobox.Location = new System.Drawing.Point(128, 97);
            this.preprocessingFiltersCombobox.Name = "preprocessingFiltersCombobox";
            this.preprocessingFiltersCombobox.Size = new System.Drawing.Size(145, 21);
            this.preprocessingFiltersCombobox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Preprocessing Filter";
            // 
            // stretchingFiltersCombobox
            // 
            this.stretchingFiltersCombobox.FormattingEnabled = true;
            this.stretchingFiltersCombobox.Location = new System.Drawing.Point(128, 124);
            this.stretchingFiltersCombobox.Name = "stretchingFiltersCombobox";
            this.stretchingFiltersCombobox.Size = new System.Drawing.Size(145, 21);
            this.stretchingFiltersCombobox.TabIndex = 7;
            this.stretchingFiltersCombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Stretching Filter";
            // 
            // postprocessingFiltersCombobox
            // 
            this.postprocessingFiltersCombobox.FormattingEnabled = true;
            this.postprocessingFiltersCombobox.Location = new System.Drawing.Point(128, 153);
            this.postprocessingFiltersCombobox.Name = "postprocessingFiltersCombobox";
            this.postprocessingFiltersCombobox.Size = new System.Drawing.Size(145, 21);
            this.postprocessingFiltersCombobox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Postprocessing Filter";
            // 
            // ConfigurationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 310);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigurationDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ConfigurationDialog";
            this.Load += new System.EventHandler(this.ConfigurationDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox adapterComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vertexShaderVer;
        private System.Windows.Forms.Label pixelShaderVer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox fullscreenCheckbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox windowedResolutionCombobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox fullscreenResolutionCombobox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox postprocessingFiltersCombobox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox stretchingFiltersCombobox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox preprocessingFiltersCombobox;
    }
}