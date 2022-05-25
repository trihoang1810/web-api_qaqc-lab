using Microsoft.AspNetCore.SignalR;
using ChaQaQcLabApi.Domain.Models.Monitor;

namespace ChaQaQcLabApi.Hubs;

public class RealtimeCommunicationHub : Hub
{
    public async Task SendForcedCloseMonitor(ForcedCloseMonitor forcedCloseMonitor)
    {
        await Clients.All.SendAsync("ForcedCloseMonitor", forcedCloseMonitor);
    }
    public async Task SendSoftCloseMonitor(SoftCloseMonitor softCloseMonitor)
    {
        await Clients.All.SendAsync("SoftCloseMonitor", softCloseMonitor);
    }
    public async Task SendEnduranceMonitor(EnduranceMonitor enduranceMonitor)
    {
        await Clients.All.SendAsync("EnduranceMonitor", enduranceMonitor);
    }
    public async Task SendWaterProofingMonitor(WaterProofingMonitor waterProofingMonitor)
    {
        await Clients.All.SendAsync("WaterProofingMonitor", waterProofingMonitor);
    }
}
