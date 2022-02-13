namespace Brainlab1.Entities
{
    public class Rectangle : BaseShape 
    {
        public Point XY1 { get; set; }
        public Point XY2 { get; set; }

        public Rectangle(Point? xy1 = default(Point), Point? xy2 = default(Point) )
        {
            XY1 = xy1;
            XY2 = xy2;
        }



    }
}
