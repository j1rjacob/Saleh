using System;

namespace ProjectsApp.API.Models
{
    public class Execution
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int Qty { get; set; }
        public int AdditionalQty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal CompleteQty { get; set; }
        public decimal CompleteCost { get; set; }
        public decimal RemainingQty { get; set; }
        public decimal RemainingCost { get; set; } 
        public Project Project { get; set; }  
        public int ProjectId { get; set; }     
    }
}