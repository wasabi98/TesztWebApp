using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesztWebalkalmazás
{

    public class Student
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public DateTime BirthDate { get; set; }
        public int Phone { get; set; }
        public List<Grade> Grades { get; set; }
       
    }
}
