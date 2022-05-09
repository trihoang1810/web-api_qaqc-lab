namespace ChaQaQcLabApi.ViewModels.WaterProofing;

public class SaveWaterProofingTestViewModel : SaveTestViewModel
{
    public List<SaveWaterProofingTestSampleViewModel> Samples { get; set; } = new List<SaveWaterProofingTestSampleViewModel>();
}
