using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestDemo
{
    public class Car
    {
        private string _typeName;
        private string _name;
        
        public Car()
        {
           _typeName = "Sedan";
           _name = "Ford";
        }

        public virtual string ReturnName()
        {
            return _name;
        }
    }
}
