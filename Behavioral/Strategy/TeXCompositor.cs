namespace Strategy;

public class TeXCompositor : Compositor
{
    public override int Compose(double[] natural, double[] stretch, double[] shrink, int componentCount, int lineWidth, int[] breaks)
    {
        Console.WriteLine("--- [TeXCompositor] Analyzing total paragraph 'badness' scores... ---");

        // Dummy logic: It uses the stretch/shrink values to "optimize" 
        // Let's just pretend it found 2 perfect break points.
        if (componentCount > 5)
        {
            breaks[0] = 3;
            breaks[1] = 6;
            return 2;
        }

        return 0;
    }
}
