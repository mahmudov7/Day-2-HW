using System.Drawing;

public class Circle : Shape
{
    double radius{get;set;}
    public Circle(string color,double r):base(color)
    {
        radius = r;
    }
}