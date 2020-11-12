using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestDemo
{
    public class Factory
    {
        private Car _car;
        public Factory(Car car)
        {
            _car = car;
        }

        public string GetCarName()
        {
            return _car.ReturnName();
        }
    }
}
