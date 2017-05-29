namespace sharpInterferometer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SourcesButton = new System.Windows.Forms.Button();
            this.boxButtons = new System.Windows.Forms.GroupBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.ScreenButton = new System.Windows.Forms.Button();
            this.fieldView = new System.Windows.Forms.PictureBox();
            this.boxButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fieldView)).BeginInit();
            this.SuspendLayout();
            // 
            // SourcesButton
            // 
            this.SourcesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SourcesButton.Location = new System.Drawing.Point(6, 12);
            this.SourcesButton.Name = "SourcesButton";
            this.SourcesButton.Size = new System.Drawing.Size(92, 31);
            this.SourcesButton.TabIndex = 0;
            this.SourcesButton.Text = "Источники...";
            this.SourcesButton.UseVisualStyleBackColor = true;
            this.SourcesButton.Click += new System.EventHandler(SourcesButtonClick);
            // 
            // boxButtons
            // 
            this.boxButtons.Controls.Add(this.loadButton);
            this.boxButtons.Controls.Add(this.saveButton);
            this.boxButtons.Controls.Add(this.aboutButton);
            this.boxButtons.Controls.Add(this.ScreenButton);
            this.boxButtons.Controls.Add(this.SourcesButton);
            this.boxButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.boxButtons.Location = new System.Drawing.Point(549, 0);
            this.boxButtons.Name = "boxButtons";
            this.boxButtons.Size = new System.Drawing.Size(110, 376);
            this.boxButtons.TabIndex = 2;
            this.boxButtons.TabStop = false;
            // 
            // loadButton
            // 
            this.loadButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.loadButton.Location = new System.Drawing.Point(9, 209);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(92, 29);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Загрузить...";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(LoadButtonClick);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveButton.Location = new System.Drawing.Point(9, 174);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(92, 29);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить...";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(SaveButtonClick);
            // 
            // aboutButton
            // 
            this.aboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutButton.Location = new System.Drawing.Point(6, 341);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(92, 29);
            this.aboutButton.TabIndex = 1;
            this.aboutButton.Text = "О программе...";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(AboutButtonClick);
            // 
            // ScreenButton
            // 
            this.ScreenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScreenButton.Location = new System.Drawing.Point(6, 49);
            this.ScreenButton.Name = "ScreenButton";
            this.ScreenButton.Size = new System.Drawing.Size(92, 29);
            this.ScreenButton.TabIndex = 1;
            this.ScreenButton.Text = "Экраны...";
            this.ScreenButton.UseVisualStyleBackColor = true;
            this.ScreenButton.Click += new System.EventHandler(ScreensButtonClick);
            // 
            // fieldView
            // 
            this.fieldView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldView.BackColor = System.Drawing.Color.Black;
            this.fieldView.Location = new System.Drawing.Point(0, 0);
            this.fieldView.Name = "fieldView";
            this.fieldView.Size = new System.Drawing.Size(543, 376);
            this.fieldView.TabIndex = 1;
            this.fieldView.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 376);
            this.Controls.Add(this.boxButtons);
            this.Controls.Add(this.fieldView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Эмулятор интерферометра";
            this.Resize += new System.EventHandler(this.MainFormResize);
            this.boxButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fieldView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SourcesButton;
        private System.Windows.Forms.GroupBox boxButtons;
        private System.Windows.Forms.Button ScreenButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.PictureBox fieldView;
    }
}

