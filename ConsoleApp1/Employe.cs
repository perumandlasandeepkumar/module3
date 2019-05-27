using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Table("emp")]
    class Employe
    {
        [Key]
        public int code { get; set; }
        public string name { get; set; }
        public string salary { get; set; }
        public int deptid { get; set; }

    }
}
