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

            Console.WriteLine(help.Printing(newStudent));
            Console.WriteLine(newStudent);

            Console.ReadLine();
        }
    }
}
