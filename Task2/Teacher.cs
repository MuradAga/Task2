using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Teacher : Person, ITeach
    {
        public string Profession { get; set; }

        public override string GetFullInfo()
        {
            return this.Name + " " + this.Lastname + " " + this.Profession;
        }

        public void Teach()
        {
            throw new NotImplementedException();
        }
    }
}
