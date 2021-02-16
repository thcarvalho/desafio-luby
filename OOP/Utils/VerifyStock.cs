using OOP.Controllers.Products;
using OOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Utils
{
  class VerifyStock
  {
    public static string Verify(List<Product> products)
    {
      ProductController productController = new ProductController();
      List<Product> currentProducts = productController.listProducts();

      foreach (var item in products)
      {
        Product product = currentProducts.FirstOrDefault(x => x.Id == item.Id);

        if (product.Quantity < 0)
        {
          return "Sem estoque desse produto!";
        }
        if (product.Quantity - item.Quantity < 0)
        {
          return "Você está comprando mais itens do que tem no estoque!";
        }
        return null;
      }
      return null;
    }
  }
}
