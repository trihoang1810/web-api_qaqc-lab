namespace ChaQaQcLabApi.ViewModels.WaterProofing;

public class SaveWaterProofingTestSampleViewModel : SaveSampleViewModel
{
    public double Temperature { get; set; }
    public int Duration { get; set; }
    public bool Passed { get; set; }
}
