using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public  class Bao:Idrive
    {
        public void Run()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
