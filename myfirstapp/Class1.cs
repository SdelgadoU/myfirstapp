using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstapp
{
    internal record Class1(int Number)
    {
        public int GetSqurt()
        {
            return Number * Number;
        }
        public int sum(int x) => x + x;
    }
}













