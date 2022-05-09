namespace ChaQaQcLabApi.Domain.Models.Rock;

public class RockTestSample : Sample
{
    public double Load { get; set; }
    public int TestedTimes { get; set; }
    public bool Passed { get; set; }
}
