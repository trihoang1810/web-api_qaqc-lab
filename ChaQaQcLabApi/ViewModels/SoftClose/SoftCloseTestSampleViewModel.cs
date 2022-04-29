namespace ChaQaQcLabApi.ViewModels.SoftClose;

public class SoftCloseTestSampleViewModel
{
    public int SampleNumber { get; set; }
    public SoftCloseTestSampleResultViewModel SeatLidResult { get; set; } = new SoftCloseTestSampleResultViewModel();
    public SoftCloseTestSampleResultViewModel SeatRingResult { get; set; } = new SoftCloseTestSampleResultViewModel();
    public string Note { get; set; }
}
