using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_AJAX_Lear_.Models;

namespace MVC_AJAX_Lear_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var portfolio = new PortfolioViewModel
            {
                Name = "SANDIP SURATI",
                Title = "Backend Developer",
                Location = "Ahmedabad, Gujarat",
                Phone = "+91 9925714412",
                About = "Motivated and detail-oriented Backend Developer with hands-on experience in developing and maintaining web applications using Microsoft technologies. Proficient in ASP.NET Core, C#, Entity Framework, and SQL Server. Adept at writing clean, efficient code and managing databases.",
                Email = "sandipsurati062@gmail.com",
                LinkedIn = "https://www.linkedin.com/in/sandip-surati-9b7769284/?originalSubdomain=in",
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "Entity Framework", "MS SQL Server", "Web API", "ADO.NET", "JavaScript", "jQuery", "Bootstrap", "AJAX", "Git", "RESTful APIs" },
                Experiences = new List<Experience>
                {
                    new Experience
                    {
                        Position = ".NET Developer",
                        Company = "PlusInfosys Pvt Ltd",
                        Location = "Ahmedabad",
                        Duration = "Jan 2024 - Present",
                        Description = "Developed and maintained robust backend solutions using .NET technologies. Collaborated with cross-functional teams to implement scalable, secure, and efficient solutions. Continuously improved system performance through troubleshooting and code optimization."
                    }
                },
                Education = new List<Education>
                {
                    new Education
                    {
                        Degree = "Master of Computer Application (M.C.A)",
                        Institution = "Gujarat Vidyapith",
                        Location = "Ahmedabad",
                        Duration = "2022 - 2024"
                    },
                    new Education
                    {
                        Degree = "Bachelor of Computer Application (B.C.A)",
                        Institution = "Veer Narmad South Gujarat University (VNSGU)",
                        Location = "Bharuch",
                        Duration = "2019 - 2022"
                    }
                },
                Projects = new List<Project>
                {
                    new Project
                    {
                        Title = "MPOS (MHOUSE)",
                        Duration = "Jan 2024 - Sep 2024",
                        Description = "A comprehensive Point of Sale (POS) system for retailers with front-end POS features and back-office inventory management. Includes supplier integration, promotional offers, and automated price updates.",
                        TechStack = "Windows Forms, ASP.NET Core Web API, MVC Core, Bootstrap, jQuery, MS SQL Server, AWS DynamoDB, Hangfire, Identity Framework",
                        Implementations = new List<string>
                        {
                            "Windows Background Service for Automated Price Updates",
                            "Hangfire-Based License Check Mechanism (5-second intervals)",
                            "RESTful API Development with JSON responses",
                            "Role-Based Access Control (RBAC) & JWT Authentication",
                            "Centralized Logging Using AWS DynamoDB with replication",
                            "Custom Middleware for Token Validation",
                            "Supplier Integration & Promotional Offers Management"
                        }
                    },
                    new Project
                    {
                        Title = "TradeX",
                        Duration = "Oct 2024 - Jan 2025",
                        Description = "A data analytics platform providing detailed import-export trade statistics for India. Delivers insights on international trade volumes by country, state, commodity with personalized notifications and monthly summaries.",
                        TechStack = "ASP.NET Core Web API, Firebase Cloud Messaging, MS SQL Server, Entity Framework, Identity Framework, Background Services",
                        Implementations = new List<string>
                        {
                            "User-Authenticated API for Trade Statistics",
                            "Firebase Cloud Messaging (FCM) Integration",
                            "Daily Background Job for Data Monitoring & Alerts",
                            "Custom Middleware for JWT Token Validation",
                            "Personalized Notification System",
                            "Monthly Summary Reports (Top 5 Countries/States/Commodities)",
                            "Device-specific FCM Token Management"
                        }
                    },
                    new Project
                    {
                        Title = "Next3PL",
                        Duration = "Jan 2025 - Present",
                        Description = "A third-party logistics (3PL) management system for streamlining logistics operations, inventory handling, warehousing, and order fulfillment. Supports multi-format file processing and real-time order tracking.",
                        TechStack = "ASP.NET Core Web API, MS SQL Server, ADO.NET, Entity Framework, RabbitMQ, Hangfire, FTP Integration, XML/CSV/JSON Processing",
                        Implementations = new List<string>
                        {
                            "Multi-Format Order File Importer (XML, CSV, JSON)",
                            "RabbitMQ Queue Processing with Hangfire",
                            "FTP Server Integration for File Retrieval",
                            "Authentication & Security Middleware",
                            "Centralized Exception Handling System",
                            "Warehouse Module Coordination",
                            "Real-time Order Status Updates"
                        }
                    }
                }
            };
            return View(portfolio);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
