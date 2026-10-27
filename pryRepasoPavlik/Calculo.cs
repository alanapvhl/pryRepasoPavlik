using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryRepasoPavlik
{
    public partial class Calculo : Form
    {
        public Calculo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(txtMonto.Text);
            double iva = 0;

            if (cbxIva.Text == "10%")
            {
                iva = 0.10;
            }
            else if (cbxIva.Text == "21%")
            {
                iva = 0.21;
            }

            double total = monto + (monto * iva);

            MessageBox.Show("Total: $" + total);
        }
    }
}
