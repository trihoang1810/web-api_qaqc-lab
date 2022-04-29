namespace ChaQaQcLabApi.ViewModels.SoftClose;

public class SaveSoftCloseTestViewModel : SaveTestViewModel
{
    public SoftCloseTestSampleResultViewModel SeatLidExpectedOutcome { get; set; } = new SoftCloseTestSampleResultViewModel();
    public SoftCloseTestSampleResultViewModel SeatRingExpectedOutcome { get; set; } = new SoftCloseTestSampleResultViewModel();
    public List<SoftCloseTestSampleViewModel> Samples { get; set; } = new List<SoftCloseTestSampleViewModel>();

}
