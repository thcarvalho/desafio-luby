using OOP.Controllers.Sales;
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
  public partial class Sales : Form
  {
    public Sales()
    {
      InitializeComponent();
    }

    private void Sales_Load(object sender, EventArgs e)
    {
      SaleController saleController = new SaleController();
      List<Sale> sales = saleController.listSales();

      salesTable.Controls.Add(new Label { Text = "Identificador" }, 0, 0);
      salesTable.Controls.Add(new Label { Text = "Total" }, 1, 0);

      salesTable.RowCount += sales.Count + 1;

      for (int i = 0; i < sales.Count; i++)
      {
        salesTable.Controls.Add(new Label { Text = sales[i].Id.ToString() }, 0, i + 1);
        salesTable.Controls.Add(new Label { Text = $"R${sales[i].Total}" }, 1, i + 1);
      }

      double total = 0;
      foreach (var item in sales)
      {
        total += item.Total;
      }

      labelTotal.Text = $"Total: R${total}";
    }
  }
}
