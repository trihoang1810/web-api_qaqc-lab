namespace ChaQaQcLabApi.ViewModels.Rock;

public class RockTestViewModel : TestViewModel
{
    public List<RockTestSampleViewModel> Samples { get; set; } = new List<RockTestSampleViewModel>();
}
