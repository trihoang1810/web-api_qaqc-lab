namespace ChaQaQcLabApi.ViewModels.ForcedClose;

public class SaveForcedCloseTestViewModel : SaveTestViewModel
{
    public List<SaveForcedCloseTestSampleViewModel> Samples { get; set; } = new List<SaveForcedCloseTestSampleViewModel>();

}
