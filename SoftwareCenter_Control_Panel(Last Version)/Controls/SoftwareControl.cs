using APIHelper.Models;

namespace SoftwareCenter_Control_Panel_Last_Version_.Controls
{
    public partial class SoftwareControl : UserControl
    {
        public SoftwareControl()
        {
            InitializeComponent();
        }

        public new string Name
        {
            get
            {
                return lblSoftwareName.Text;
            }
            set
            {
                lblSoftwareName.Text = value;
            }
        }

        public string Category
        {
            get
            {
                return lblSoftwareCategory.Text;
            }
            set
            {
                lblSoftwareCategory.Text = value;
            }
        }

        public string IconURL
        {
            get
            {
                return IconSoftware.ImageLocation;
            }
            set
            {
                IconSoftware.ImageLocation = value;
            }
        }
        public SoftwareControl(Software _software) : this()
        {
            this.Name = _software.Name;
            this.IconURL = _software.IconURL.Replace("<?>", Dimensions.tiny);
            this.Category = _software.Category;
        }
        public static class Dimensions
        {
            public static readonly string tiny = "30x30";
            public static readonly string small = "60x60";
            public static readonly string medium = "300x300";
            public static readonly string big = "600x600";
            public static readonly string full = "orig";
        }
    }
}
