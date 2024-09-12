namespace MunicipalityApp
{
    partial class MainMenuForm
    {
        // Required designer variable
        private System.ComponentModel.IContainer components = null;

        // MenuStrip for top navigation
        private MenuStrip menuStrip;
        private ToolStripMenuItem reportIssuesMenuItem;  // Menu item for reporting issues
        private ToolStripMenuItem localEventsMenuItem;  // Menu item for viewing local events
        private ToolStripMenuItem serviceStatusMenuItem;  // Menu item for checking service request statuses

        // Side menu panel controls
        private Panel sideMenuPanel;  // Panel on the left for side menu options
        private Button btnOpenIssues;  // Button to view open issues
        private Button btnResolvedIssues;  // Button to view resolved issues
        private Button btnUpcomingEvents;  // Button to view upcoming local events

        // Other UI components
        private PictureBox logoPictureBox;  // PictureBox for displaying the app logo
        private Label lblBanner;  // Banner label for displaying announcements or alerts
        private System.Windows.Forms.Timer bannerTimer;  // Timer to control banner scrolling text

        // Clean up any resources being used
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();  // Release resources if disposing is true and components are not null
            }
            base.Dispose(disposing);  // Call base class dispose method
        }

        // Method to initialize and set up the form components
        private void InitializeComponent()
        {
            this.SuspendLayout();  // Begin layout suspension

            // 
            // MenuStrip for Top Navigation
            // 
            this.menuStrip = new System.Windows.Forms.MenuStrip();  // Initialize MenuStrip
            this.menuStrip.BackColor = Color.FromArgb(0, 188, 212);  // Set background color to turquoise blue
            this.menuStrip.ForeColor = Color.White;  // Set text color to white for contrast
            this.menuStrip.Font = new Font("Segoe UI", 12F, FontStyle.Bold);  // Set font style
            this.menuStrip.Dock = DockStyle.Top;  // Dock MenuStrip at the top of the form

            // 
            // Add "Report Issues" menu item
            // 
            this.reportIssuesMenuItem = new ToolStripMenuItem("Report Issues");  // Initialize the "Report Issues" menu item
            this.reportIssuesMenuItem.Click += new System.EventHandler(this.ReportIssuesMenuItem_Click);  // Add click event handler

            // 
            // Add "Local Events" menu item
            // 
            this.localEventsMenuItem = new ToolStripMenuItem("Local Events & Announcements");  // Initialize the "Local Events" menu item
            this.localEventsMenuItem.Click += new System.EventHandler(this.LocalEventsMenuItem_Click);  // Add click event handler

            // 
            // Add "Service Status" menu item
            // 
            this.serviceStatusMenuItem = new ToolStripMenuItem("Service Request Status");  // Initialize the "Service Status" menu item
            this.serviceStatusMenuItem.Click += new System.EventHandler(this.ServiceStatusMenuItem_Click);  // Add click event handler

            // Add menu items to the MenuStrip
            this.menuStrip.Items.Add(this.reportIssuesMenuItem);  // Add "Report Issues" to MenuStrip
            this.menuStrip.Items.Add(this.localEventsMenuItem);  // Add "Local Events" to MenuStrip
            this.menuStrip.Items.Add(this.serviceStatusMenuItem);  // Add "Service Status" to MenuStrip

            // Add the MenuStrip to the form
            this.Controls.Add(this.menuStrip);  // Attach MenuStrip to the form

            // 
            // Side Menu Panel
            // 
            this.sideMenuPanel = new System.Windows.Forms.Panel();  // Initialize side menu panel
            this.sideMenuPanel.BackColor = Color.FromArgb(34, 34, 34);  // Set dark background color
            this.sideMenuPanel.Dock = DockStyle.Left;  // Dock the panel on the left side of the form
            this.sideMenuPanel.Width = 200;  // Set width for the panel
            this.Controls.Add(this.sideMenuPanel);  // Add panel to the form

            // 
            // PictureBox for Logo
            // 
            this.logoPictureBox = new System.Windows.Forms.PictureBox();  // Initialize PictureBox for logo
            this.logoPictureBox.Size = new System.Drawing.Size(180, 60);  // Define size for the logo
            this.logoPictureBox.Location = new Point(10, 0);  // Set position at the top of the side menu panel
            this.logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;  // Ensure the image fits the box
            this.Controls.Add(this.logoPictureBox);  // Add PictureBox to the form

            // 
            // Button for "Open Issues"
            // 
            this.btnOpenIssues = new System.Windows.Forms.Button();  // Initialize "Open Issues" button
            this.btnOpenIssues.Text = "Open Issues";  // Set button text
            this.btnOpenIssues.Size = new System.Drawing.Size(180, 50);  // Set size for the button
            this.btnOpenIssues.Location = new Point(10, 80);  // Set position under the logo
            this.btnOpenIssues.BackColor = Color.FromArgb(0, 188, 212);  // Set turquoise blue background color
            this.btnOpenIssues.ForeColor = Color.White;  // Set white text for contrast
            this.btnOpenIssues.FlatStyle = FlatStyle.Flat;  // Set flat button style
            this.btnOpenIssues.Click += new System.EventHandler(this.BtnOpenIssues_Click);  // Add click event handler
            this.sideMenuPanel.Controls.Add(this.btnOpenIssues);  // Add button to side menu panel

            // 
            // Button for "Resolved Issues"
            // 
            this.btnResolvedIssues = new System.Windows.Forms.Button();  // Initialize "Resolved Issues" button
            this.btnResolvedIssues.Text = "Resolved Issues";  // Set button text
            this.btnResolvedIssues.Size = new System.Drawing.Size(180, 50);  // Set size for the button
            this.btnResolvedIssues.Location = new Point(10, 140);  // Position it below the "Open Issues" button
            this.btnResolvedIssues.BackColor = Color.FromArgb(0, 188, 212);  // Set background color
            this.btnResolvedIssues.ForeColor = Color.White;  // Set text color
            this.btnResolvedIssues.FlatStyle = FlatStyle.Flat;  // Set flat style
            this.btnResolvedIssues.Click += new System.EventHandler(this.BtnResolvedIssues_Click);  // Add click event handler
            this.sideMenuPanel.Controls.Add(this.btnResolvedIssues);  // Add button to side menu panel

            // 
            // Button for "Upcoming Events"
            // 
            this.btnUpcomingEvents = new System.Windows.Forms.Button();  // Initialize "Upcoming Events" button
            this.btnUpcomingEvents.Text = "Upcoming Events";  // Set button text
            this.btnUpcomingEvents.Size = new System.Drawing.Size(180, 50);  // Set size for the button
            this.btnUpcomingEvents.Location = new Point(10, 200);  // Position below "Resolved Issues" button
            this.btnUpcomingEvents.BackColor = Color.FromArgb(0, 188, 212);  // Set turquoise blue background color
            this.btnUpcomingEvents.ForeColor = Color.White;  // Set white text for contrast
            this.btnUpcomingEvents.FlatStyle = FlatStyle.Flat;  // Set flat style
            this.btnUpcomingEvents.Click += new System.EventHandler(this.BtnUpcomingEvents_Click);  // Add click event handler
            this.sideMenuPanel.Controls.Add(this.btnUpcomingEvents);  // Add button to side menu panel

            // 
            // Banner for Announcements
            // 
            this.lblBanner = new System.Windows.Forms.Label();  // Initialize the banner label
            this.lblBanner.Font = new Font("Segoe UI", 12F, FontStyle.Bold);  // Set font style for the banner text
            this.lblBanner.ForeColor = Color.White;  // Set banner text color to white
            this.lblBanner.BackColor = Color.FromArgb(255, 99, 71);  // Set background color to red for alerts
            this.lblBanner.Size = new System.Drawing.Size(600, 40);  // Set size of the banner
            this.lblBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;  // Center the text
            this.lblBanner.Location = new System.Drawing.Point(200, 60);  // Position banner to the right of side panel
            this.Controls.Add(this.lblBanner);  // Add banner to the form

            // 
            // Banner Timer for scrolling announcements
            // 
            this.bannerTimer = new System.Windows.Forms.Timer();  // Initialize the timer for banner scrolling
            this.bannerTimer.Interval = 100;  // Set scrolling speed (in milliseconds)
            this.bannerTimer.Tick += new EventHandler(BannerTimer_Tick);  // Add Tick event handler to control scrolling
            this.bannerTimer.Start();  // Start the timer

            // 
            // MainMenuForm settings
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);  // Set form size
            this.Name = "MainMenuForm";  // Set form name
            this.Text = "Main Menu";  // Set form title
            this.ResumeLayout(false);  // Resume form layout logic
            this.PerformLayout();  // Ensure all controls are properly laid out
        }

        // Event handler for "Report Issues" menu item
        private void ReportIssuesMenuItem_Click(object sender, EventArgs e)
        {
            ReportIssuesForm reportIssuesForm = new ReportIssuesForm(this);  // Create new instance of ReportIssuesForm
            reportIssuesForm.Show();  // Show the ReportIssuesForm
            this.Hide();  // Hide the MainMenuForm while the other form is open
        }

        // Event handler for "Local Events" menu item
        private void LocalEventsMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature coming soon!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);  // Notify user that feature is not available yet
        }

        // Event handler for "Service Status" menu item
        private void ServiceStatusMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature coming soon!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);  // Notify user that feature is not available yet
        }

        // Event handler for "Open Issues" button
        private void BtnOpenIssues_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Showing Open Issues...", "Open Issues", MessageBoxButtons.OK, MessageBoxIcon.Information);  // Display a message indicating that open issues are being shown
        }

        // Event handler for "Resolved Issues" button
        private void BtnResolvedIssues_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Showing Resolved Issues...", "Resolved Issues", MessageBoxButtons.OK, MessageBoxIcon.Information);  // Display a message indicating that resolved issues are being shown
        }

        // Event handler for "Upcoming Events" button
        private void BtnUpcomingEvents_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Showing Upcoming Events...", "Upcoming Events", MessageBoxButtons.OK, MessageBoxIcon.Information);  // Display a message indicating that upcoming events are being shown
        }

        // Event handler for banner scrolling text
        private void BannerTimer_Tick(object sender, EventArgs e)
        {
            string currentText = lblBanner.Text;  // Get the current banner text
            lblBanner.Text = currentText.Substring(1) + currentText.Substring(0, 1);  // Scroll the text one character at a time
        }
    }
    //End of Class
}
//End of file 