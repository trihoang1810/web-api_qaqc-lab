using Microsoft.AspNetCore.SignalR;

namespace ChaQaQcLabApi.Hubs;

public class RealtimeCommunicationHub : Hub
{
    public async Task SendCurlingForceTest(CurlingForceTest curlingForceTest)
    {
        await Clients.All.SendAsync("CurlingForceTest", curlingForceTest);
    }
    public async Task SendForcedCloseTest(ForcedCloseTest forcedCloseTest)
    {
        await Clients.All.SendAsync("ForcedCloseTest", forcedCloseTest);
    }
    public async Task SendRockTest(RockTest rockTest)
    {
        await Clients.All.SendAsync("RockTest", rockTest);
    }
    public async Task SendSoftCloseTest(SoftCloseTest softCloseTest)
    {
        await Clients.All.SendAsync("SoftCloseTest", softCloseTest);
    }
    public async Task SendStaticLoadTest(StaticLoadTest staticLoadTest)
    {
        await Clients.All.SendAsync("StaticLoadTest", staticLoadTest);
    }
}
