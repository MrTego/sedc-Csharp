using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class HelpMethod
    {
        public string Printing(Student student)
        {
            return String.Format("{0} {1} {2} {3} {4}",
                student.FirstName,
                student.LastName,
                student.City,
                student.Years,
                student.Email);
        }
    }
}
