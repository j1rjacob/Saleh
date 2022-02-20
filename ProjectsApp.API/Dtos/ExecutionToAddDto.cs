using System;

public class ExecutionToAddDto 
{
    public string Item { get; set; }
    public int Qty { get; set; }
    public int AdditionalQty { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice { get; set; }
    public decimal CompleteQty { get; set; }
    public decimal CompleteCost { get; set; }
    public decimal RemainingQty { get; set; }
    public decimal RemainingCost { get; set; }
    public int ProjectId { get; set; }
}