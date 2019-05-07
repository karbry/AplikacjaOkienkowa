using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;


namespace JedzenieZdowozem
{
    public partial class Form1 : Form
    {
        private List<Restaurant> Restaurants;
        private BindingList<Item> Koszyk = new BindingList<Item>();
     


        public Form1(string textToShow2, bool zalogowany)
        {
            InitializeComponent();

            label12.Text = textToShow2;
            label13.Text = zalogowany.ToString();

            Restaurants = new List<Restaurant>
        {
                new Restaurant
                {
                    name = "Pizza Party",
                    typeOfkitchen = "Włoska",
                    costOfdelivery = 6.50,
                    averageTime = 60,
                    Itemy = new List<Item>
                     {
                    new Item
                    {
                        name = "Cztery sery",
                        description = "Camembert, lazur, parmezan, mozarella",
                        price = 20.99
                    },
                    new Item
                    {
                        name = "Pepperoni",
                        description = "Salami, mozarella",
                        price = 15.99
                    },
                    new Item
                    {
                        name = "Farmerska",
                        description = "Kurczak, cebula, papryka, mozarella",
                        price = 24.99
                    }
                    }
                },



                new Restaurant
                {
                    name = "Sushi",
                    typeOfkitchen = "Japońska",
                    costOfdelivery = 14.99,
                    averageTime = 80,
                    Itemy = new List<Item>
                    {
                    new Item
                    {
                        name = "Zestaw 1",
                        description = "30 sztuk (łosoś, tuńczyk, węgorz, krewetka)",
                        price = 90.49
                    },
                    new Item
                    {
                        name = "Zestaw 2",
                        description = "20 sztuk (krewetka, łosoś)",
                        price = 69.99
                    },
                    new Item
                    {
                        name = "Zupa ramen",
                        description = "Bulion wieprzowy, jajko, warzywa",
                        price = 35.99
                    }
                    }
                },

                new Restaurant
                {
                    name = "Ha long Bar",
                    typeOfkitchen = "Azjatycka",
                    costOfdelivery = 3.50,
                    averageTime = 40,
                    Itemy = new List<Item>
                    {
                    new Item
                    {
                        name = "Pad Thai Kurczak",
                        description = "Makaron Udon, warzywa, kurczak",
                        price = 19.49
                    },
                    new Item
                    {
                        name = "Krewetki królewskie słodko-kwaśne",
                        description = "Ryż, krewetki, mix warzyw",
                        price = 30.99
                    },
                    new Item
                    {
                        name = "Wołowina w sosie curry",
                        description = "Curry czerwone, wolowina, ryż, warzywa",
                        price = 25.99
                    }
                }
        } };

            listBox1.DataSource = Restaurants;
            listBox1.DisplayMember = "Display";
            listBox1.ValueMember = "Display";

            
            listBox3.DataSource = Koszyk;
            listBox3.DisplayMember = "Display";
            listBox3.ValueMember = "Display";
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)listBox2.SelectedItem;

            if (listBox2.SelectedIndex == -1)
                {
                MessageBox.Show("Wybierz restaurację!");

            }
            else

            Koszyk.Add(selectedItem);

            List<double> ceny = new List<double>();

            for (int i =0; i<Koszyk.Count;i++)
            {

                ceny.Add(Koszyk[i].price);
            }
            
            label6.Text = ceny.Sum().ToString();

            double dostawaicena = (Convert.ToDouble(label8.Text) + Convert.ToDouble(label6.Text));

            label10.Text = dostawaicena.ToString();


        }
        private string getContentFromTextBox()
        {
            return label10.Text;
        }
        private string getContentFromTextBox2()
        {
            return label12.Text;
        }
        private string getContentFromTextBox3()
        {
            return label13.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            string textToShow = getContentFromTextBox();
            string textToShow2 = getContentFromTextBox2();
            string textToShow3 = getContentFromTextBox3();
            this.Hide();
            Form2 frm2 = new Form2(textToShow, textToShow2, textToShow3);
            frm2.ShowDialog();
            this.Show();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Koszyk.RemoveAt(Koszyk.Count - 1);
            listBox3.DataSource = Koszyk;



            label6.Text = "";
            List<double> ceny = new List<double>();
            for (int i = 0; i < Koszyk.Count; i++)
            {

                ceny.Add(Koszyk[i].price);
            }

            label6.Text = ceny.Sum().ToString();
            double dostawaicena = (Convert.ToDouble(label8.Text) + Convert.ToDouble(label6.Text));

            label10.Text = dostawaicena.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Koszyk.Clear();

            label6.Text = "";
           
            label10.Text = "";

            var restaurantID = listBox1.SelectedIndex;

            listBox2.DataSource = Restaurants[restaurantID].Itemy;
            listBox2.DisplayMember = "Display";


            label8.Text = Restaurants[restaurantID].costOfdelivery.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}



 