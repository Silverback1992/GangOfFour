namespace Strategy;

public class ArrayCompositor : Compositor
{
    private readonly int _itemsPerLine;

    public ArrayCompositor(int itemsPerLine)
    {
        _itemsPerLine = itemsPerLine;
    }

    public override int Compose(double[] natural, double[] stretch, double[] shrink, int componentCount, int lineWidth, int[] breaks)
    {
        Console.WriteLine($"--- [ArrayCompositor] Breaking every {_itemsPerLine} items... ---");

        int breakCount = 0;
        for (int i = _itemsPerLine; i < componentCount; i += _itemsPerLine)
        {
            breaks[breakCount] = i;
            breakCount++;
        }

        return breakCount;
    }
}
