using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestDemo
{
    public class Car_Unittest_Method_With_Interface:ICar
    {

        private string _name;

        public Car_Unittest_Method_With_Interface()
        {
            _name = "Ford";
        }


        public string ReturnName()
        {
            return _name;
        }
    }
}

















