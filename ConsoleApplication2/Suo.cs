using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2;

namespace ConsoleApplication2
{
    public class Suo
    {
        protected internal int _1_protectedinternal;
        protected int _2_protected;
        private int _3_private;
        public int _4_public;
        internal int _5_internal;
        public Suo()
        {
           int l1= this._1_protectedinternal;
           int l2 = this._2_protected;
           int l3 = this._3_private;
           int l4 = this._4_public;
           int l5 = this._5_internal;
        }
    }
    public class checkSuo:Suo
    {
        public checkSuo()
        {
           int l1=  this._1_protectedinternal;
           int l2 = this._2_protected;
           int l3 = this._4_public;
           int l4 = this._5_internal;
        } 
    }
    namespace ConsoleApplication3
    {
        public class checkSuo : ConsoleApplication2.Suo
        {
            public checkSuo()
            {
                int l1 = this._1_protectedinternal;
                int l2 = this._2_protected;
                int l3 = this._4_public;
                int l4 = this._5_internal;
            }
        }
    }

}





