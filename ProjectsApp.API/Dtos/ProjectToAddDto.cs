using System;

public class ProjectToAddDto 
{
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
    public int RemainingPeriod { get; set; }
    public int? UserId { get; set; }
}