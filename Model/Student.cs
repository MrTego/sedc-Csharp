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

        public  string  Printing()
        {
            return String.Format("{0} {1} {2} {3} {4}",
                this.FirstName,
                this.LastName,
                this.City,
                this.Years,
                this.Email);
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
