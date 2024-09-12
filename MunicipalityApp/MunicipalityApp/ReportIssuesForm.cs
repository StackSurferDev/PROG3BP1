using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace MunicipalityApp
{
    public partial class ReportIssuesForm : Form
    {
        // Variable to keep track of form progress
        private int currentProgress = 0;
        // Store a reference to the MainMenuForm instance
        private MainMenuForm _mainMenuForm;
        // List to hold all the reported issues
        private List<Issue> issues = new List<Issue>();
        // File path for saving issues in JSON format
        private string issuesFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "issues.json");

        // Constructor that takes in the MainMenuForm reference
        public ReportIssuesForm(MainMenuForm mainMenuForm)
        {
            InitializeComponent();  // Initialize form components
            SetDarkModeTheme();  // Set up dark mode theme
            InitializeEventHandlers();  // Set up all the necessary event handlers
            _mainMenuForm = mainMenuForm;  // Save the MainMenuForm instance
            LoadIssues();  // Load issues from the JSON file if it exists
            UpdateProgressBar();  // Set initial state of the progress bar
        }

        // Method to apply a dark mode theme to the form
        private void SetDarkModeTheme()
        {
            this.BackColor = Color.FromArgb(34, 34, 34);  // Set a dark background color

            // Apply dark theme to all relevant controls
            CustomizeControl(txtLocation);
            CustomizeControl(cmbCategory);
            CustomizeControl(cmbProvince);
            CustomizeControl(txtDescription);

            // Set label text color to white for better visibility
            lblLocation.ForeColor = Color.White;
            lblProvince.ForeColor = Color.White;
            lblCategory.ForeColor = Color.White;
            lblDescription.ForeColor = Color.White;
            lblMediaAttachment.ForeColor = Color.White;

            // Customize the appearance and placement of buttons
            CustomizeButton(btnAttachMedia);
            CustomizeButton(btnSubmit);
            CustomizeButton(btnBack);

            // Adjust button positions for better UI
            btnAttachMedia.Location = new Point(100, 320);  // Set position for Attach Media button
            btnSubmit.Location = new Point(100, 380);  // Set position for Submit button
            btnBack.Location = new Point(260, 380);  // Set position for Back button

            // Customize the appearance of the progress bar
            progressBar.BackColor = Color.FromArgb(28, 28, 28);
            progressBar.ForeColor = Color.FromArgb(30, 144, 255);  // Set a turquoise blue color
            progressBar.Style = ProgressBarStyle.Continuous;  // Smooth progress style
        }

        // Helper method to apply dark theme styling to controls
        private void CustomizeControl(Control control)
        {
            control.BackColor = Color.FromArgb(50, 50, 50);  // Dark background for controls
            control.ForeColor = Color.White;  // White text for readability
        }

        // Customize button appearance and size
        private void CustomizeButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;  // Flat button style
            button.FlatAppearance.BorderSize = 0;  // No border for buttons
            button.BackColor = Color.FromArgb(0, 188, 212);  // Turquoise blue color
            button.ForeColor = Color.White;  // White text on buttons
            button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);  // Bold font for buttons
            button.Size = new Size(150, 45);  // Set consistent button size
        }

        // Update the progress bar based on the form fields completion status
        private void UpdateProgressBar()
        {
            progressBar.Value = currentProgress;

            // Display a message when progress reaches 100%
            if (currentProgress == 100)
            {
                MessageBox.Show("Complete! Ready to Submit.");
            }
        }

        // Event handler to update progress bar when a form field is modified
        private void FieldUpdated(object sender, EventArgs e)
        {
            int progress = 0;

            // Increment progress based on the fields that are filled out
            if (!string.IsNullOrWhiteSpace(txtLocation.Text)) progress += 20;
            if (cmbCategory.SelectedIndex != -1) progress += 20;
            if (cmbProvince.SelectedIndex != -1) progress += 20;
            if (!string.IsNullOrWhiteSpace(txtDescription.Text)) progress += 30;
            if (!string.IsNullOrWhiteSpace(lblMediaAttachment.Text)) progress += 10;

            currentProgress = progress;
            UpdateProgressBar();  // Update the progress bar after changes
        }

        // Method to initialize event handlers for form controls
        private void InitializeEventHandlers()
        {
            txtLocation.TextChanged += FieldUpdated;
            cmbCategory.SelectedIndexChanged += FieldUpdated;
            cmbProvince.SelectedIndexChanged += FieldUpdated;
            txtDescription.TextChanged += FieldUpdated;

            // Attach event handlers for buttons
            btnSubmit.Click += btnSubmit_Click;
            btnAttachMedia.Click += btnAttachMedia_Click;
            btnBack.Click += btnBack_Click;
        }

        // Event handler for when the Submit button is clicked
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled before submission
            if (string.IsNullOrWhiteSpace(txtLocation.Text) || cmbCategory.SelectedItem == null || cmbProvince.SelectedItem == null || string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please complete all fields before submitting!", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // Exit if the form is incomplete
            }

            // Create a new issue object with the user's inputs
            Issue newIssue = new Issue
            {
                Location = txtLocation.Text,
                Category = cmbCategory.SelectedItem.ToString(),
                Description = txtDescription.Text,
                MediaAttachment = lblMediaAttachment.Text  // Attach the media file if any
            };

            issues.Add(newIssue);  // Add the new issue to the list
            SaveIssues();  // Save the list of issues to a file

            // Notify the user that the issue was successfully reported
            MessageBox.Show("Thank you! You've successfully reported an issue!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset the form and progress bar after submission
            ResetForm();
        }

        // Event handler for when the Attach Media button is clicked
        private void btnAttachMedia_Click(object sender, EventArgs e)
        {
            // Open a dialog to let the user select a media file
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lblMediaAttachment.Text = openFileDialog.FileName;  // Display the selected file's path
                    FieldUpdated(sender, e);  // Update the progress bar since media was attached
                }
            }
        }

        // Event handler for when the Back button is clicked
        private void btnBack_Click(object sender, EventArgs e)
        {
            _mainMenuForm.Show();  // Show the MainMenuForm again
            this.Close();  // Close the current form
        }

        // Reset the form fields and progress bar after a successful submission
        private void ResetForm()
        {
            currentProgress = 0;  // Reset progress to zero
            txtLocation.Clear();  // Clear the location field
            cmbCategory.SelectedIndex = -1;  // Reset category dropdown
            cmbProvince.SelectedIndex = -1;  // Reset province dropdown
            txtDescription.Clear();  // Clear the description field
            lblMediaAttachment.Text = "";  // Reset the media attachment label
            UpdateProgressBar();  // Update the progress bar after resetting
        }

        // Save the list of issues to a JSON file
        private void SaveIssues()
        {
            try
            {
                string jsonData = JsonSerializer.Serialize(issues);  // Serialize the list of issues
                File.WriteAllText(issuesFilePath, jsonData);  // Write the serialized data to a file
            }
            catch (Exception ex)
            {
                // Display an error message if the save fails
                MessageBox.Show($"Error saving issues: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load the list of issues from a JSON file
        private void LoadIssues()
        {
            try
            {
                if (File.Exists(issuesFilePath))
                {
                    string jsonData = File.ReadAllText(issuesFilePath);  // Read the JSON data from the file
                    issues = JsonSerializer.Deserialize<List<Issue>>(jsonData) ?? new List<Issue>();  // Deserialize the data into a list of issues
                }
            }
            catch (Exception ex)
            {
                // Display an error message if the load fails
                MessageBox.Show($"Error loading issues: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    //End of class
}
//End of file