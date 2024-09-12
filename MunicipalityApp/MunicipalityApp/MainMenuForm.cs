using Microsoft.VisualBasic.Logging;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalityApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            SetDarkModeTheme();  // Apply dark mode theme
            InitializeBannerText();  // Initialize the scrolling banner

        }

        // Set the dark mode theme for the form
        private void SetDarkModeTheme()
        {
            this.BackColor = Color.FromArgb(34, 34, 34);  // Dark background color
        }

        // Initialize the banner text
        //Banner text will consist of live problems which will be implemented at a later stage
        private void InitializeBannerText()
        {
            lblBanner.Text = "⚠️ Water outage in District 5 - Expected resolution: 5 PM | " +
                             "⚠️ Road maintenance on Main Street starting tomorrow. | " +
                             "⚠️ Public event: Tree Planting on Saturday!";
        }
    }
    //End of class 
}
//End of file 