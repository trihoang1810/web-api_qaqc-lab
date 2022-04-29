namespace ChaQaQcLabApi.ViewModels.ForcedClose;

public class SaveForcedCloseTestViewModel : SaveTestViewModel
{
    public ForcedCloseTestSampleResultViewModel ExpectedOutcome { get; set; } = new ForcedCloseTestSampleResultViewModel();
    public List<ForcedCloseTestSampleViewModel> Samples { get; set; } = new List<ForcedCloseTestSampleViewModel>();

}
