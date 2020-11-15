using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestDemo
{
    public class Factory_Unittest_Static_Method
    {
        private ICar _car;
        public Factory_Unittest_Static_Method(ICar car)
        {

            _car = car;
        }

        public string GetCarName()
        {
            return _car.ReturnName();
        }
    }
}
