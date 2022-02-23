using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace CalculatorApi.Entities
{
    public class Calc
    {
        public double Num1 { get; set; }
        public char Oper { get; set; }
        public double Num2 { get; set; }
        public double Result { get; set; }

    }
}
