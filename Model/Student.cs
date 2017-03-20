using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public int Years { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Student info {FirstName} {LastName} {City} {Years} {Email}";
        }

        public void ResetValues()
        {
            this.FirstName = "";
            this.LastName = "";
            this.City = "";
            this.Years = 0;
            this.Email = "";
        }



        

    }
}
