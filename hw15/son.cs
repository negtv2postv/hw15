using System;
using System.Collections.Generic;
using System.Text;

namespace hw15
{
    class son : fathersDay
    {
        public string _activity { get; set; }

        public son(string name, int age, string activity) : base(name, age)
        {
            _sonName = name;
            _age = age;
            _activity = activity;
        }

    }
}
