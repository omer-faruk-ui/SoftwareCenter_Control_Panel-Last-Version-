namespace SoftwareCenter_Control_Panel_Last_Version_.Controls
{
    partial class NoConnectionControl
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
            this.IconNoConection = new FontAwesome.Sharp.IconPictureBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.lblHelpMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IconNoConection)).BeginInit();
            this.SuspendLayout();
            // 
            // IconNoConection
            // 
            this.IconNoConection.BackColor = System.Drawing.Color.Transparent;
            this.IconNoConection.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IconNoConection.IconChar = FontAwesome.Sharp.IconChar.WifiStrong;
            this.IconNoConection.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.IconNoConection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconNoConection.IconSize = 100;
            this.IconNoConection.Location = new System.Drawing.Point(300, 50);
            this.IconNoConection.Name = "IconNoConection";
            this.IconNoConection.Size = new System.Drawing.Size(100, 100);
            this.IconNoConection.TabIndex = 0;
            this.IconNoConection.TabStop = false;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrorMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblErrorMessage.Location = new System.Drawing.Point(126, 181);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(471, 28);
            this.lblErrorMessage.TabIndex = 1;
            this.lblErrorMessage.Text = "There is No Internet Connection Available!!";
            // 
            // lblHelpMessage
            // 
            this.lblHelpMessage.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHelpMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHelpMessage.Location = new System.Drawing.Point(14, 222);
            this.lblHelpMessage.Name = "lblHelpMessage";
            this.lblHelpMessage.Size = new System.Drawing.Size(698, 60);
            this.lblHelpMessage.TabIndex = 2;
            this.lblHelpMessage.Text = "To use the program there should be a connection available. Please check your inte" +
    "rnet connection.";
            this.lblHelpMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NoConnectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblHelpMessage);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.IconNoConection);
            this.Name = "NoConnectionControl";
            this.Size = new System.Drawing.Size(690, 311);
            ((System.ComponentModel.ISupportInitialize)(this.IconNoConection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox IconNoConection;
        private Label lblErrorMessage;
        private Label lblHelpMessage;
    }
}
