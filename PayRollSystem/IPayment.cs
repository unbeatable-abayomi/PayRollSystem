using System;
using System.Collections.Generic;
using System.Text;

namespace PayRollSystem
{
    interface IPayment
    {
        decimal GetPaymentAmount();
    }
}
