namespace SoftwareCenter_Control_Panel_Last_Version_.Forms
{
    partial class FormSoftwares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSoftwares));
            this.pbCategory = new FontAwesome.Sharp.IconPictureBox();
            this.lblSoftwares = new System.Windows.Forms.Label();
            this.panelSoftwares = new System.Windows.Forms.Panel();
            this.BtnAddSoftware = new FontAwesome.Sharp.IconButton();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategory)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCategory
            // 
            this.pbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(0)))), ((int)(((byte)(37)))));
            this.pbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.pbCategory.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            this.pbCategory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.pbCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbCategory.IconSize = 35;
            this.pbCategory.Location = new System.Drawing.Point(39, 22);
            this.pbCategory.Name = "pbCategory";
            this.pbCategory.Size = new System.Drawing.Size(35, 35);
            this.pbCategory.TabIndex = 0;
            this.pbCategory.TabStop = false;
            // 
            // lblSoftwares
            // 
            this.lblSoftwares.AutoSize = true;
            this.lblSoftwares.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoftwares.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.lblSoftwares.Location = new System.Drawing.Point(80, 28);
            this.lblSoftwares.Name = "lblSoftwares";
            this.lblSoftwares.Size = new System.Drawing.Size(98, 23);
            this.lblSoftwares.TabIndex = 1;
            this.lblSoftwares.Text = "Softwares";
            // 
            // panelSoftwares
            // 
            this.panelSoftwares.AutoScroll = true;
            this.panelSoftwares.Location = new System.Drawing.Point(38, 80);
            this.panelSoftwares.Name = "panelSoftwares";
            this.panelSoftwares.Size = new System.Drawing.Size(934, 446);
            this.panelSoftwares.TabIndex = 2;
            // 
            // BtnAddSoftware
            // 
            this.BtnAddSoftware.FlatAppearance.BorderSize = 0;
            this.BtnAddSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddSoftware.Font = new System.Drawing.Font("Eras Medium ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddSoftware.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnAddSoftware.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            this.BtnAddSoftware.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnAddSoftware.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddSoftware.IconSize = 30;
            this.BtnAddSoftware.Location = new System.Drawing.Point(821, 553);
            this.BtnAddSoftware.Name = "BtnAddSoftware";
            this.BtnAddSoftware.Size = new System.Drawing.Size(167, 33);
            this.BtnAddSoftware.TabIndex = 3;
            this.BtnAddSoftware.Text = "Add Software";
            this.BtnAddSoftware.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAddSoftware.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddSoftware.UseVisualStyleBackColor = true;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.BackColor = System.Drawing.Color.White;
            this.txtSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchBox.ForeColor = System.Drawing.Color.Black;
            this.txtSearchBox.Location = new System.Drawing.Point(34, 4);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.PlaceholderText = "Search";
            this.txtSearchBox.Size = new System.Drawing.Size(200, 20);
            this.txtSearchBox.TabIndex = 4;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.txtSearchBox);
            this.panel1.Location = new System.Drawing.Point(722, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 30);
            this.panel1.TabIndex = 5;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 20;
            this.iconPictureBox1.Location = new System.Drawing.Point(8, 7);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(20, 20);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            // 
            // FormSoftwares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(0)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1032, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnAddSoftware);
            this.Controls.Add(this.panelSoftwares);
            this.Controls.Add(this.lblSoftwares);
            this.Controls.Add(this.pbCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSoftwares";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSoftwares";
            ((System.ComponentModel.ISupportInitialize)(this.pbCategory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox pbCategory;
        private Label lblSoftwares;
        private Panel panelSoftwares;
        private FontAwesome.Sharp.IconButton BtnAddSoftware;
        private TextBox txtSearchBox;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}