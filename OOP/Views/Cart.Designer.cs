
namespace OOP.Views
{
  partial class Cart
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
      this.cartTable = new System.Windows.Forms.TableLayoutPanel();
      this.cartLabel = new System.Windows.Forms.Label();
      this.payTextBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnPay = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // cartTable
      // 
      this.cartTable.AutoSize = true;
      this.cartTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
      this.cartTable.ColumnCount = 3;
      this.cartTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.cartTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.cartTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
      this.cartTable.Location = new System.Drawing.Point(13, 12);
      this.cartTable.Name = "cartTable";
      this.cartTable.RowCount = 1;
      this.cartTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.cartTable.Size = new System.Drawing.Size(775, 40);
      this.cartTable.TabIndex = 0;
      // 
      // cartLabel
      // 
      this.cartLabel.AutoSize = true;
      this.cartLabel.Location = new System.Drawing.Point(730, 426);
      this.cartLabel.Name = "cartLabel";
      this.cartLabel.Size = new System.Drawing.Size(13, 15);
      this.cartLabel.TabIndex = 1;
      this.cartLabel.Text = "0";
      // 
      // payTextBox
      // 
      this.payTextBox.Location = new System.Drawing.Point(177, 423);
      this.payTextBox.Name = "payTextBox";
      this.payTextBox.Size = new System.Drawing.Size(148, 23);
      this.payTextBox.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 426);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(158, 15);
      this.label1.TabIndex = 3;
      this.label1.Text = "Insira o valor do pagamento:";
      // 
      // btnPay
      // 
      this.btnPay.Location = new System.Drawing.Point(341, 423);
      this.btnPay.Name = "btnPay";
      this.btnPay.Size = new System.Drawing.Size(75, 23);
      this.btnPay.TabIndex = 4;
      this.btnPay.Text = "Pagar";
      this.btnPay.UseVisualStyleBackColor = true;
      this.btnPay.Click += new System.EventHandler(this.payAccount);
      // 
      // Cart
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnPay);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.payTextBox);
      this.Controls.Add(this.cartLabel);
      this.Controls.Add(this.cartTable);
      this.Name = "Cart";
      this.Text = "Cart";
      this.Load += new System.EventHandler(this.Cart_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel cartTable;
    private System.Windows.Forms.Label cartLabel;
    private System.Windows.Forms.TextBox payTextBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnPay;
  }
}