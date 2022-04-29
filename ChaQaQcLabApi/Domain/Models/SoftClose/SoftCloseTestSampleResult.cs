namespace ChaQaQcLabApi.Domain.Models.SoftClose;

public class SoftCloseTestSampleResult
{
    public int FallTime { get; set; }
    public bool IsBumperIntact { get; set; }
    public bool IsUnleaked { get; set; }
    public bool Passed { get; set; }
}
