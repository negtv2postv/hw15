using System;
using System.Collections.Generic;
using System.Text;

namespace hw15
{
    class fathersDay
    {
        public string _sonName { get; set; }
        public int _age { get; set; }

        public fathersDay(string name, int age)
        {
            _sonName = name;
            _age = age;
        }

        public void letsGo()
        {
            Console.WriteLine("Ok mijo let's go have fun in the Dells");

        }

    }
}
