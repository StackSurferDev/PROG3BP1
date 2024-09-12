namespace MunicipalityApp
{
    public class Issue
    {
        // The location where the issue is reported, e.g., street address or GPS coordinates
        public string Location { get; set; }

        // Category of the issue, e.g., "Water Leak", "Pothole", etc.
        public string Category { get; set; }

        // A detailed description of the issue to give more context to the municipal workers
        public string Description { get; set; }

        // Option for users to attach media (photos, videos) related to the issue for better clarity
        public string MediaAttachment { get; set; }
    }
    //End of class
}
//End of file