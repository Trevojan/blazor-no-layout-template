using BlazorFenceTemplate.Smith.Shape;
using BlazorFenceTemplate.Smith.Temper;

namespace BlazorFenceTemplate.Whetstone;

public class Whetstones
{
    public WhetWeapon WWeapon { get; set; } = new();
    
    public List<ShapeSword> Arsenal { get; set; } = TempSword.WieldSwords;
}