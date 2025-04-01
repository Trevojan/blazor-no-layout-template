using Microsoft.AspNetCore.Components;

namespace BlazorFenceTemplate.Sheath;
using Whetstone;

public class Sheaths
{
    [Inject] public static Whetstones W { get; set; } = new();
    public static event Action? Ui;
    public static void Reload() => Ui?.Invoke();
    public SheathWeapon SWeapon = new();
}