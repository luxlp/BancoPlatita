using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CajaPIN.UseSystemPasswordChar = true;
        }

        private void number_Click(object sender, EventArgs e)
        {
            ArgumentOutOfRangeException iExcepcion = new ArgumentOutOfRangeException();
            Button iButton = sender as Button;
            try
            {
                if (CajaPIN.Text.Length < 4)
                {
                    CajaPIN.Text += iButton.Text;
                }
                else
                {
                    throw iExcepcion;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Excedió el numero maximo de numeros de un PIN");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            CajaPIN.Clear();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            string s = CajaPIN.Text;

            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
                CajaPIN.Text = s;
            }
            else
            {
                CajaPIN.Text = "";
            }
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Hide();
        }
    }
}
