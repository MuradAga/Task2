using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Person
    {
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name { get; set; }
        public string Lastname { get; set; }
        private int _id;

        public abstract string GetFullInfo();
    }
}
