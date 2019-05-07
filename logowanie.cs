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
    public partial class logowanie : Form
    {
        public static List<User> uzytkownicy;
        bool zalogowany;

        public logowanie()
        {
            InitializeComponent();

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < uzytkownicy.Count; i++)
            {
                if (textBox7.Text == uzytkownicy[i].login && textBox8.Text == uzytkownicy[i].haslo)
                {
                    label1.Text = i.ToString();
                    zalogowany = true;
                }
            }

            string textToShow2 = getContentFromTextBox();
            this.Hide();
            Form1 frm1 = new Form1(textToShow2, zalogowany);
            frm1.ShowDialog();
            this.Show();
        }

        private string getContentFromTextBox()
        {
            return label1.Text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            zalogowany = false;
            string textToShow2 = null;
            this.Hide();
            Form1 frm1 = new Form1(textToShow2, zalogowany);
            
            frm1.ShowDialog();
            this.Show();
        }
    }
}
