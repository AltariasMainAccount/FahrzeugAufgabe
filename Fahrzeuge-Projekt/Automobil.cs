using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace Fahrzeuge_Projekt
{
    class Automobil : Landfahrzeug
    {
        public override void SetMaxSpeed(int x)
        {
            if(x > 500)
            {
                x = 500;
            }
            GetSetMaxSpeed = x;
        }

        public override void SetWheelAmount(int x)
        {
            if (x > 10)
            {
                x = 10;
            }
            GetSetWheel = x;
        }

        public override void SetActive()
        {
            if(GetSetActive == true)
            {
                GetSetActive = false;
            }
            else
            {
                GetSetActive = true;
            }
        }

        public override void SetFuelType(string x)
        {
            base.SetFuelType(x);
        }
    }
}
