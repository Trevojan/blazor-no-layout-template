namespace BlazorFenceTemplate.Sheath;

public class SheathWeapon
{
    public Task Unsheathe()
    {
        Sheaths.W.WWeapon.CutHandling = Sheaths.W.WWeapon.CutHandling == "Sheathed." ? "Unsheathed!" : "Sheathed.";
        Sheaths.W.Arsenal[0].Handling = Sheaths.W.WWeapon.CutHandling;
        return Task.CompletedTask;
    }
}