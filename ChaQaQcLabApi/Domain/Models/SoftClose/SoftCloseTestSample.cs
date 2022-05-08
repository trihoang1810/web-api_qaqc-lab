namespace ChaQaQcLabApi.Domain.Models.SoftClose;

public class SoftCloseTestSample
{
    public int NumberOfClosing { get; set; }
    public int NumberOfError { get; set; }
    public SoftCloseTestSampleResult SeatLidResult { get; set; }
    public SoftCloseTestSampleResult SeatRingResult { get; set; }
    public string Note { get; set; }
}
