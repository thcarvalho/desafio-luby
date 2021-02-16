using OOP.Controllers.Products;
using OOP.Controllers.Sales;
using OOP.Models;
using OOP.Utils;
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
  public partial class Shop : Form
  {
    List<Product> productsShop = new List<Product>();

    public Shop()
    {
      InitializeComponent();
    }


    private void Shop_Load(object sender, EventArgs e)
    {
      ProductController productController = new ProductController();
      List<Product> products = productController.listProducts();

      shopTable.Controls.Add(new Label { Text = "Nome" }, 0, 0);
      shopTable.Controls.Add(new Label { Text = "Valor" }, 1, 0);
      shopTable.Controls.Add(new Label { Text = "Quantidade" }, 2, 0);

      shopTable.RowCount += products.Count + 1;

      List<Button> listButtons = new List<Button>();

      for (int i = 0; i < products.Count; i++)
      {
        Button btnAdd = new Button();
        listButtons.Add(btnAdd);
        btnAdd.Text = "Adicionar";
        btnAdd.Name = "btnAdd" + i;

        shopTable.Controls.Add(new Label { Text = products[i].Name }, 0, i + 1);
        shopTable.Controls.Add(new Label { Text = $"R${products[i].Value}" }, 1, i + 1);
        shopTable.Controls.Add(new Label { Text = products[i].Quantity.ToString() }, 2, i + 1);
        shopTable.Controls.Add(btnAdd, 3, i + 1);

        btnAdd.Click += (object sender, EventArgs e) =>
        {
          Button btn = ((Button)sender);
          string btnIndex = btn.Name.Substring(6);
          if (btn.Text == "Adicionar")
          {
            productsShop.Add(products[Int32.Parse(btnIndex)]);
            btn.Text = "Remover";
          }
          else
          {
            productsShop.Remove(products[Int32.Parse(btnIndex)]);
            btn.Text = "Adicionar";
          }
        };
      }
    }

    private void btnCart(object sender, EventArgs e)
    {
      try
      {
        SaleController saleController = new SaleController();

        foreach (var item in productsShop)
        {
          item.Quantity = 1;
        }

        string message = VerifyStock.Verify(productsShop);

        if (message != null)
        {
          throw new Exception(message);
        }

        Sale sale = saleController.addSale(productsShop);
        Cart cart = new Cart(productsShop, sale);
        cart.Show();
        Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
