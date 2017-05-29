namespace sharpInterferometer
{
    partial class SourcesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listSources = new System.Windows.Forms.ListBox();
            this.propertiesBox = new System.Windows.Forms.GroupBox();
            this.viewBox = new System.Windows.Forms.PictureBox();
            this.spectrumBox = new System.Windows.Forms.PictureBox();
            this.deleteWaveButton = new System.Windows.Forms.Button();
            this.addWaveButton = new System.Windows.Forms.Button();
            this.turnCheck = new System.Windows.Forms.CheckBox();
            this.wavePropBox = new System.Windows.Forms.GroupBox();
            this.ampText = new System.Windows.Forms.TextBox();
            this.phaseText = new System.Windows.Forms.TextBox();
            this.deltaText = new System.Windows.Forms.TextBox();
            this.lengthText = new System.Windows.Forms.TextBox();
            this.ampLabel = new System.Windows.Forms.Label();
            this.deltaLabel = new System.Windows.Forms.Label();
            this.phaseLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.yText = new System.Windows.Forms.TextBox();
            this.yLabel = new System.Windows.Forms.Label();
            this.xText = new System.Windows.Forms.TextBox();
            this.listWaves = new System.Windows.Forms.ListBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.addSourceButton = new System.Windows.Forms.Button();
            this.propertiesBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumBox)).BeginInit();
            this.wavePropBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listSources
            // 
            this.listSources.FormattingEnabled = true;
            this.listSources.Location = new System.Drawing.Point(6, 19);
            this.listSources.Name = "listSources";
            this.listSources.Size = new System.Drawing.Size(156, 251);
            this.listSources.TabIndex = 0;
            this.listSources.SelectedIndexChanged += new System.EventHandler(this.ListSourcesSelectedIndexChanged);
            // 
            // propertiesBox
            // 
            this.propertiesBox.Controls.Add(this.viewBox);
            this.propertiesBox.Controls.Add(this.spectrumBox);
            this.propertiesBox.Controls.Add(this.deleteWaveButton);
            this.propertiesBox.Controls.Add(this.addWaveButton);
            this.propertiesBox.Controls.Add(this.turnCheck);
            this.propertiesBox.Controls.Add(this.wavePropBox);
            this.propertiesBox.Controls.Add(this.yText);
            this.propertiesBox.Controls.Add(this.yLabel);
            this.propertiesBox.Controls.Add(this.xText);
            this.propertiesBox.Controls.Add(this.listWaves);
            this.propertiesBox.Controls.Add(this.xLabel);
            this.propertiesBox.Controls.Add(this.nameText);
            this.propertiesBox.Controls.Add(this.nameLabel);
            this.propertiesBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertiesBox.Enabled = false;
            this.propertiesBox.Location = new System.Drawing.Point(185, 0);
            this.propertiesBox.Name = "propertiesBox";
            this.propertiesBox.Size = new System.Drawing.Size(787, 336);
            this.propertiesBox.TabIndex = 1;
            this.propertiesBox.TabStop = false;
            this.propertiesBox.Text = "Свойства";
            // 
            // viewBox
            // 
            this.viewBox.BackColor = System.Drawing.Color.Black;
            this.viewBox.Location = new System.Drawing.Point(224, 296);
            this.viewBox.Name = "viewBox";
            this.viewBox.Size = new System.Drawing.Size(32, 32);
            this.viewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viewBox.TabIndex = 15;
            this.viewBox.TabStop = false;
            // 
            // spectrumBox
            // 
            this.spectrumBox.BackColor = System.Drawing.Color.Black;
            this.spectrumBox.Location = new System.Drawing.Point(262, 16);
            this.spectrumBox.Name = "spectrumBox";
            this.spectrumBox.Size = new System.Drawing.Size(519, 312);
            this.spectrumBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spectrumBox.TabIndex = 14;
            this.spectrumBox.TabStop = false;
            // 
            // deleteWaveButton
            // 
            this.deleteWaveButton.Location = new System.Drawing.Point(103, 289);
            this.deleteWaveButton.Name = "deleteWaveButton";
            this.deleteWaveButton.Size = new System.Drawing.Size(75, 23);
            this.deleteWaveButton.TabIndex = 13;
            this.deleteWaveButton.Text = "Удалить";
            this.deleteWaveButton.UseVisualStyleBackColor = true;
            this.deleteWaveButton.Click += new System.EventHandler(this.DeleteWaveButtonClick);
            // 
            // addWaveButton
            // 
            this.addWaveButton.Location = new System.Drawing.Point(11, 289);
            this.addWaveButton.Name = "addWaveButton";
            this.addWaveButton.Size = new System.Drawing.Size(75, 23);
            this.addWaveButton.TabIndex = 3;
            this.addWaveButton.Text = "Добавить";
            this.addWaveButton.UseVisualStyleBackColor = true;
            this.addWaveButton.Click += new System.EventHandler(this.AddWaveButtonClick);
            // 
            // turnCheck
            // 
            this.turnCheck.AutoSize = true;
            this.turnCheck.Location = new System.Drawing.Point(16, 58);
            this.turnCheck.Name = "turnCheck";
            this.turnCheck.Size = new System.Drawing.Size(70, 17);
            this.turnCheck.TabIndex = 7;
            this.turnCheck.Text = "Включён";
            this.turnCheck.UseVisualStyleBackColor = true;
            this.turnCheck.CheckedChanged += new System.EventHandler(this.TurnCheckCheckedChanged);
            // 
            // wavePropBox
            // 
            this.wavePropBox.Controls.Add(this.ampText);
            this.wavePropBox.Controls.Add(this.phaseText);
            this.wavePropBox.Controls.Add(this.deltaText);
            this.wavePropBox.Controls.Add(this.lengthText);
            this.wavePropBox.Controls.Add(this.ampLabel);
            this.wavePropBox.Controls.Add(this.deltaLabel);
            this.wavePropBox.Controls.Add(this.phaseLabel);
            this.wavePropBox.Controls.Add(this.lengthLabel);
            this.wavePropBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wavePropBox.Location = new System.Drawing.Point(115, 84);
            this.wavePropBox.Name = "wavePropBox";
            this.wavePropBox.Size = new System.Drawing.Size(130, 199);
            this.wavePropBox.TabIndex = 13;
            this.wavePropBox.TabStop = false;
            // 
            // ampText
            // 
            this.ampText.Location = new System.Drawing.Point(6, 130);
            this.ampText.Name = "ampText";
            this.ampText.Size = new System.Drawing.Size(94, 20);
            this.ampText.TabIndex = 11;
            this.ampText.TextChanged += new System.EventHandler(this.AmpTextTextChanged);
            // 
            // phaseText
            // 
            this.phaseText.Location = new System.Drawing.Point(6, 169);
            this.phaseText.Name = "phaseText";
            this.phaseText.Size = new System.Drawing.Size(94, 20);
            this.phaseText.TabIndex = 12;
            this.phaseText.TextChanged += new System.EventHandler(this.PhaseTextTextChanged);
            // 
            // deltaText
            // 
            this.deltaText.Location = new System.Drawing.Point(7, 91);
            this.deltaText.Name = "deltaText";
            this.deltaText.Size = new System.Drawing.Size(94, 20);
            this.deltaText.TabIndex = 10;
            this.deltaText.Leave += new System.EventHandler(this.DeltaTextTextChanged);
            // 
            // lengthText
            // 
            this.lengthText.Location = new System.Drawing.Point(7, 42);
            this.lengthText.Name = "lengthText";
            this.lengthText.Size = new System.Drawing.Size(94, 20);
            this.lengthText.TabIndex = 9;
            this.lengthText.Leave += new System.EventHandler(this.LengthTextTextChanged);
            // 
            // ampLabel
            // 
            this.ampLabel.AutoSize = true;
            this.ampLabel.Location = new System.Drawing.Point(6, 114);
            this.ampLabel.Name = "ampLabel";
            this.ampLabel.Size = new System.Drawing.Size(98, 13);
            this.ampLabel.TabIndex = 7;
            this.ampLabel.Text = "Амплитуда (0-255)";
            // 
            // deltaLabel
            // 
            this.deltaLabel.Location = new System.Drawing.Point(4, 65);
            this.deltaLabel.Name = "deltaLabel";
            this.deltaLabel.Size = new System.Drawing.Size(82, 32);
            this.deltaLabel.TabIndex = 6;
            this.deltaLabel.Text = "Пропускание, ангстремы";
            // 
            // phaseLabel
            // 
            this.phaseLabel.AutoSize = true;
            this.phaseLabel.Location = new System.Drawing.Point(4, 153);
            this.phaseLabel.Name = "phaseLabel";
            this.phaseLabel.Size = new System.Drawing.Size(84, 13);
            this.phaseLabel.TabIndex = 8;
            this.phaseLabel.Text = "Фаза, градусы";
            // 
            // lengthLabel
            // 
            this.lengthLabel.Location = new System.Drawing.Point(4, 14);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(96, 34);
            this.lengthLabel.TabIndex = 5;
            this.lengthLabel.Text = "Длина волны, ангстремы";
            // 
            // yText
            // 
            this.yText.Location = new System.Drawing.Point(164, 45);
            this.yText.Name = "yText";
            this.yText.Size = new System.Drawing.Size(81, 20);
            this.yText.TabIndex = 5;
            this.yText.TextChanged += new System.EventHandler(this.YTextTextChanged);
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(146, 48);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(12, 13);
            this.yLabel.TabIndex = 4;
            this.yLabel.Text = "y";
            // 
            // xText
            // 
            this.xText.Location = new System.Drawing.Point(164, 19);
            this.xText.Name = "xText";
            this.xText.Size = new System.Drawing.Size(81, 20);
            this.xText.TabIndex = 3;
            this.xText.TextChanged += new System.EventHandler(this.XTextTextChanged);
            // 
            // listWaves
            // 
            this.listWaves.FormattingEnabled = true;
            this.listWaves.Location = new System.Drawing.Point(6, 84);
            this.listWaves.Name = "listWaves";
            this.listWaves.Size = new System.Drawing.Size(103, 199);
            this.listWaves.TabIndex = 4;
            this.listWaves.SelectedIndexChanged += new System.EventHandler(this.ListWavesSelectedIndexChanged);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(146, 22);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(12, 13);
            this.xLabel.TabIndex = 2;
            this.xLabel.Text = "x";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(16, 32);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(81, 20);
            this.nameText.TabIndex = 1;
            this.nameText.TextChanged += new System.EventHandler(this.NameTextTextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Имя";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(87, 305);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(SaveButtonClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(87, 276);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.loadButton);
            this.groupBox4.Controls.Add(this.deleteButton);
            this.groupBox4.Controls.Add(this.saveButton);
            this.groupBox4.Controls.Add(this.addSourceButton);
            this.groupBox4.Controls.Add(this.listSources);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(179, 336);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(6, 305);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Загрузить";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButtonClick);
            // 
            // addSourceButton
            // 
            this.addSourceButton.Location = new System.Drawing.Point(6, 276);
            this.addSourceButton.Name = "addSourceButton";
            this.addSourceButton.Size = new System.Drawing.Size(75, 23);
            this.addSourceButton.TabIndex = 1;
            this.addSourceButton.Text = "Добавить";
            this.addSourceButton.UseVisualStyleBackColor = true;
            this.addSourceButton.Click += new System.EventHandler(this.AddSourceButtonClick);
            // 
            // SourcesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 336);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.propertiesBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SourcesForm";
            this.ShowIcon = false;
            this.Text = "Источники";
            this.Activated += new System.EventHandler(this.SourcesFormActivated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SourcesFormFormClosing);
            this.propertiesBox.ResumeLayout(false);
            this.propertiesBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumBox)).EndInit();
            this.wavePropBox.ResumeLayout(false);
            this.wavePropBox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listSources;
        private System.Windows.Forms.GroupBox propertiesBox;
        private System.Windows.Forms.TextBox phaseText;
        private System.Windows.Forms.TextBox ampText;
        private System.Windows.Forms.TextBox deltaText;
        private System.Windows.Forms.TextBox lengthText;
        private System.Windows.Forms.Label phaseLabel;
        private System.Windows.Forms.Label ampLabel;
        private System.Windows.Forms.Label deltaLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.ListBox listWaves;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button addSourceButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button deleteWaveButton;
        private System.Windows.Forms.Button addWaveButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox yText;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.TextBox xText;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.CheckBox turnCheck;
        private System.Windows.Forms.GroupBox wavePropBox;
        private System.Windows.Forms.PictureBox spectrumBox;
        private System.Windows.Forms.PictureBox viewBox;
    }
}