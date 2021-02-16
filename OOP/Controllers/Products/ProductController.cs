using System;
using System.Collections.Generic;
using System.IO;
using OOP.Models;
using System.Text.Json;
using System.Linq;

namespace OOP.Controllers.Products
{
  public class ProductController : IProduct
  {
    public async void addProducts(Product product)
    {
      List<Product> products = new List<Product>();
      // product.Id = Guid.NewGuid();

      products.Add(product);
      JsonSerializerOptions options = new JsonSerializerOptions() { WriteIndented = true };

      using FileStream createStream = File.Create(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/Products.json");
      await JsonSerializer.SerializeAsync(createStream, products, options);
    }

    public List<Product> listProducts()
    {
      string jsonString = File.ReadAllText(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/Products.json");

      List<Product> products = JsonSerializer.Deserialize<List<Product>>(jsonString);

      return products;
    }

    public void removeProduct(Sale sale)
    {
      ProductController productController = new ProductController();
      List<Product> currentProducts = productController.listProducts();
      
      JsonSerializerOptions options = new JsonSerializerOptions() { WriteIndented = true };

      foreach (var item in currentProducts)
      {
        Product product = sale.Products.FirstOrDefault(x => x.Id == item.Id);
        if (product != null)
        {
          item.Quantity -= product.Quantity;
        }
      }

      string jsonStr = JsonSerializer.Serialize(currentProducts, options: options);
      File.WriteAllText(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/Products.json", jsonStr); 
    }
  }
}
