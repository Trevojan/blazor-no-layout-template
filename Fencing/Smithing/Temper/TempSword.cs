using Smithing.Shape;

namespace Smithing.Temper;

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