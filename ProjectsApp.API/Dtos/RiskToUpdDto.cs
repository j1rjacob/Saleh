using System;

public class RiskToUpdDto 
{
    public int Id { get; set; }
    public string Issue { get; set; }
    public DateTime RiskDate { get; set; }
    public string Impact { get; set; }
    public string CorrectiveAction { get; set; }
    public string Owner { get; set; }
    public string Status { get; set; }        
    public int ProjectId { get; set; }    
}