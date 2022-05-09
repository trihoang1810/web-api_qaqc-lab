namespace ChaQaQcLabApi.Domain.Models.SoftClose;

public class SoftCloseTestSample : Sample
{
    public int NumberOfClosing { get; set; }
    public SoftCloseTestSampleResult SeatLidResult { get; set; }
    public SoftCloseTestSampleResult SeatRingResult { get; set; }
}
