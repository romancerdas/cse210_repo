using System.Reflection.Metadata.Ecma335;

public class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    override public double GetArea()
    {
        double area = (_side * _side);
        return area;
    }
}

