using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Student : Person, ILearn
    {
        public string GroupName { get; set; }
        public override string GetFullInfo()
        {
            return this.Name + " " + this.Lastname + " " + this.GroupName;
        }

        public void Learn()
        {
            throw new NotImplementedException();
        }
    }
}
