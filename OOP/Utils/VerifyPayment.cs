using OOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Utils
{
  class VerifyPayment
  {
    public static double Verify(double payment, Sale sale)
    {
      return payment - sale.Total;
    }
  }
}
