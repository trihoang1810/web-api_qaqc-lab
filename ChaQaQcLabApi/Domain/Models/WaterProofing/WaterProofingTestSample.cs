namespace ChaQaQcLabApi.Domain.Models.WaterProofing;

public class WaterProofingTestSample
{
    public double Temperature { get; set; }
    public int Duration { get; set; }
    public bool Passed { get; set; }
    public int NumberOfError { get; set; }
    public string Note { get; set; }
}
