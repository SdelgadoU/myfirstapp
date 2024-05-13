using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstapp
{
    internal class Class1
    {

        public int Number { get; set; }
        public Class1(int number)
        {
            Number = number;
        }

        public int GetSqurt() 
        {
            return Number*Number;
        }
    }
}
