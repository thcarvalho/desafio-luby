using System.Collections.Generic;
using OOP.Models;

namespace OOP.Controllers.Sales
{
  public interface ISale
  {
    Sale addSale(List<Product> products);
    Sale finishSale(Sale sale, double payment);
    List<Sale> listSales();
  }
}