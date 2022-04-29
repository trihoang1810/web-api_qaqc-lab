namespace ChaQaQcLabApi.ViewModels.QueriesViewModels;

public class TimeQueryViewModel : QueryViewModel
{
    public DateTime? StartTime { get; set; }
    public DateTime? StopTime { get; set; }
    public DateTime? DateQuery { get; set; }

    public TimeQueryViewModel()
    {
        if (StartTime == null)
        {
            StartTime = DateTime.MinValue;
        }

        if (StopTime == null)
        {
            StopTime = DateTime.Now;
        }
    }
}
