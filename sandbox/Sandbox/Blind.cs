using System.Drawing;

public class Blind
{

    public double _width;
    public double _height;
    public string _color; 

    public void Display()
    {
        Console.WriteLine($"Width: {_width}, Height: {_height}, Color { _color }");
    }

    public double getArea ()
    {
        return _width * _height;
    }
}