namespace ChaQaQcLabApi.ViewModels.StaticLoad;

public class SaveStaticLoadViewModel : SaveTestViewModel
{
    public List<SaveStaticLoadTestSampleViewModel> Samples { get; set; } = new List<SaveStaticLoadTestSampleViewModel>();
}
