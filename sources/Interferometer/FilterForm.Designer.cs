namespace sharpInterferometer
{
    partial class FilterForm
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
            this.propertiesBox = new System.Windows.Forms.GroupBox();
            this.defisLabel = new System.Windows.Forms.Label();
            this.length2Box = new System.Windows.Forms.TextBox();
            this.length1Box = new System.Windows.Forms.TextBox();
            this.deleteFilterButton = new System.Windows.Forms.Button();
            this.addFilterButton = new System.Windows.Forms.Button();
            this.listFilters = new System.Windows.Forms.ListBox();
            this.spectrumBox = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.propertiesBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumBox)).BeginInit();
            this.SuspendLayout();
            // 
            // propertiesBox
            // 
            this.propertiesBox.Controls.Add(this.defisLabel);
            this.propertiesBox.Controls.Add(this.length2Box);
            this.propertiesBox.Controls.Add(this.length1Box);
            this.propertiesBox.Controls.Add(this.deleteFilterButton);
            this.propertiesBox.Controls.Add(this.addFilterButton);
            this.propertiesBox.Controls.Add(this.listFilters);
            this.propertiesBox.Controls.Add(this.spectrumBox);
            this.propertiesBox.Controls.Add(this.nameLabel);
            this.propertiesBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertiesBox.Location = new System.Drawing.Point(0, 0);
            this.propertiesBox.Name = "propertiesBox";
            this.propertiesBox.Size = new System.Drawing.Size(677, 349);
            this.propertiesBox.TabIndex = 1;
            this.propertiesBox.TabStop = false;
            // 
            // defisLabel
            // 
            this.defisLabel.AutoSize = true;
            this.defisLabel.Location = new System.Drawing.Point(74, 266);
            this.defisLabel.Name = "defisLabel";
            this.defisLabel.Size = new System.Drawing.Size(13, 13);
            this.defisLabel.TabIndex = 21;
            this.defisLabel.Text = "—";
            // 
            // length2Box
            // 
            this.length2Box.Location = new System.Drawing.Point(87, 263);
            this.length2Box.Name = "length2Box";
            this.length2Box.Size = new System.Drawing.Size(54, 20);
            this.length2Box.TabIndex = 20;
            // 
            // length1Box
            // 
            this.length1Box.Location = new System.Drawing.Point(16, 263);
            this.length1Box.Name = "length1Box";
            this.length1Box.Size = new System.Drawing.Size(52, 20);
            this.length1Box.TabIndex = 19;
            // 
            // deleteFilterButton
            // 
            this.deleteFilterButton.Location = new System.Drawing.Point(16, 318);
            this.deleteFilterButton.Name = "deleteFilterButton";
            this.deleteFilterButton.Size = new System.Drawing.Size(75, 23);
            this.deleteFilterButton.TabIndex = 18;
            this.deleteFilterButton.Text = "Удалить";
            this.deleteFilterButton.UseVisualStyleBackColor = true;
            this.deleteFilterButton.Click += new System.EventHandler(this.DeleteFilterButtonClick);
            // 
            // addFilterButton
            // 
            this.addFilterButton.Location = new System.Drawing.Point(16, 289);
            this.addFilterButton.Name = "addFilterButton";
            this.addFilterButton.Size = new System.Drawing.Size(75, 23);
            this.addFilterButton.TabIndex = 16;
            this.addFilterButton.Text = "Добавить";
            this.addFilterButton.UseVisualStyleBackColor = true;
            this.addFilterButton.Click += new System.EventHandler(this.AddFilterButtonClick);
            // 
            // listFilters
            // 
            this.listFilters.FormattingEnabled = true;
            this.listFilters.Location = new System.Drawing.Point(16, 32);
            this.listFilters.Name = "listFilters";
            this.listFilters.Size = new System.Drawing.Size(125, 225);
            this.listFilters.TabIndex = 17;
            this.listFilters.SelectedIndexChanged += new System.EventHandler(this.ListFiltersSelectedIndexChanged);
            // 
            // spectrumBox
            // 
            this.spectrumBox.BackColor = System.Drawing.Color.Black;
            this.spectrumBox.Location = new System.Drawing.Point(147, 16);
            this.spectrumBox.Name = "spectrumBox";
            this.spectrumBox.Size = new System.Drawing.Size(519, 312);
            this.spectrumBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spectrumBox.TabIndex = 14;
            this.spectrumBox.TabStop = false;
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
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 349);
            this.Controls.Add(this.propertiesBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FilterForm";
            this.ShowIcon = false;
            this.Text = "Светофильтры";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FilterFormFormClosing);
            this.propertiesBox.ResumeLayout(false);
            this.propertiesBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox propertiesBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox spectrumBox;
        private System.Windows.Forms.TextBox length2Box;
        private System.Windows.Forms.TextBox length1Box;
        private System.Windows.Forms.Button deleteFilterButton;
        private System.Windows.Forms.Button addFilterButton;
        private System.Windows.Forms.ListBox listFilters;
        private System.Windows.Forms.Label defisLabel;
    }
}