namespace sharpInterferometer
{
    partial class ScreensForm
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
            this.listScreens = new System.Windows.Forms.ListBox();
            this.propertiesBox = new System.Windows.Forms.GroupBox();
            this.resolutionBox = new System.Windows.Forms.GroupBox();
            this.radio20000 = new System.Windows.Forms.RadioButton();
            this.radio10000 = new System.Windows.Forms.RadioButton();
            this.radio5000 = new System.Windows.Forms.RadioButton();
            this.radio2000 = new System.Windows.Forms.RadioButton();
            this.radio1000 = new System.Windows.Forms.RadioButton();
            this.radio500 = new System.Windows.Forms.RadioButton();
            this.filterButton = new System.Windows.Forms.Button();
            this.y2Text = new System.Windows.Forms.TextBox();
            this.y2Label = new System.Windows.Forms.Label();
            this.x2Text = new System.Windows.Forms.TextBox();
            this.x2Label = new System.Windows.Forms.Label();
            this.buttonSee = new System.Windows.Forms.Button();
            this.y1Text = new System.Windows.Forms.TextBox();
            this.y1Label = new System.Windows.Forms.Label();
            this.x1Text = new System.Windows.Forms.TextBox();
            this.x1Label = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.GroupBox();
            this.addSourceButton = new System.Windows.Forms.Button();
            this.propertiesBox.SuspendLayout();
            this.resolutionBox.SuspendLayout();
            this.listBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listScreens
            // 
            this.listScreens.FormattingEnabled = true;
            this.listScreens.Location = new System.Drawing.Point(6, 19);
            this.listScreens.Name = "listScreens";
            this.listScreens.Size = new System.Drawing.Size(156, 199);
            this.listScreens.TabIndex = 0;
            this.listScreens.SelectedIndexChanged += new System.EventHandler(this.ListScreensSelectedIndexChanged);
            // 
            // propertiesBox
            // 
            this.propertiesBox.Controls.Add(this.resolutionBox);
            this.propertiesBox.Controls.Add(this.filterButton);
            this.propertiesBox.Controls.Add(this.y2Text);
            this.propertiesBox.Controls.Add(this.y2Label);
            this.propertiesBox.Controls.Add(this.x2Text);
            this.propertiesBox.Controls.Add(this.x2Label);
            this.propertiesBox.Controls.Add(this.buttonSee);
            this.propertiesBox.Controls.Add(this.y1Text);
            this.propertiesBox.Controls.Add(this.y1Label);
            this.propertiesBox.Controls.Add(this.x1Text);
            this.propertiesBox.Controls.Add(this.x1Label);
            this.propertiesBox.Controls.Add(this.nameText);
            this.propertiesBox.Controls.Add(this.nameLabel);
            this.propertiesBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertiesBox.Enabled = false;
            this.propertiesBox.Location = new System.Drawing.Point(184, 0);
            this.propertiesBox.Name = "propertiesBox";
            this.propertiesBox.Size = new System.Drawing.Size(299, 256);
            this.propertiesBox.TabIndex = 1;
            this.propertiesBox.TabStop = false;
            this.propertiesBox.Text = "Свойства";
            // 
            // resolutionBox
            // 
            this.resolutionBox.Controls.Add(this.radio20000);
            this.resolutionBox.Controls.Add(this.radio10000);
            this.resolutionBox.Controls.Add(this.radio5000);
            this.resolutionBox.Controls.Add(this.radio2000);
            this.resolutionBox.Controls.Add(this.radio1000);
            this.resolutionBox.Controls.Add(this.radio500);
            this.resolutionBox.Location = new System.Drawing.Point(16, 67);
            this.resolutionBox.Name = "resolutionBox";
            this.resolutionBox.Size = new System.Drawing.Size(101, 177);
            this.resolutionBox.TabIndex = 14;
            this.resolutionBox.TabStop = false;
            this.resolutionBox.Text = "Разрешение";
            // 
            // radio20000
            // 
            this.radio20000.AutoSize = true;
            this.radio20000.Location = new System.Drawing.Point(10, 145);
            this.radio20000.Name = "radio20000";
            this.radio20000.Size = new System.Drawing.Size(55, 17);
            this.radio20000.TabIndex = 5;
            this.radio20000.TabStop = true;
            this.radio20000.Text = "20000";
            this.radio20000.UseVisualStyleBackColor = true;
            // 
            // radio10000
            // 
            this.radio10000.AutoSize = true;
            this.radio10000.Location = new System.Drawing.Point(10, 122);
            this.radio10000.Name = "radio10000";
            this.radio10000.Size = new System.Drawing.Size(55, 17);
            this.radio10000.TabIndex = 4;
            this.radio10000.TabStop = true;
            this.radio10000.Text = "10000";
            this.radio10000.UseVisualStyleBackColor = true;
            // 
            // radio5000
            // 
            this.radio5000.AutoSize = true;
            this.radio5000.Location = new System.Drawing.Point(10, 99);
            this.radio5000.Name = "radio5000";
            this.radio5000.Size = new System.Drawing.Size(49, 17);
            this.radio5000.TabIndex = 3;
            this.radio5000.TabStop = true;
            this.radio5000.Text = "5000";
            this.radio5000.UseVisualStyleBackColor = true;
            // 
            // radio2000
            // 
            this.radio2000.AutoSize = true;
            this.radio2000.Checked = true;
            this.radio2000.Location = new System.Drawing.Point(10, 76);
            this.radio2000.Name = "radio2000";
            this.radio2000.Size = new System.Drawing.Size(49, 17);
            this.radio2000.TabIndex = 2;
            this.radio2000.TabStop = true;
            this.radio2000.Text = "2000";
            this.radio2000.UseVisualStyleBackColor = true;
            // 
            // radio1000
            // 
            this.radio1000.AutoSize = true;
            this.radio1000.Location = new System.Drawing.Point(10, 53);
            this.radio1000.Name = "radio1000";
            this.radio1000.Size = new System.Drawing.Size(49, 17);
            this.radio1000.TabIndex = 1;
            this.radio1000.TabStop = true;
            this.radio1000.Text = "1000";
            this.radio1000.UseVisualStyleBackColor = true;
            // 
            // radio500
            // 
            this.radio500.AutoSize = true;
            this.radio500.Location = new System.Drawing.Point(10, 30);
            this.radio500.Name = "radio500";
            this.radio500.Size = new System.Drawing.Size(43, 17);
            this.radio500.TabIndex = 0;
            this.radio500.TabStop = true;
            this.radio500.Text = "500";
            this.radio500.UseVisualStyleBackColor = true;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(210, 120);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(82, 25);
            this.filterButton.TabIndex = 13;
            this.filterButton.Text = "Фильтры...";
            this.filterButton.UseVisualStyleBackColor = true;
            // 
            // y2Text
            // 
            this.y2Text.Location = new System.Drawing.Point(212, 90);
            this.y2Text.Name = "y2Text";
            this.y2Text.Size = new System.Drawing.Size(81, 20);
            this.y2Text.TabIndex = 12;
            this.y2Text.TextChanged += new System.EventHandler(this.Y2TextTextChanged);
            // 
            // y2Label
            // 
            this.y2Label.AutoSize = true;
            this.y2Label.Location = new System.Drawing.Point(194, 93);
            this.y2Label.Name = "y2Label";
            this.y2Label.Size = new System.Drawing.Size(18, 13);
            this.y2Label.TabIndex = 11;
            this.y2Label.Text = "y2";
            // 
            // x2Text
            // 
            this.x2Text.Location = new System.Drawing.Point(212, 64);
            this.x2Text.Name = "x2Text";
            this.x2Text.Size = new System.Drawing.Size(81, 20);
            this.x2Text.TabIndex = 10;
            this.x2Text.TextChanged += new System.EventHandler(this.X2TextTextChanged);
            // 
            // x2Label
            // 
            this.x2Label.AutoSize = true;
            this.x2Label.Location = new System.Drawing.Point(194, 67);
            this.x2Label.Name = "x2Label";
            this.x2Label.Size = new System.Drawing.Size(18, 13);
            this.x2Label.TabIndex = 9;
            this.x2Label.Text = "x2";
            // 
            // buttonSee
            // 
            this.buttonSee.Location = new System.Drawing.Point(182, 219);
            this.buttonSee.Name = "buttonSee";
            this.buttonSee.Size = new System.Drawing.Size(111, 25);
            this.buttonSee.TabIndex = 8;
            this.buttonSee.Text = "Интерференция";
            this.buttonSee.UseVisualStyleBackColor = true;
            this.buttonSee.Click += new System.EventHandler(this.ButtonSeeClick);
            // 
            // y1Text
            // 
            this.y1Text.Location = new System.Drawing.Point(212, 38);
            this.y1Text.Name = "y1Text";
            this.y1Text.Size = new System.Drawing.Size(81, 20);
            this.y1Text.TabIndex = 5;
            this.y1Text.TextChanged += new System.EventHandler(this.Y1TextTextChanged);
            // 
            // y1Label
            // 
            this.y1Label.AutoSize = true;
            this.y1Label.Location = new System.Drawing.Point(194, 41);
            this.y1Label.Name = "y1Label";
            this.y1Label.Size = new System.Drawing.Size(18, 13);
            this.y1Label.TabIndex = 4;
            this.y1Label.Text = "y1";
            // 
            // x1Text
            // 
            this.x1Text.Location = new System.Drawing.Point(212, 12);
            this.x1Text.Name = "x1Text";
            this.x1Text.Size = new System.Drawing.Size(81, 20);
            this.x1Text.TabIndex = 3;
            this.x1Text.TextChanged += new System.EventHandler(this.X1TextTextChanged);
            // 
            // x1Label
            // 
            this.x1Label.AutoSize = true;
            this.x1Label.Location = new System.Drawing.Point(194, 15);
            this.x1Label.Name = "x1Label";
            this.x1Label.Size = new System.Drawing.Size(18, 13);
            this.x1Label.TabIndex = 2;
            this.x1Label.Text = "x1";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(16, 35);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(125, 20);
            this.nameText.TabIndex = 1;
            this.nameText.TextChanged += new System.EventHandler(this.NameTextTextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 19);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Имя";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(87, 224);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // listBox
            // 
            this.listBox.Controls.Add(this.deleteButton);
            this.listBox.Controls.Add(this.addSourceButton);
            this.listBox.Controls.Add(this.listScreens);
            this.listBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(179, 256);
            this.listBox.TabIndex = 4;
            this.listBox.TabStop = false;
            // 
            // addSourceButton
            // 
            this.addSourceButton.Location = new System.Drawing.Point(6, 224);
            this.addSourceButton.Name = "addSourceButton";
            this.addSourceButton.Size = new System.Drawing.Size(75, 23);
            this.addSourceButton.TabIndex = 1;
            this.addSourceButton.Text = "Добавить";
            this.addSourceButton.UseVisualStyleBackColor = true;
            this.addSourceButton.Click += new System.EventHandler(this.AddScreenButtonClick);
            // 
            // ScreensForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 256);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.propertiesBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ScreensForm";
            this.ShowIcon = false;
            this.Text = "Экраны";
            this.Activated += new System.EventHandler(this.ScreensFormActivated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScreensFormFormClosing);
            this.propertiesBox.ResumeLayout(false);
            this.propertiesBox.PerformLayout();
            this.resolutionBox.ResumeLayout(false);
            this.resolutionBox.PerformLayout();
            this.listBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listScreens;
        private System.Windows.Forms.GroupBox propertiesBox;
        private System.Windows.Forms.GroupBox listBox;
        private System.Windows.Forms.Button addSourceButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox y1Text;
        private System.Windows.Forms.Label y1Label;
        private System.Windows.Forms.TextBox x1Text;
        private System.Windows.Forms.Label x1Label;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button buttonSee;
        private System.Windows.Forms.TextBox y2Text;
        private System.Windows.Forms.Label y2Label;
        private System.Windows.Forms.TextBox x2Text;
        private System.Windows.Forms.Label x2Label;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.GroupBox resolutionBox;
        private System.Windows.Forms.RadioButton radio20000;
        private System.Windows.Forms.RadioButton radio10000;
        private System.Windows.Forms.RadioButton radio5000;
        private System.Windows.Forms.RadioButton radio2000;
        private System.Windows.Forms.RadioButton radio1000;
        private System.Windows.Forms.RadioButton radio500;
    }
}