using System.Threading.Channels;

public class Circle
{
    private double radius;
    public void SetRadius(double r)
    {
        radius = r;
    }

    public double GetRadius()
    {
        return radius;
    }
    public double Diameter()
    {
        return 2 * radius; 
    }

    public double Circumference()
    {
        return 2 * Math.PI * radius;
    }

    public double Area()
    {
        return Math.PI * radius * radius; 
    }

    public void Grow()
    {
        radius *= 2; 
    }
}
