using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");


        List<Shape> myList = new List<Shape>();
        Square mySquare = new Square("red", 4);
        Rectangle myRectangle = new Rectangle("blue", 3, 4);
        Circle myCircle = new Circle("green", 3);
        myList.Add(mySquare);
        myList.Add(myRectangle);
        myList.Add(myCircle);

        foreach (Shape shape in myList) {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }

    }
}