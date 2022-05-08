namespace ChaQaQcLabApi.Domain.Models.ForcedClose;

public class ForcedCloseTestSample
{
    public int NumberOfClosing { get; set; }
    public int NumberOfError { get; set; }
    public ForcedCloseTestSampleResult SeatRingResult { get; set; }
    public ForcedCloseTestSampleResult SeatLidResult { get; set; }
    public string Note { get; set; }
}
