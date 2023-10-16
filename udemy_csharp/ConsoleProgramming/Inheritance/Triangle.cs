// See https://aka.ms/new-console-template for more information

class Triangle : Shape, IShape
{
    public double Hypotenuse { get; set; }

    public double getArea()
    {
        return 0.5 * Length * Height;
    }
}