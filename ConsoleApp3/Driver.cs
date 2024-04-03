using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Driver
    {
        public int NumberOfPenalties { get; set; }

        public Driver()
        {
            NumberOfPenalties = 0;
        }

        public void IncreasePenalties()
        {
            NumberOfPenalties++;
        }
    }
}
