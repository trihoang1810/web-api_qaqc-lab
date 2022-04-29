namespace ChaQaQcLabApi.ViewModels.SoftClose;

public class SoftCloseTestSampleResultViewModel : SoftCloseTestSample
{
    public int FallTime { get; set; }
    public bool IsBumperIntact { get; set; }
    public bool IsUnleaked { get; set; }
    public bool Passed { get; set; }
}
