using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using OOP.Controllers.Sales;
using OOP.Models;

namespace OOP.Controllers.Machine
{
  public class MachineController : IMachine
  {
    public double countSales()
    {
      SaleController saleController = new SaleController();
      List<Sale> salesList = saleController.listSales();

      double total = 0;
      foreach (var item in salesList)
      {
        total += item.Total;
      }

      return total;
    }
  }
}