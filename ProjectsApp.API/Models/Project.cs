using System;
using System.Collections.Generic;

namespace ProjectsApp.API.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectManager { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string ProjectOwner { get; set; }
        public string Department { get; set; }
        public string ProjectArea { get; set; }
        public DateTime PODate { get; set; }
        public string PONo { get; set; }
        public decimal ProjectAmount { get; set; }  
        public DateTime ProjectStartDate { get; set; }  
        public DateTime ProjectEndDate { get; set; }  
        public int ProjectPeriod { get; set; }   
        public int? RemainingPeriod { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
        public ICollection<Execution> Executions { get; set; }
        public ICollection<Risk> Risks { get; set; }
        public ICollection<Expense> Expenses { get; set; }
        public User User { get; set; }
        public int? UserId { get; set; }
    }
}