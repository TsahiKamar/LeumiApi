namespace Brainlab1.Entities
{

    public class Circle : BaseShape
    {

        public double Radius { get; set; }
        public Point XY1 { get; set; }  

        public Circle(double radius = 2, Point? center = default(Point))
        {
            Radius = radius;
            XY1 = center;
        }

    }


}







