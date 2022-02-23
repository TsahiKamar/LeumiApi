using Api.DataAccess;
using CalculatorApi.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CalculatorApi.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("[controller]")]
    public class CalcController : ControllerBase
    {
 
        private readonly ILogger<CalcController> _logger;
        private readonly AppDbContext _context;

 
        private static List<Calculations_2> _CALCULATIONS = new List<Calculations_2>();


        public CalcController(ILogger<CalcController> logger,AppDbContext context) 
        {
            _logger = logger;
            _context = context;
 
            //Init
            //_SHAPES.Clear();
            //if (!_CALCULATIONS.Any())
            //{
            //    _CALCULATIONS.Add(new Calculations_() { id = 0 ,num1=2,oper='*',num2=3,result=6 });
            //    _CALCULATIONS.Add(new Calculations_() { id= 0,num1 = 4, oper = '-', num2 = 1, result = 3 });
            //    _CALCULATIONS.Add(new Calculations_() { id= 0,num1 = 20, oper = '+', num2 = 3, result = 23 });
            //}
            //_CALCULATIONS.ForEach(s => _context.calculations_.Add(s));
            //_context.SaveChanges();

        }


        [HttpGet("Get")]
        public ActionResult<IEnumerable<Calc>> Get()
        {
            IEnumerable<Calc> calculations = Enumerable.Empty<Calc>();

            try
            {
                calculations = _context.calculations_2.AsEnumerable().Select(r => new Calc()
                {
                    Num1 = r.num1,
                    Oper = r.oper,
                    Num2 = r.num2,
                    Result = r.result
                }
                ).ToList();
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.ToString(), null);
                return StatusCode(500);
            }
            return Ok(calculations.ToList<Calc>());
        }


        [HttpPost("AddCalc")]
        public ActionResult<dynamic> AddCalc(Calc request)
        {

            try
            {
             
                 _context.calculations_2.Add(new Calculations_2() {num1 = request.Num1,oper = request.Oper,num2 = request.Num2,result = request.Result });
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.ToString(), null);
                return StatusCode(500);
            }

            return Ok(request);
        }



    }
}
