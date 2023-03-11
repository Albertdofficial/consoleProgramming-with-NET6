class Triangle: Shape, IShape
{
    public double Hypotennuse { get; set; }

    public Triangle()
    {

    }

    public Triangle(int hyp)
    {
       Hypotennuse = hyp;

    }

    public Triangle(int hyp, int length, int height)
    {
        Hypotennuse = hyp;  
        Length = length;
        Height = height;
    }

    public double getArea()
    {
        return .5 * Length * Height;

    }
}