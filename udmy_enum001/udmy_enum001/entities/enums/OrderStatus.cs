using System;
using System.Collections.Generic;
using System.Text;

namespace udmy_enum001.entities.enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
