namespace ChaQaQcLabApi.ViewModels;

public class SaveTestViewModel
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string ProductId { get; set; }
    public string EmployeeId { get; set; }
    public TestPurpose TestPurpose { get; set; }
    public string Note { get; set; }
}
