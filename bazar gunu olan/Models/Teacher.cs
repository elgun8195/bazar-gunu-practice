using System;
using System.Collections.Generic;
using System.Text;

namespace bazar_gunu_olan.Models
{
    class Teacher:Person
    {
        private int _exp;
        private static int _id;
        public int Id { get; set; }
        public int Experience
        {
            get { return _exp; }
            set
            {
                if (value >= 1 && value <= 80)
                {
                    _exp = value;
                }
            }
        }
    }
}
