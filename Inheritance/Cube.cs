class Cube : Shape
{
    public int Width { get; set; }

    public Cube(int width, int height, int length)
    {
        Width = width;
        Height = height;
        Length = length;
    }

    public double getArea()
    {
        return Length * Width;

    }

    public double getVolume()
    {
        return Length * Width * Height;
    }
}

