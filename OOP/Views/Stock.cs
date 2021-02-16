using OOP.Controllers.Products;
using OOP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Views
{
  public partial class Stock : Form
  {
    public Stock()
    {
      InitializeComponent();
    }

    private void Stock_Load(object sender, EventArgs e)
    {
      ProductController productController = new ProductController();
      List<Product> products = productController.listProducts();

      stockTable.Controls.Add(new Label { Text = "Nome" }, 0, 0);
      stockTable.Controls.Add(new Label { Text = "Valor" }, 1, 0);
      stockTable.Controls.Add(new Label { Text = "Quantidade" }, 2, 0);

      stockTable.RowCount += products.Count + 1;

      for (int i = 0; i < products.Count; i++)
      {
        stockTable.Controls.Add(new Label { Text = products[i].Name }, 0, i + 1);
        stockTable.Controls.Add(new Label { Text = $"R${products[i].Value}" }, 1, i + 1);
        stockTable.Controls.Add(new Label { Text = products[i].Quantity.ToString() }, 2, i + 1);
      }
    }

  }
}
