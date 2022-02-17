using System;

namespace ProjectsApp.API.Models
{
    public class Risk
    {
        public int Id { get; set; }
        public string Issue { get; set; }
        public DateTime RiskDate { get; set; }
        public string Impact { get; set; }
        public string CorrectiveAction { get; set; }
        public string Owner { get; set; }
        public string Status { get; set; }
        public Project Project { get; set; }
        public int ProjectId { get; set; }
    }
}