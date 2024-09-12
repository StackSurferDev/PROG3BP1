using System;
using System.Windows.Forms;

namespace MunicipalityApp
{
    static class Program
    {
        // Main entry point of the application
        [STAThread]  // Indicates that the COM threading model for the application is single-threaded apartment (STA)
        static void Main()
        {
            // Enable visual styles for the application (e.g., modern look for controls)
            Application.EnableVisualStyles();

            // Ensures that the application uses the default rendering for text (consistent across different environments)
            Application.SetCompatibleTextRenderingDefault(false);

            // Run the application starting with the MainMenuForm
            Application.Run(new MainMenuForm());  // Ensure you're starting the correct form, in this case, the MainMenuForm
        }
    }
    //End of class
}
//End of file 
