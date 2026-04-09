namespace Strategy;

public class Composition
{
    private readonly Compositor _compositor;
    private readonly List<Component> _components;
    private readonly int _lineWidth;

    public Composition(Compositor compositor, List<Component> components, int lineWidth)
    {
        _compositor = compositor;
        _components = components;
        _lineWidth = lineWidth;
    }

    public void Repair()
    {
        int componentCount = _components.Count;

        double[] natural = [.. _components.Select(c => c.NaturalSize)];
        double[] stretchability = [.. _components.Select(c => c.StretchAbility)];
        double[] shrinkability = [.. _components.Select(c => c.ShrinkAbility)];

        int[] breaks = new int[componentCount];

        int breakCount = _compositor.Compose(natural, stretchability, shrinkability, componentCount, _lineWidth, breaks);

        // --- Added for visual feedback ---
        Console.WriteLine($"Resulting Layout ({breakCount + 1} lines):");
        int lastBreak = 0;
        for (int i = 0; i < breakCount; i++)
        {
            int breakIndex = breaks[i];
            var line = _components.Skip(lastBreak).Take(breakIndex - lastBreak);
            Console.WriteLine($"| {string.Join(" ", line.Select(c => c.Content))}");
            lastBreak = breakIndex;
        }
        // Print the remaining components after the last break
        var lastLine = _components.Skip(lastBreak);
        Console.WriteLine($"| {string.Join(" ", lastLine.Select(c => c.Content))}");
        Console.WriteLine(new string('-', 30));
    }
}