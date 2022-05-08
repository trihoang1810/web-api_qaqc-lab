namespace ChaQaQcLabApi.ViewModels.WaterProofing;

public class WaterProofingTestViewModel : TestViewModel
{
    public List<WaterProofingTestSampleViewModel> Samples { get; set; } = new List<WaterProofingTestSampleViewModel>();
}
