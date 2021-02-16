
namespace OOP.Views
{
  partial class Sales
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
      this.salesTable = new System.Windows.Forms.TableLayoutPanel();
      this.labelTotal = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // salesTable
      // 
      this.salesTable.AutoSize = true;
      this.salesTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
      this.salesTable.ColumnCount = 2;
      this.salesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.salesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.salesTable.Location = new System.Drawing.Point(56, 111);
      this.salesTable.Name = "salesTable";
      this.salesTable.RowCount = 1;
      this.salesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.salesTable.Size = new System.Drawing.Size(694, 46);
      this.salesTable.TabIndex = 0;
      // 
      // labelTotal
      // 
      this.labelTotal.AutoSize = true;
      this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.labelTotal.Location = new System.Drawing.Point(661, 38);
      this.labelTotal.Name = "labelTotal";
      this.labelTotal.Size = new System.Drawing.Size(27, 32);
      this.labelTotal.TabIndex = 1;
      this.labelTotal.Text = "0";
      // 
      // Sales
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.labelTotal);
      this.Controls.Add(this.salesTable);
      this.Name = "Sales";
      this.Text = "Sales";
      this.Load += new System.EventHandler(this.Sales_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel salesTable;
    private System.Windows.Forms.Label labelTotal;
  }
}