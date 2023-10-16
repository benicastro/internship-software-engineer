// See https://aka.ms/new-console-template for more information

class Rectangle : Shape, IShape
{
    public double Width { get; set; }
    public double getArea()
    {
        return Length * Width;
    }
    public double getVolume()
    {
        return Length * Height * Width;
    }
}