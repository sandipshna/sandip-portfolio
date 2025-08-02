namespace MVC_AJAX_Lear_.Models
{
    public class Project
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string TechStack { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public List<string> Implementations { get; set; } = new();
        public string? GitHubUrl { get; set; }
        public string? LiveUrl { get; set; }
    }

    public class Experience
    {
        public string Position { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public class Education
    {
        public string Degree { get; set; } = string.Empty;
        public string Institution { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
    }

    public class PortfolioViewModel
    {
        public string Name { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string About { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? LinkedIn { get; set; }
        public string? GitHub { get; set; }
        public List<Project> Projects { get; set; } = new();
        public List<string> Skills { get; set; } = new();
        public List<Experience> Experiences { get; set; } = new();
        public List<Education> Education { get; set; } = new();
    }
}