using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestDemo
{
    public class Car_Unittest_Static_Method : ICar
    {
        
        private static string _name;

        public Car_Unittest_Static_Method()
        {
            _name = "Ford";
        }


        public static string ReturnName()
        {
            return _name;
        }

        //Interface explicite geïmplementeerd
        string ICar.ReturnName()
        {
            return ReturnName();
        }
    }
}

















