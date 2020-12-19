using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hp
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sonuc.Text = "0";
        }

        private void button_Click(object sender, EventArgs e)
        {

            if ((sonuc.Text == "0") || (operation_pressed))
                sonuc.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            
            if (b.Text == ",")
            {
                if (!sonuc.Text.Contains(","))
                    sonuc.Text = sonuc.Text + b.Text;

            }
            else
                sonuc.Text = sonuc.Text + b.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void islem_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(sonuc.Text);
            operation_pressed = true;
            eski.Text = value + " " + operation;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            eski.Text = "";
            switch(operation)
            {
                case "+":
                    sonuc.Text = (value + double.Parse(sonuc.Text)).ToString();
                    break;
                case "-":
                    sonuc.Text = (value - double.Parse(sonuc.Text)).ToString();
                    break;
                case "X":
                    sonuc.Text = (value * double.Parse(sonuc.Text)).ToString();
                    break;
                case "/":
                    sonuc.Text = (value / double.Parse(sonuc.Text)).ToString();
                    break;
             }
        }
    }
}
