public class Rectangle : Shape
{
    double width{get;set;}
    double heigh{get;set;}
    public Rectangle(string color,double he,double w):base(color)
    {
        heigh = he;
        width = w;
    }

}