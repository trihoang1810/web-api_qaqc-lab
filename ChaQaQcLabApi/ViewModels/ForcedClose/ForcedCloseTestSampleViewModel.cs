﻿namespace ChaQaQcLabApi.ViewModels.ForcedClose;

public class ForcedCloseTestSampleViewModel : SampleViewModel
{
    public int NumberOfClosing { get; set; }
    public ForcedCloseTestSampleResultViewModel SeatRingResult { get; set; } = new ForcedCloseTestSampleResultViewModel();
    public ForcedCloseTestSampleResultViewModel SeatLidResult { get; set; } = new ForcedCloseTestSampleResultViewModel();
}
