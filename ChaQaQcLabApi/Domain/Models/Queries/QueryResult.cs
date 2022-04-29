namespace ChaQaQcLabApi.Domain.Models.Queries;

public class QueryResult<T>
{
    public IEnumerable<T> Items { get; set; } = new List<T>();
    public int TotalItems { get; set; } = 0;
}
