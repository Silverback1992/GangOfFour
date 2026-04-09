namespace Strategy;

public class SimpleCompositor : Compositor
{
    public override int Compose(double[] natural, double[] stretch, double[] shrink, int componentCount, int lineWidth, int[] breaks)
    {
        Console.WriteLine("--- [SimpleCompositor] Performing greedy line-breaking... ---");

        int breakCount = 0;
        double currentLineWidth = 0;

        for (int i = 0; i < componentCount; i++)
        {
            currentLineWidth += natural[i];

            if (currentLineWidth > lineWidth)
            {
                breaks[breakCount] = i; // Break right before this word
                breakCount++;
                currentLineWidth = natural[i]; // Start new line with current word
            }
        }

        return breakCount;
    }
}
