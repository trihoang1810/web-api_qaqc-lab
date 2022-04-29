namespace ChaQaQcLabApi.ViewModels.CurlingForce;

public class SaveCurlingForceTestViewModel : SaveTestViewModel
{
    public List<CurlingForceTestSampleViewModel> Samples { get; set; } = new List<CurlingForceTestSampleViewModel>();
}
