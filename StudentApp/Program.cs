using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var help = new HelpMethod();
            Student newStudent = new Student();
            newStudent.FirstName = "Riste";
            newStudent.LastName = "Tegovski";
            newStudent.City = "Bitola";
            newStudent.Years = 24;
            newStudent.Email = "ristetegovski@gmail.com";

            Student newStudent1 = new Student();
            newStudent1.FirstName = "Marija";
            newStudent1.LastName = "Tegovski";
            newStudent1.City = "Bitola";
            newStudent1.Years = 24;
            newStudent1.Email = "ristetegovski@gmail.com";

            Console.WriteLine(help.Printing(newStudent));
            Console.WriteLine(newStudent);

            Console.WriteLine(help.Printing(newStudent1));
            Console.WriteLine(newStudent1);

            Console.ReadLine();
        }
    }
}
