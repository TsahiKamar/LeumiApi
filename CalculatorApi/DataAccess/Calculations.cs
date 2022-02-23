using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.DataAccess
{
        [Table("Calculations_2")]
        public class Calculations_2
        {
            [Key]
            [Column("id")]
            [Required]
            public int id { get; set; }

            [Column("num1")]
            public double num1 { get; set; }

            [Column("oper")]
            public char oper { get; set; }

            [Column("num2")]
            public double num2 { get; set; }

            [Column("result")]
            public double result { get; set; }

    }

}



