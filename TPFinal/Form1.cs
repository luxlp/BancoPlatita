using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace TPFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void number_Click(object sender, EventArgs e)
        {
            ArgumentOutOfRangeException iExcepcion=new ArgumentOutOfRangeException();
            Button iButton=sender as Button;
            try
            {
                if (CajaTexto.Text.Length < 8)
                {
                    CajaTexto.Text += iButton.Text;
                }
                else throw iExcepcion;
                
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Excedió el numero maximo de numeros de un DNI");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            CajaTexto.Clear();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            string s = CajaTexto.Text;

            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
                CajaTexto.Text = s;
            }
            else
            {
                CajaTexto.Text = "";
            }
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); 
            f2.Show(); 
            Hide(); 
        }
    }
}
