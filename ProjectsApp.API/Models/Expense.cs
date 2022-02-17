using System;

namespace ProjectsApp.API.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string Materials { get; set; }
        public decimal Accomodation { get; set; }
        public decimal Sites { get; set; }
        public decimal Uniform { get; set; }
        public decimal LaborTools { get; set; }
        public decimal OT { get; set; }
        public decimal Tickets { get; set; }
        public decimal Vehicles { get; set; }
        public decimal Equipments { get; set; }
        public decimal Fuel { get; set; }
        public decimal Warehouse { get; set; }
        public decimal Asphalt { get; set; }
        public decimal SubContract { get; set; }
        public decimal Documents { get; set; }
        public decimal Penalties { get; set; }
        public decimal Consultancy { get; set; }
        public Project Project { get; set; }
        public int ProjectId { get; set; }
    }
}