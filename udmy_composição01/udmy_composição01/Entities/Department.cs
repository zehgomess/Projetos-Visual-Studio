using System;
using System.Collections.Generic;
using System.Text;

namespace udmy_composição01.Entities
{
    class Department
    {
        public string Name { get; set; }

        public Department()
        {
        }
        public Department(string name)
        {
            Name = name;
        }
    }
}
