namespace Strategy;

public abstract class Compositor
{
    public abstract int Compose(double[] natural, double[] stretch, double[] shrink, int componentCount, int lineWidth, int[] breaks);
}
