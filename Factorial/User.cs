
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    
    class User
    {
        public int id { get; set; }
        
        public decimal Debt { get; set; }

        public string Name { get; set; }

        private int Age;

        public void SetAge(int BirthDate)
        {
            //get current Age 
            Age = DateTime.Now.Year - BirthDate;
        }
    }

}
