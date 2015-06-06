using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BushysConsole
{
    public class Bushy
    {
        public int nuts { get; set; }
        public int health {get; set;}

        public Bushy()
        {
            health = 1;
            nuts = 0;
        }

        public String GetHealth()
        {
            if (health == 1)
            {
            return "Good";
            } else if (health == 2)
            {
                return "Fair";
            
            } else if (health == 3)
            {
                return "Poor";
            } else if (health == 4)
            {
                return "Critical";
            } else
            {
                return "error, no health rating";
            }
            
        }


    }
}
