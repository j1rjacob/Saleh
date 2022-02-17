using System;

namespace ProjectsApp.API.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime PlannedDate { get; set; }
        public DateTime IssuanceDate { get; set; }
        public int PlannedRemDays { get; set; }
        public int ActualDays { get; set; }
        public int DelayedDays { get; set; }
        public int Status { get; set; }
        public string InvoiceNo { get; set; }
        public decimal Amount { get; set; }
        public string Remarks { get; set; }
        public Project Project { get; set; }
        public int ProjectId { get; set; }
    }
}