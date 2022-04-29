namespace ChaQaQcLabApi.ViewModels.ForcedClose;

public class ForcedCloseTestViewModel : TestViewModel
{
    public ForcedCloseTestSampleResultViewModel ExpectedOutcome { get; set; } = new ForcedCloseTestSampleResultViewModel();
    public List<ForcedCloseTestSampleViewModel> Samples { get; set; } = new List<ForcedCloseTestSampleViewModel>();
}
