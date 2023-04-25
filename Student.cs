using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoweringC_
{
    record Student
    {
        public Student(string name)
        {
            this.Name = name;
        }
        public string Name { get; init; }
    }
}
