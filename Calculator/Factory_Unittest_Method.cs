using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestDemo
{
    public class Factory_Unittest_Method
    {
        private Car_Unittest_Method _car;
        public Factory_Unittest_Method(Car_Unittest_Method car)
        {

            _car = car;
        }

        public string GetCarName()
        {
            return _car.ReturnName();
        }
    }
}
