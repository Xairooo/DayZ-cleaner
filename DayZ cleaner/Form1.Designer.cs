namespace DayZ_cleaner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.ZombieToastLinkLabel = new System.Windows.Forms.LinkLabel();
            this.DiscordPictureBox = new System.Windows.Forms.PictureBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DiscordPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(256, 187);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Clean";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(362, 187);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ZombieToastLinkLabel
            // 
            this.ZombieToastLinkLabel.AutoSize = true;
            this.ZombieToastLinkLabel.Location = new System.Drawing.Point(388, 239);
            this.ZombieToastLinkLabel.Name = "ZombieToastLinkLabel";
            this.ZombieToastLinkLabel.Size = new System.Drawing.Size(84, 13);
            this.ZombieToastLinkLabel.TabIndex = 3;
            this.ZombieToastLinkLabel.TabStop = true;
            this.ZombieToastLinkLabel.Text = "ZombieToast.de";
            this.ZombieToastLinkLabel.Click += new System.EventHandler(this.ZombieToastLinkLabel_Click);
            // 
            // DiscordPictureBox
            // 
            this.DiscordPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DiscordPictureBox.Image")));
            this.DiscordPictureBox.Location = new System.Drawing.Point(358, 235);
            this.DiscordPictureBox.Name = "DiscordPictureBox";
            this.DiscordPictureBox.Size = new System.Drawing.Size(24, 24);
            this.DiscordPictureBox.TabIndex = 4;
            this.DiscordPictureBox.TabStop = false;
            this.DiscordPictureBox.Click += new System.EventHandler(this.DiscordPictureBox_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultTextBox.Location = new System.Drawing.Point(256, 168);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(206, 13);
            this.ResultTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DayZ_cleaner.Properties.Resources.BesenToastmitSchrift;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.DiscordPictureBox);
            this.Controls.Add(this.ZombieToastLinkLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "DayZ cleaner";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DiscordPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.LinkLabel ZombieToastLinkLabel;
        private System.Windows.Forms.PictureBox DiscordPictureBox;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}

