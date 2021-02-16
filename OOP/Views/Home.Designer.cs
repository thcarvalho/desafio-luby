﻿namespace OOP
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(170, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(461, 45);
      this.label1.TabIndex = 1;
      this.label1.Text = "Bem vindo a Vending Machine!";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(232, 80);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(300, 25);
      this.label2.TabIndex = 2;
      this.label2.Text = "Escolha uma ação para prosseguir";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.button1.Location = new System.Drawing.Point(297, 166);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(163, 49);
      this.button1.TabIndex = 3;
      this.button1.Text = "Conferir Estoque";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.checkStock);
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.button2.Location = new System.Drawing.Point(297, 235);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(163, 49);
      this.button2.TabIndex = 3;
      this.button2.Text = "Conferir Vendas";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.checkSales);
      // 
      // button3
      // 
      this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.button3.Location = new System.Drawing.Point(297, 305);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(163, 49);
      this.button3.TabIndex = 3;
      this.button3.Text = "Fazer uma Compra";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.goToShop);
      // 
      // Home
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "Home";
      this.Text = "Vending Machine";
      this.Load += new System.EventHandler(this.Home_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
  }
}

