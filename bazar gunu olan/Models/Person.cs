using System;
using System.Collections.Generic;
using System.Text;

namespace bazar_gunu_olan.Models
{
    class Person
    {
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value != 0 && value > 0)
                {
                    _age = value;

                }
            }
        }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
