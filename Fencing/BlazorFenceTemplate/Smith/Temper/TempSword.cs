using BlazorFenceTemplate.Sheath;
using BlazorFenceTemplate.Smith.Shape;
using BlazorFenceTemplate.Whetstone;

namespace BlazorFenceTemplate.Smith.Temper;

public class TempSword : ShapeSword
{
    static ShapeSword _sword = new()
    {
        LiterallyAsword = "This is literally a sword.",
        Handling = new("Sheathed.")
    };

    public static List<ShapeSword> WieldSwords = new()
    {
        _sword,
    };
}