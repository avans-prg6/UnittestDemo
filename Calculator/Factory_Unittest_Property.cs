using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestDemo
{
    public class Factory_Unittest_Property
    {
        private Car_Unittest_Property _car;
        public Factory_Unittest_Property(Car_Unittest_Property car)
        {

            _car = car;
        }

        public string GetCarName()
        {
            return _car.Name;
        }
    }
}
