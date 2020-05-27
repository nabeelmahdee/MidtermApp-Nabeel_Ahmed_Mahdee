using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermApp_Nabeel_Ahmed_Mahdee
{
    public partial class Form1 : Form
    {
        string searchstring = "";
        List<Product> ProductList = new List<Product>();
        List<Product> ProductInCart = new List<Product>();
        double cartPrice = 0.0;
        Product selectedProduct;
        int itemsoncart = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Product p1 = new Product()
            {
                Name = "CRY MY NAME",
                Description = "This is a very interesting book",
                Type = "Book",
                Price = 89.99,
                onSale = false
            };
            Product p2 = new Product()
            {
                Name = "BOSS HEADPHONES",
                Description = "These are awesome",
                Type = "Electronics",
                Price = 199.99,
                onSale = true
            };
            Product p3 = new Product()
            {
                Name = "JUMANJI",
                Description = "This is an interesting Movie",
                Type = "Media",
                Price = 39.99,
                onSale = false
            };
            Product p4 = new Product()
            {
                Name = "DARK SIDE OF THE MOON",
                Description = "This is the most awesome piece of music album",
                Type = "Music",
                Price = 99.99,
                onSale = false
            };
            Product p5 = new Product()
            {
                Name = "FENDER AMP",
                Description = "Gives the best sound",
                Type = "Electronics",
                Price = 254.31,
                onSale = true
            };

            ProductList.Add(p1);
            ProductList.Add(p2);
            ProductList.Add(p3);
            ProductList.Add(p4);
            ProductList.Add(p5);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            searchstring = textBox1.Text.ToUpper();
            if (searchstring == "")
            {
                label3.Text = "Enter Text in Search box to search";
            }
            foreach(Product p in ProductList)
            {
                if(searchstring == p.Name)
                {
                    label2.Text = p.toString();
                    selectedProduct = p;
                }
            }
        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (qty.Text == "")
                {
                    ProductInCart.Add(selectedProduct);
                    cartPrice += selectedProduct.Price;
                    itemsoncart += 1;
                    CartItemN.Text = $"Cart {itemsoncart} items";
                    MessageBox.Show("Item Added To Cart");
                }
                else
                {
                    int quantity = int.Parse(qty.Text);
                    for (int i = 0; i < quantity; i++)
                    {
                        ProductInCart.Add(selectedProduct);
                        cartPrice += selectedProduct.Price;
                    }
                    itemsoncart += quantity;
                    CartItemN.Text = $"Cart: {itemsoncart} items";
                    MessageBox.Show("Items Added To Cart");
                }
            }
            catch (System.NullReferenceException) {
                MessageBox.Show("Search Item First To Add To Cart");
            }
        }

        private void Purchase_Click(object sender, EventArgs e)
        {
            if (itemsoncart == 0)
            {
                MessageBox.Show("Search and Add Items on Cart to Checkout");
                label3.Text = "Nothing to Checkout";
            }
            else
            {
                label3.Text = $"Total Price: ${cartPrice.ToString()}";
            }
        }

        
    }

    class Product
    {
        public string Name { set; get; }
        public string Description { set; get; }
        public string Type { set; get; }
        public double Price { set; get; }
        public Boolean onSale { set; get; }

        public string isonsale(Boolean b)
        {
            if (b == true) { return "Yes"; }
            else return "No";
        }
        public string toString()
        {
            string s = $"Name: {this.Name}\n" +
                $"Description: {this.Description}\n" +
                $"Type: {this.Type}\n" +
                $"Price: ${this.Price}\n" +
                $"onSale:{isonsale(onSale)}";
            return s;
        }
    }
}
