namespace ChaQaQcLabApi.ViewModels.ForcedClose;

public class ForcedCloseTestViewModel : TestViewModel
{
    public List<ForcedCloseTestSampleViewModel> Samples { get; set; } = new List<ForcedCloseTestSampleViewModel>();
}
