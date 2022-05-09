namespace ChaQaQcLabApi.ViewModels.ForcedClose;

public class SaveForcedCloseTestSampleViewModel : SaveSampleViewModel
{
    public int NumberOfClosing { get; set; }
    public ForcedCloseTestSampleResultViewModel SeatRingResult { get; set; } = new ForcedCloseTestSampleResultViewModel();
    public ForcedCloseTestSampleResultViewModel SeatLidResult { get; set; } = new ForcedCloseTestSampleResultViewModel();
}
