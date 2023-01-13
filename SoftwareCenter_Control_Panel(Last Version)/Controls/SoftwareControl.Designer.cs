namespace SoftwareCenter_Control_Panel_Last_Version_.Controls
{
    partial class SoftwareControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoftwareControl));
            this.IconSoftware = new System.Windows.Forms.PictureBox();
            this.lblSoftwareName = new System.Windows.Forms.Label();
            this.lblSoftwareCategory = new System.Windows.Forms.Label();
            this.IconMenu = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IconSoftware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // IconSoftware
            // 
            this.IconSoftware.Location = new System.Drawing.Point(19, 15);
            this.IconSoftware.Name = "IconSoftware";
            this.IconSoftware.Size = new System.Drawing.Size(25, 25);
            this.IconSoftware.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconSoftware.TabIndex = 0;
            this.IconSoftware.TabStop = false;
            // 
            // lblSoftwareName
            // 
            this.lblSoftwareName.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoftwareName.ForeColor = System.Drawing.Color.White;
            this.lblSoftwareName.Location = new System.Drawing.Point(17, 61);
            this.lblSoftwareName.Name = "lblSoftwareName";
            this.lblSoftwareName.Size = new System.Drawing.Size(59, 17);
            this.lblSoftwareName.TabIndex = 1;
            this.lblSoftwareName.Text = "Software";
            this.lblSoftwareName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSoftwareCategory
            // 
            this.lblSoftwareCategory.AutoSize = true;
            this.lblSoftwareCategory.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoftwareCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.lblSoftwareCategory.Location = new System.Drawing.Point(17, 88);
            this.lblSoftwareCategory.Name = "lblSoftwareCategory";
            this.lblSoftwareCategory.Size = new System.Drawing.Size(63, 17);
            this.lblSoftwareCategory.TabIndex = 2;
            this.lblSoftwareCategory.Text = "Category";
            this.lblSoftwareCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IconMenu
            // 
            this.IconMenu.BackColor = System.Drawing.Color.Transparent;
            this.IconMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(193)))));
            this.IconMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.IconMenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(193)))));
            this.IconMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconMenu.IconSize = 25;
            this.IconMenu.Location = new System.Drawing.Point(96, 15);
            this.IconMenu.Name = "IconMenu";
            this.IconMenu.Size = new System.Drawing.Size(26, 25);
            this.IconMenu.TabIndex = 3;
            this.IconMenu.TabStop = false;
            // 
            // SoftwareControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.IconMenu);
            this.Controls.Add(this.lblSoftwareCategory);
            this.Controls.Add(this.lblSoftwareName);
            this.Controls.Add(this.IconSoftware);
            this.DoubleBuffered = true;
            this.Name = "SoftwareControl";
            this.Size = new System.Drawing.Size(136, 119);
            ((System.ComponentModel.ISupportInitialize)(this.IconSoftware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox IconSoftware;
        private Label lblSoftwareName;
        private Label lblSoftwareCategory;
        private FontAwesome.Sharp.IconPictureBox IconMenu;
    }
}
