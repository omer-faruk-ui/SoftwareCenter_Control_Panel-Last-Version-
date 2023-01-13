using FontAwesome.Sharp;
using SoftwareCenter_Control_Panel_Last_Version_.Controls;
using SoftwareCenter_Control_Panel_Last_Version_.Forms;
using Utility;

namespace SoftwareCenter_Control_Panel_Last_Version_
{
    public partial class FormMain : Form
    {
        private Form currentChildForm = null!;
        public Panel PanelDesktop { get { return panelDesktop; } }

        public FormMain()
        {
            InitializeComponent();        
        }

        private void OpenChildForm(Form childform)
        {         
            if (currentChildForm != null)
            {
                if (currentChildForm.Name == childform.Name)
                    return;
                currentChildForm.Close();
            }
            currentChildForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childform);
            panelDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void BtnSoftwares_Click(object sender, EventArgs e)
        {
           OpenChildForm(new FormSoftwares());
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!Utilities.IsInternetConnected)
            {
                NoConnectionControl noConnection = new()
                {
                    Location = new Point(120,70),
                };
                panelDesktop.Controls.Add(noConnection);

                foreach (Control c in Controls) 
                {                                    
                    c.Enabled = false;
                }
            }       
        }

    }
}