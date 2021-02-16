
namespace OOP.Views
{
  partial class Stock
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
      this.stockTable = new System.Windows.Forms.TableLayoutPanel();
      this.SuspendLayout();
      // 
      // stockTable
      // 
      this.stockTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.stockTable.AutoSize = true;
      this.stockTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
      this.stockTable.ColumnCount = 3;
      this.stockTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.stockTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.stockTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
      this.stockTable.Location = new System.Drawing.Point(32, 75);
      this.stockTable.Name = "stockTable";
      this.stockTable.RowCount = 1;
      this.stockTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.stockTable.Size = new System.Drawing.Size(739, 35);
      this.stockTable.TabIndex = 0;
      // 
      // Stock
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.stockTable);
      this.Name = "Stock";
      this.Text = "Stock";
      this.Load += new System.EventHandler(this.Stock_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel stockTable;
  }
}