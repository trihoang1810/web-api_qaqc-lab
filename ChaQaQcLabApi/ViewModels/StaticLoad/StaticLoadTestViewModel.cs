namespace ChaQaQcLabApi.ViewModels.StaticLoad;

public class StaticLoadTestViewModel : TestViewModel
{
    public List<StaticLoadTestSampleViewModel> Samples { get; set; } = new List<StaticLoadTestSampleViewModel>();
}
