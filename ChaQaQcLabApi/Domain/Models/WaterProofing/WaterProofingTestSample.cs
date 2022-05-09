namespace ChaQaQcLabApi.Domain.Models.WaterProofing;

public class WaterProofingTestSample : Sample
{
    public double Temperature { get; set; }
    public int Duration { get; set; }
    public bool Passed { get; set; }
}
