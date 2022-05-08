namespace ChaQaQcLabApi.ViewModels.ForcedClose;

public class SaveForcedCloseTestViewModel : SaveTestViewModel
{
    public List<ForcedCloseTestSampleViewModel> Samples { get; set; } = new List<ForcedCloseTestSampleViewModel>();

}
