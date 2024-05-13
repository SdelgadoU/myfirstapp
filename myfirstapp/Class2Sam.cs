using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstapp
{
    internal class Class2Sam
    {
        public int number { get; set; }
        public Class2Sam(int number)
        {

            this.number = number;

        }
        public int minusnum(int a,  int b,int c)
        { 
        return a - b - c * number;

        }
    }
}
