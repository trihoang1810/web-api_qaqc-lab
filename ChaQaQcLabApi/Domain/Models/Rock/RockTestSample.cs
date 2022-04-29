namespace ChaQaQcLabApi.Domain.Models.Rock;

public class RockTestSample
{
    public double Load { get; set; }
    public int TestedTimes { get; set; }
    public bool Passed { get; set; }
    public int NumberOfErrors { get; set; }
    public string Note { get; set; }
}
