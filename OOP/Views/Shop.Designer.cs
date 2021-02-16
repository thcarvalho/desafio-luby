
namespace OOP.Views
{
  partial class Shop
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.shopTable = new System.Windows.Forms.TableLayoutPanel();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // shopTable
      // 
      this.shopTable.AutoSize = true;
      this.shopTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
      this.shopTable.ColumnCount = 4;
      this.shopTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.60194F));
      this.shopTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.39806F));
      this.shopTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
      this.shopTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246F));
      this.shopTable.Location = new System.Drawing.Point(23, 120);
      this.shopTable.Name = "shopTable";
      this.shopTable.RowCount = 1;
      this.shopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.shopTable.Size = new System.Drawing.Size(861, 54);
      this.shopTable.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.button1.Location = new System.Drawing.Point(707, 40);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(177, 41);
      this.button1.TabIndex = 1;
      this.button1.Text = "Ir para Carrinho";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.btnCart);
      // 
      // Shop
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(916, 450);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.shopTable);
      this.Name = "Shop";
      this.Text = "Shop";
      this.Load += new System.EventHandler(this.Shop_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel shopTable;
    private System.Windows.Forms.Button button1;
  }
}