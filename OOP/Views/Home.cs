using OOP.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void checkStock(object sender, EventArgs e)
    {
      var stock = new Stock();
      stock.Show();
    }

    private void checkSales(object sender, EventArgs e)
    {
      var sales = new Sales();
      sales.Show();
    }

    private void goToShop(object sender, EventArgs e)
    {
      var shop = new Shop();
      shop.Show();
    }

    private void Home_Load(object sender, EventArgs e)
    {

    }
  }
}
