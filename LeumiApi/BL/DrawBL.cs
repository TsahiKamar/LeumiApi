using Brainlab1.Entities;
using Newtonsoft.Json.Linq;
using Point = Brainlab1.Entities.Point;

namespace Brainlab1
{
    public static class DrawBL
    {
        static object shape;

        public static dynamic CreateShape(string request) 
        {


            JObject data = JObject.Parse(request);
            var type = data["Type"].ToString();

            switch (type)
            {
                case "Circle":
                    shape = new Circle() { Type = type,Radius = Convert.ToDouble(data["radius"]),XY1 = data["XY1"].ToObject<Point>() };

                    break;
                case "Triangle":
                    shape= new Triangle() { Type = type, XY1 = data["XY1"].ToObject<Point>(), XY2 = data["XY2"].ToObject<Point>(), XY3 = data["XY3"].ToObject<Point>() };

                    break;
                case "Rectangle":
                    shape =new Brainlab1.Entities.Rectangle() { Type = type, XY1 = data["XY1"].ToObject<Point>(), XY2 = data["XY2"].ToObject<Point>() } ;
                    break;
            }
            return shape;
        }

        public static object drawLastShape(string shapeType)
        {
            switch (shapeType)
            {
                case "circle":
                    return new Circle();
                    break;
                case "triangle":
                    return new Triangle();
                    break;

                case "rectangle":
                    return new Brainlab1.Entities.Rectangle();
                    break;
            }
            return null;
        }
    }
}
