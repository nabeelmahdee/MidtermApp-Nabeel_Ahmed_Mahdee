namespace MidtermApp_Nabeel_Ahmed_Mahdee
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AddToCart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Purchase = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.TextBox();
            this.CartItemN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Product Name :";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(170, 60);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 108);
            this.label2.TabIndex = 3;
            // 
            // AddToCart
            // 
            this.AddToCart.Location = new System.Drawing.Point(15, 209);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(95, 23);
            this.AddToCart.TabIndex = 4;
            this.AddToCart.Text = "Add To Cart";
            this.AddToCart.UseVisualStyleBackColor = true;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Welcome To The Store App";
            // 
            // Purchase
            // 
            this.Purchase.Location = new System.Drawing.Point(119, 209);
            this.Purchase.Name = "Purchase";
            this.Purchase.Size = new System.Drawing.Size(126, 23);
            this.Purchase.TabIndex = 6;
            this.Purchase.Text = "Go To Checkout";
            this.Purchase.UseVisualStyleBackColor = true;
            this.Purchase.Click += new System.EventHandler(this.Purchase_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(25, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "QTY :";
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(60, 238);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(29, 20);
            this.qty.TabIndex = 8;
            // 
            // CartItemN
            // 
            this.CartItemN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CartItemN.Location = new System.Drawing.Point(148, 241);
            this.CartItemN.Name = "CartItemN";
            this.CartItemN.Size = new System.Drawing.Size(70, 20);
            this.CartItemN.TabIndex = 9;
            this.CartItemN.Text = "Cart: 0 Items";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 275);
            this.Controls.Add(this.CartItemN);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Purchase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddToCart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Store App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddToCart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Purchase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.Label CartItemN;
    }
}

