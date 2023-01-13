using DataAccess.ApiHelper;
using SoftwareCenter_Control_Panel_Last_Version_.Controls;
using Utility;

namespace SoftwareCenter_Control_Panel_Last_Version_.Forms
{
    public partial class FormSoftwares : Form
    {
        readonly List<SoftwareControl> Softwares = new();
        public FormSoftwares()
        {
            InitializeComponent(); 
            LoadSoftwares();
        }

      
        private void LoadSoftwares()
        {
            var softwares =  SoftwareApiHelper.GetSoftwares().Result;
            int xSoftware = 0, ySoftware = 0;

            for (int i = 0; i < softwares.Count; i++)
            {
                if (i % ((panelSoftwares.Width) / 155) == 0 && i != 0)
                {
                    xSoftware = 0;
                    ySoftware += 150;
                }

                SoftwareControl softwareComponent = new(softwares[i])
                {
                    Location = new Point(xSoftware, ySoftware)
                };
                Softwares.Add(softwareComponent);
                xSoftware += 150;
                panelSoftwares.Controls.Add(softwareComponent);

            }
        }
        private void RedesignSoftwares()
        {
            panelSoftwares.Controls.Clear();

            int xSoftware = 0, ySoftware = 0;
            for (int i = 0; i < Softwares.Count; i++)
            {
                if (i % ((panelSoftwares.Width) / 150) == 0 && i != 0)
                {
                    xSoftware = 5;
                    ySoftware += 150;
                }

                Softwares[i].Location = new Point(xSoftware, ySoftware);

                xSoftware += 175;
                panelSoftwares.Controls.Add(Softwares[i]);
            }
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchBox.Text))
            {
                panelSoftwares.Controls.Clear();
                int x = 0, y = 0, i = 0;
                foreach (SoftwareControl sc in Softwares)
                {
                    if (sc.Name.ToLower().StartsWith(txtSearchBox.Text.ToLower()))
                    {
                        if (i % ((panelSoftwares.Width) / 139) == 0 && i != 0)
                        {
                            x = 5;
                            y += 150;
                        }
                        sc.Location = new Point(x, y);
                        panelSoftwares.Controls.Add(sc);
                        x += 150; i++;
                    }
                }
            }
            else if (txtSearchBox.Text == "")
            {
                RedesignSoftwares();
            }
        }
    }
}
