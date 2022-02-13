namespace Brainlab1.Entities
{
    public class Triangle : BaseShape
    {
        public Point XY1 { get; set; }
        public Point XY2 { get; set; }
        public Point XY3 { get; set; }

        public Triangle(Point xy1 = default(Point), Point xy2 = default(Point), Point xy3 = default(Point))
        {
            XY1 = xy1;
            XY2 = xy2;
            XY3 = xy3;
        }

    }
}
