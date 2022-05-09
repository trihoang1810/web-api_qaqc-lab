namespace ChaQaQcLabApi.Domain.Models.ForcedClose;

public class ForcedCloseTestSample : Sample
{
    public int NumberOfClosing { get; set; }
    public ForcedCloseTestSampleResult SeatRingResult { get; set; }
    public ForcedCloseTestSampleResult SeatLidResult { get; set; }
}
