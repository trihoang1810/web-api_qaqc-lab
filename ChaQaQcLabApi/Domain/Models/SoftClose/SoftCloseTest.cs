namespace ChaQaQcLabApi.Domain.Models.SoftClose;

public class SoftCloseTest : Test
{
    public SoftCloseTestSampleResult SeatLidExpectedOutcome { get; set; }
    public SoftCloseTestSampleResult SeatRingExpectedOutcome { get; set; }
    public List<SoftCloseTestSample> Samples { get; set; }
}
