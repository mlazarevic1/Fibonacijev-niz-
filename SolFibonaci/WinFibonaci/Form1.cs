using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFibonaci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIzlistaj_Click(object sender, EventArgs e)
        {
            Fibonaciiii.clsMath fib = new Fibonaciiii.clsMath();

           long[] rezultat = fib.GenFibonacci(Convert.ToInt32(txtUnos.Text));
            
            foreach(long a in rezultat)
            {

                lstListaFib.Items.Add(a);

            }


        }
    }
}
