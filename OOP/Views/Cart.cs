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
  public partial class Cart : Form
  {
    List<Product> products = new List<Product>();
    Sale sale = new Sale();

    public Cart(List<Product> products, Sale sale)
    {
      InitializeComponent();
      this.products = products;
      this.sale = sale;
    }

    private void Cart_Load(object sender, EventArgs e)
    {
      try
      {
        cartTable.Controls.Add(new Label { Text = "Nome" }, 0, 0);
        cartTable.Controls.Add(new Label { Text = "Valor" }, 1, 0);
        cartTable.Controls.Add(new Label { Text = "Quantidade" }, 2, 0);

        cartTable.RowCount += products.Count + 1;

        for (int i = 0; i < products.Count; i++)
        {
          cartTable.Controls.Add(new Label { Text = products[i].Name }, 0, i + 1);
          cartTable.Controls.Add(new Label { Text = $"R${products[i].Value}" }, 1, i + 1);
          cartTable.Controls.Add(new Label { Text = products[i].Quantity.ToString() }, 2, i + 1);
        }

        cartLabel.Text = $"Total: R${sale.Total.ToString("0.00")}";
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);  
      }
      
    }

    private void payAccount(object sender, EventArgs e)
    {
      try
      {
        if (Double.TryParse(payTextBox.Text, out double payment))
        {
          SaleController saleController = new SaleController();
          double verifyPayment = VerifyPayment.Verify(payment, sale);
          if (verifyPayment < 0)
          {
            throw new Exception($"Ainda faltam R${Math.Abs(verifyPayment).ToString("0.00")} reais");
          }

          saleController.finishSale(sale, payment);
          
          MessageBox.Show("Compra realizada com sucesso!");

          if (verifyPayment > 0)
          {
            MessageBox.Show($"Troco de: {verifyPayment.ToString("0.00")}");
          }

          Close();
        }
        else
        {
          MessageBox.Show("Por favor, insira um valor válido");
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
