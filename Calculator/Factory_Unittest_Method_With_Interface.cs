using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestDemo
{
    public class Factory_Unittest_Method_With_Interface
    {
        private ICar _car;
        public Factory_Unittest_Method_With_Interface(ICar car)
        {

            _car = car;
        }

        public string GetCarName()
        {
            return _car.ReturnName();
        }
    }
}
