namespace ChaQaQcLabApi.ViewModels.SoftClose;

public class SaveSoftCloseTestSampleViewModel : SaveSampleViewModel
{
    public int NumberOfClosing { get; set; }
    public SoftCloseTestSampleResultViewModel SeatLidResult { get; set; } = new SoftCloseTestSampleResultViewModel();
    public SoftCloseTestSampleResultViewModel SeatRingResult { get; set; } = new SoftCloseTestSampleResultViewModel();
}
