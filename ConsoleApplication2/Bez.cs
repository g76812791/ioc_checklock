using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Bez : Idrive
    {
        public void Run()
        {
           Console.WriteLine(this.GetType().Name);
        }
    }
}
