namespace ChaQaQcLabApi.ViewModels.WaterProofing;

public class SaveWaterProofingTestViewModel : SaveTestViewModel
{
    public List<WaterProofingTestSampleViewModel> Samples { get; set; } = new List<WaterProofingTestSampleViewModel>();
}
