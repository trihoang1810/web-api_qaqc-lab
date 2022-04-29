namespace ChaQaQcLabApi.ViewModels;

public class TestViewModel
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public ProductViewModel Product { get; set; } = new ProductViewModel();
    public TestPurpose TestPurpose { get; set; }
    public string Note { get; set; }
    public TesterViewModel Tester { get; set; } = new TesterViewModel();
}
