

Console.WriteLine("Enter Length: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Width: ");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Height: ");
int height = Convert.ToInt32(Console.ReadLine());


Cube cube = new Cube(width, height, length);

var rectangle = new Rectangle() { Width = width, Length=length};

// constructors
var triangle = new Triangle();
var triangle1 = new Triangle(10);
var triangle2 = new Triangle() {Height=height, Length = length, Hypotennuse = 20};
var triangle3 = new Triangle(20, height, length);

cube.Length = length;
cube.Width = width;
cube.Height = height;

triangle.Length = length;
triangle.Height = height;

rectangle.Length = length;
rectangle.Width = width;

Console.WriteLine($"Cube Area is: {cube.getArea()}");
Console.WriteLine($"Cube Volume is: {cube.getVolume()}");

Console.WriteLine($"Triangle Area is: {triangle.getArea()}");
Console.WriteLine($"Triangle1 Area Is: {triangle1.getArea()}");
Console.WriteLine($"Triangle2 Area Is: {triangle2.getArea()}");
Console.WriteLine($"Triangle3 Area Is: {triangle3.getArea()}");


Console.WriteLine($"Rectangle Area is: {rectangle.getArea()}");
