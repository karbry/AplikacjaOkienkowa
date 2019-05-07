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
    public partial class Form2 : Form
    {

        public static List<User> uzytkownicy;
        public Form2(string textToShow, string textToShow2, string textToShow3)
        {
            InitializeComponent();

            label13.Text = textToShow;
            label9.Text = textToShow2;
            label10.Text = textToShow3;

            uzytkownicy = new List<User>
            {
                new User
                {
                    imie = "Jan", nazwisko = "Nowak", login = "Jan", haslo = "123",
                    ulica = "Szybka", miasto = "Wrocław", nrdomu = 45, nrlokalu = 2
                },

                new User
                {
                    imie = "Paulina", nazwisko = "Krynicka", login = "Paula", haslo = "456",
                    ulica = "Rolnicza", miasto = "Wrocław", nrdomu = 2, nrlokalu = 33
                },

                new User
                {
                    imie = "Krzysztof", nazwisko = "Liguda", login = "Krzysiek", haslo = "789",
                    ulica = "Prądzyńskiego", miasto = "Wrocław", nrdomu = 4, nrlokalu = 7
                }

            };

           if (label10.Text == "True")
            { 
            int x = Convert.ToInt32(textToShow2);
            textBox1.Text = uzytkownicy[x].imie;
            textBox2.Text = uzytkownicy[x].nazwisko;
            textBox3.Text = uzytkownicy[x].ulica;
            textBox4.Text = uzytkownicy[x].nrdomu.ToString();
            textBox5.Text = uzytkownicy[x].nrlokalu.ToString();
            textBox6.Text = uzytkownicy[x].miasto;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Wybierz metodę płatności!");
                return;
            }else MessageBox.Show("Dziękujemy za zamówienie.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
        
      

