namespace ChaQaQcLabApi.ViewModels.ForcedClose;

public class ForcedCloseTestSampleViewModel
{
    public int NumberOfClosing { get; set; }
    public int NumberOfError { get; set; }
    public ForcedCloseTestSampleResultViewModel SeatRingResult { get; set; } = new ForcedCloseTestSampleResultViewModel();
    public ForcedCloseTestSampleResultViewModel SeatLidResult { get; set; } = new ForcedCloseTestSampleResultViewModel();
    public string Note { get; set; }
}
