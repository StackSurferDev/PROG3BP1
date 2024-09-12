namespace MunicipalityApp
{
    partial class ReportIssuesForm
    {
        // Required designer variable
        private System.ComponentModel.IContainer components = null;

        // Input fields and form controls
        private System.Windows.Forms.TextBox txtLocation;  // TextBox for user to input the issue location
        private System.Windows.Forms.ComboBox cmbCategory;  // ComboBox for selecting the issue category
        private System.Windows.Forms.RichTextBox txtDescription;  // RichTextBox for a detailed description of the issue
        private System.Windows.Forms.Button btnAttachMedia;  // Button to attach media (photos, etc.)
        private System.Windows.Forms.Button btnSubmit;  // Button to submit the form
        private System.Windows.Forms.Label lblMediaAttachment;  // Label to display the attached media file name
        private System.Windows.Forms.Button btnBack;  // Button to return to the previous screen
        private System.Windows.Forms.ProgressBar progressBar;  // ProgressBar to show form completion progress
        private System.Windows.Forms.ComboBox cmbProvince;  // ComboBox for selecting the province
        private System.Windows.Forms.Label lblLocation;  // Label for the Location field
        private System.Windows.Forms.Label lblCategory;  // Label for the Category field
        private System.Windows.Forms.Label lblProvince;  // Label for the Province field
        private System.Windows.Forms.Label lblDescription;  // Label for the Description field

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
            this.txtLocation = new System.Windows.Forms.TextBox();  // Initialize the Location TextBox
            this.cmbCategory = new System.Windows.Forms.ComboBox();  // Initialize the Category ComboBox
            this.txtDescription = new System.Windows.Forms.RichTextBox();  // Initialize the Description RichTextBox
            this.btnAttachMedia = new System.Windows.Forms.Button();  // Initialize the Attach Media Button
            this.btnSubmit = new System.Windows.Forms.Button();  // Initialize the Submit Button
            this.lblMediaAttachment = new System.Windows.Forms.Label();  // Initialize the Media Attachment Label
            this.btnBack = new System.Windows.Forms.Button();  // Initialize the Back Button
            this.cmbProvince = new System.Windows.Forms.ComboBox();  // Initialize the Province ComboBox
            this.progressBar = new System.Windows.Forms.ProgressBar();  // Initialize the ProgressBar
            this.lblLocation = new System.Windows.Forms.Label();  // Initialize the Location Label
            this.lblCategory = new System.Windows.Forms.Label();  // Initialize the Category Label
            this.lblProvince = new System.Windows.Forms.Label();  // Initialize the Province Label
            this.lblDescription = new System.Windows.Forms.Label();  // Initialize the Description Label
            this.SuspendLayout();  // Begin the form layout suspension

            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;  // Ensure the Location Label adjusts to the text size
            this.lblLocation.ForeColor = System.Drawing.Color.White;  // Set label text color to white for dark theme
            this.lblLocation.Location = new System.Drawing.Point(100, 10);  // Set label position
            this.lblLocation.Name = "lblLocation";  // Assign a name for the label
            this.lblLocation.Size = new System.Drawing.Size(58, 17);  // Set label size
            this.lblLocation.Text = "Location";  // Set label text

            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(100, 30);  // Set textbox position
            this.txtLocation.Name = "txtLocation";  // Assign a name for the textbox
            this.txtLocation.Size = new System.Drawing.Size(200, 22);  // Set textbox size
            this.txtLocation.TabIndex = 1;  // Set tab order for this control

            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;  // Ensure the Category Label adjusts to the text size
            this.lblCategory.ForeColor = System.Drawing.Color.White;  // Set label text color to white
            this.lblCategory.Location = new System.Drawing.Point(100, 60);  // Set label position
            this.lblCategory.Name = "lblCategory";  // Assign a name for the label
            this.lblCategory.Size = new System.Drawing.Size(65, 17);  // Set label size
            this.lblCategory.Text = "Category";  // Set label text

            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;  // Enable dropdown functionality for the ComboBox
            this.cmbCategory.Items.AddRange(new object[] {
            "Sanitation",  // Category option
            "Roads",  // Category option
            "Utilities"});  // Category option
            this.cmbCategory.Location = new System.Drawing.Point(100, 80);  // Set ComboBox position
            this.cmbCategory.Name = "cmbCategory";  // Assign a name for the ComboBox
            this.cmbCategory.Size = new System.Drawing.Size(200, 24);  // Set ComboBox size
            this.cmbCategory.TabIndex = 3;  // Set tab order

            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;  // Ensure the Province Label adjusts to the text size
            this.lblProvince.ForeColor = System.Drawing.Color.White;  // Set label text color to white
            this.lblProvince.Location = new System.Drawing.Point(100, 110);  // Set label position
            this.lblProvince.Name = "lblProvince";  // Assign a name for the label
            this.lblProvince.Size = new System.Drawing.Size(61, 17);  // Set label size
            this.lblProvince.Text = "Province";  // Set label text

            // 
            // cmbProvince
            // 
            this.cmbProvince.FormattingEnabled = true;  // Enable dropdown functionality for the ComboBox
            this.cmbProvince.Items.AddRange(new object[] {
            "Eastern Cape",  // Province option
            "Free State",  // Province option
            "Gauteng",  // Province option
            "KwaZulu-Natal",  // Province option
            "Limpopo",  // Province option
            "Mpumalanga",  // Province option
            "Northern Cape",  // Province option
            "North West",  // Province option
            "Western Cape"});  // Province option
            this.cmbProvince.Location = new System.Drawing.Point(100, 130);  // Set ComboBox position
            this.cmbProvince.Name = "cmbProvince";  // Assign a name for the ComboBox
            this.cmbProvince.Size = new System.Drawing.Size(200, 24);  // Set ComboBox size
            this.cmbProvince.TabIndex = 5;  // Set tab order

            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;  // Ensure the Description Label adjusts to the text size
            this.lblDescription.ForeColor = System.Drawing.Color.White;  // Set label text color to white
            this.lblDescription.Location = new System.Drawing.Point(100, 160);  // Set label position
            this.lblDescription.Name = "lblDescription";  // Assign a name for the label
            this.lblDescription.Size = new System.Drawing.Size(79, 17);  // Set label size
            this.lblDescription.Text = "Description";  // Set label text

            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(100, 180);  // Set RichTextBox position
            this.txtDescription.Name = "txtDescription";  // Assign a name for the RichTextBox
            this.txtDescription.Size = new System.Drawing.Size(200, 100);  // Set RichTextBox size
            this.txtDescription.TabIndex = 7;  // Set tab order

            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(100, 290);  // Set progress bar position below the description
            this.progressBar.Name = "progressBar";  // Assign a name for the progress bar
            this.progressBar.Size = new System.Drawing.Size(220, 20);  // Set progress bar size
            this.progressBar.TabIndex = 13;  // Set tab order

            // 
            // btnAttachMedia
            // 
            this.btnAttachMedia.Location = new System.Drawing.Point(100, 320);  // Set button position
            this.btnAttachMedia.Name = "btnAttachMedia";  // Assign a name for the button
            this.btnAttachMedia.Size = new System.Drawing.Size(150, 30);  // Set button size
            this.btnAttachMedia.TabIndex = 9;  // Set tab order
            this.btnAttachMedia.Text = "Attach Media";  // Set button text
            this.btnAttachMedia.UseVisualStyleBackColor = true;  // Enable the button style

            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(100, 360);  // Set button position
            this.btnSubmit.Name = "btnSubmit";  // Assign a name for the button
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);  // Set button size
            this.btnSubmit.TabIndex = 11;  // Set tab order
            this.btnSubmit.Text = "Submit";  // Set button text
            this.btnSubmit.UseVisualStyleBackColor = true;  // Enable the button style

            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(220, 360);  // Set button position next to the Submit button
            this.btnBack.Name = "btnBack";  // Assign a name for the button
            this.btnBack.Size = new System.Drawing.Size(100, 30);  // Set button size
            this.btnBack.TabIndex = 12;  // Set tab order
            this.btnBack.Text = "Back";  // Set button text
            this.btnBack.UseVisualStyleBackColor = true;  // Enable the button style

            // 
            // ReportIssuesForm
            // 
            this.ClientSize = new System.Drawing.Size(420, 450);  // Set the form size
            this.Controls.Add(this.lblLocation);  // Add the Location Label to the form
            this.Controls.Add(this.txtLocation);  // Add the Location TextBox to the form
            this.Controls.Add(this.lblCategory);  // Add the Category Label to the form
            this.Controls.Add(this.cmbCategory);  // Add the Category ComboBox to the form
            this.Controls.Add(this.lblProvince);  // Add the Province Label to the form
            this.Controls.Add(this.cmbProvince);  // Add the Province ComboBox to the form
            this.Controls.Add(this.lblDescription);  // Add the Description Label to the form
            this.Controls.Add(this.txtDescription);  // Add the Description RichTextBox to the form
            this.Controls.Add(this.progressBar);  // Add the ProgressBar to the form
            this.Controls.Add(this.btnAttachMedia);  // Add the Attach Media Button to the form
            this.Controls.Add(this.btnSubmit);  // Add the Submit Button to the form
            this.Controls.Add(this.btnBack);  // Add the Back Button to the form
            this.Name = "ReportIssuesForm";  // Assign a name to the form
            this.Text = "Report Issues";  // Set the form title text
            this.ResumeLayout(false);  // Resume the form layout logic
            this.PerformLayout();  // Ensure controls are properly laid out
        }
    }
    //End of class
}
//End of file