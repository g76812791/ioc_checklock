using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class container
    {
        private Idrive _iDrive;

        public container(Idrive drive)
        {
            this._iDrive = drive;
        }

        public void setDrive(Idrive drive)
        {
            this._iDrive = drive;
        }

        public void Run()
        {
            _iDrive.Run();
        }
    }
}
