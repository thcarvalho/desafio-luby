using System.Collections.Generic;
using OOP.Models;

namespace OOP.Controllers.Products
{
  public interface IProduct
  {
    void addProducts(Product product);
    List<Product> listProducts();
    void removeProduct(Sale sale);
  }
}