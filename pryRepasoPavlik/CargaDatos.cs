using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryRepasoPavlik
{
    public partial class CargaDatos : Form

    {
        int Dato;
        string Nombre;
        public CargaDatos()
        {
            InitializeComponent();
        }

        private void CargaDatos_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Dato = Convert.ToInt32(txtCodigo.Text);
            Nombre = txtNombre.Text;

            MessageBox.Show("Registraste: " + "\n" + Dato + "\n" +  Nombre);

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
