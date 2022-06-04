using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            int mnozstviCisel = int.Parse(textBox1.Text);
            string puvodnitext = "";
            Random rnd = new Random();
            for (int i = 0; i < mnozstviCisel; i++)
            {
                int cislo = rnd.Next(2, 15);
                puvodnitext += cislo.ToString() + " ";
            }
            textBox2.Text = puvodnitext;
            AddToList(textBox2, listBox1);
        }

        bool JeFirstNumber(int cislo)
        {
            if (cislo == 2 || cislo == 3 || cislo == 5 || cislo == 7 || cislo == 11 || cislo == 13)
            {
                return true;
            }
            else { return false; }
        }

        void AddToList(TextBox textBox, ListBox listBox)
        {
            listBox.Items.Clear();
            string[] cisla = textBox.Text.Split(' ');
            for (int i = 0; i < cisla.Length; i++)
            {
                int cislo = Int32.Parse("0" + cisla[i]);
                if (JeFirstNumber(cislo))
                {
                    listBox.Items.Add(cisla[i]);
                }
            }

        }
    }
}
