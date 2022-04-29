namespace ChaQaQcLabApi.ViewModels.ForcedClose;

public class ForcedCloseTestSampleViewModel
{
    public int SampleNumber { get; set; }
    public ForcedCloseTestSampleResultViewModel Result { get; set; } = new ForcedCloseTestSampleResultViewModel();
    public string Note { get; set; }
}
