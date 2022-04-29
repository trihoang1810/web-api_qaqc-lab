namespace ChaQaQcLabApi.ViewModels.StaticLoad;

public class SaveStaticLoadViewModel : SaveTestViewModel
{
    public List<StaticLoadTestSampleViewModel> Samples { get; set; } = new List<StaticLoadTestSampleViewModel>();
}
