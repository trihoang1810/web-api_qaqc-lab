namespace ChaQaQcLabApi.ViewModels.SoftClose;

public class SoftCloseTestViewModel : TestViewModel
{
    public SoftCloseTestSampleResultViewModel SeatLidExpectedOutcome { get; set; } = new SoftCloseTestSampleResultViewModel();
    public SoftCloseTestSampleResultViewModel SeatRingExpectedOutcome { get; set; } = new SoftCloseTestSampleResultViewModel();
    public List<SoftCloseTestSampleViewModel> Samples { get; set; } = new List<SoftCloseTestSampleViewModel>();
}
