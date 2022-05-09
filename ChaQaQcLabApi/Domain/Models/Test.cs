namespace ChaQaQcLabApi.Domain.Models;

public class Test
{
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Product Product { get; set; }
    public string ProductId { get; set; }
    public TestPurpose TestPurpose { get; set; }
    public string Note { get; set; }
}
