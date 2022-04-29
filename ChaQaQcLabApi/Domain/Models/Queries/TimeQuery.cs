namespace ChaQaQcLabApi.Domain.Models.Queries;

public class TimeQuery : Query
{
    public TimeRange TimeRange { get; set; }
    public TimeQuery(int page, int itemsPerPage, TimeRange timeRange = null) : base(page, itemsPerPage)
    {
        TimeRange = timeRange;
    }
}
