namespace ChaQaQcLabApi.Domain.Models.SoftClose;

public class SoftCloseTestSample
{
    public int SampleNumber { get; set; }
    public SoftCloseTestSampleResult SeatLidResult { get; set; }
    public SoftCloseTestSampleResult SeatRingResult { get; set; }
    public string Note { get; set; }
}
