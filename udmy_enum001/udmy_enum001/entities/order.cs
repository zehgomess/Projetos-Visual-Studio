using System;
using System.Collections.Generic;
using System.Text;
using udmy_enum001.entities.enums;

namespace udmy_enum001.entities
{
    internal class order
    {
        public int id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
