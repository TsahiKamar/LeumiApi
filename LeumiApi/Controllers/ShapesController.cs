using Brainlab1.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Brainlab1.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("[controller]")]
    public class ShapesController : ControllerBase
    {
 
        private readonly ILogger<ShapesController> _logger;


        private static List<dynamic> _SHAPES = new List<dynamic>();


        public ShapesController(ILogger<ShapesController> logger)
        {
            _logger = logger;

            //Init
            //_SHAPES.Clear();
            if (!_SHAPES.Any())
            {
                _SHAPES.Add(new Rectangle() { Type = "Rectangle" ,XY1 = new Point(),XY2 = new Point() });
                _SHAPES.Add(new Triangle() { Type = "Triangle", XY1 = new Point(), XY2 = new Point(),XY3 = new Point() });
                _SHAPES.Add(new Circle() { Type = "Circle", XY1 = new Point() });
            }
        }


        [HttpGet("Get")]
        public ActionResult<IEnumerable<dynamic>> Get(string? type)
        {
            dynamic result = Enumerable.Empty<IEnumerable<dynamic>>();
            try
            {
                switch (type)
                {
                    case "Circle":
                        result = _SHAPES.OfType<Circle>();

                        break;
                    case "Triangle":
                        result = _SHAPES.OfType<Triangle>();
                        break;

                    case "Rectangle":
                        result = _SHAPES.OfType<Rectangle>();
                        break;
                    default:
                        result = _SHAPES;
                        break;
                }
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.ToString(), null);
                return StatusCode(500);
            }
            return Ok(result); 
        }

        [HttpGet("CreateShapes")]
        public ActionResult<IEnumerable<dynamic>> CreateShapes()
        {
            try
            {

            var random = new Random();
            var list = new List<string> { "Circle", "Rectangle", "Triangle"};
            int index = random.Next(list.Count);

            //list[index]
            //shape = DrawBL.CreateShape(request);
            // _SHAPES.Add(shape);

            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.ToString(), null);
                return StatusCode(500);
            }
            return Ok();//tbc


        }



        [HttpPost("CreateShape")]
        public ActionResult<dynamic> CreateShape(string request) 
        { 
                dynamic shape ;
     
                try
                {
                    shape = DrawBL.CreateShape(request);
                    _SHAPES.Add(shape);

                }
                catch (Exception ex)
                {
                    _logger.Log(LogLevel.Error, ex.ToString(), null);
                    return StatusCode(500);
                }

                return Ok(shape);
            }


            [HttpGet("GetLastShape")]
            public ActionResult<object> GetLastShape()
            { 
                try
                {
                    return Ok(_SHAPES[_SHAPES.Count - 1]);
                }
                catch (Exception ex)
                {
                    _logger.Log(LogLevel.Error, ex.ToString(), null);
                    return StatusCode(500);
                }
            }
           

    }
}
