using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using OOP.Controllers.Products;
using OOP.Models;

namespace OOP.Controllers.Sales
{
  public class SaleController : ISale
  {
    public Sale addSale(List<Product> products)
    {
        double total = 0;

        foreach (var item in products)
        {
          total += (item.Value * item.Quantity);
        }

        Sale sale = new Sale() { Products = products, Total = total, Id = Guid.NewGuid() };
        return sale;
    }

    public Sale finishSale(Sale sale, double payment)
    {
        JsonSerializerOptions options = new JsonSerializerOptions() { WriteIndented = true };

        if (!File.Exists(Environment.CurrentDirectory + "\\Sales.json"))
        {
          List<Sale> sales = new List<Sale>();
          sales.Add(sale);
          string jsonString = JsonSerializer.Serialize(sales, options: options);
          File.WriteAllText(Environment.CurrentDirectory + "\\Sales.json", jsonString);
        }
        else
        {
          List<Sale> salesList = listSales();
          salesList.Add(sale);

          string jsonString = JsonSerializer.Serialize(salesList, options: options);
          File.WriteAllText(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Sales.json", jsonString);
        }

        ProductController productController = new ProductController();
        productController.removeProduct(sale);

        return sale;
    }

    public List<Sale> listSales()
    {
      string jsonData = File.ReadAllText(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Sales.json");
      List<Sale> salesList = JsonSerializer.Deserialize<List<Sale>>(jsonData);

      return salesList;
    }
  }
}