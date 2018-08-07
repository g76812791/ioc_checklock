using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  container contain = new container(new Bez());
              contain.Run();
              contain.setDrive(new Bao());
              contain.Run();*/

            Suo suo = new Suo();
            //验证自己
          
            //验证同一个程序集
            checkSuo checkSuo = new checkSuo();

            int l4 = checkSuo._1_protectedinternal;
            int l5 = checkSuo._4_public;
            int l6 = checkSuo._5_internal;

            //验证跨程序集
            ConsoleApplication3.checkSuo checksuo3 = new ConsoleApplication3.checkSuo();

          

        }
    }
}
