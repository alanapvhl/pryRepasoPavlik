using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryRepasoPavlik
{

    public partial class Grupo : Form
    {
        //DECLARACION DE VCARIABLES GLOBALES

        string[] vectorGrupoA = new string[4];
        string[] vectorGrupoB = new string[3];
        string[] vectorGrupoC = new string[3];


        public Grupo()
        {
            InitializeComponent();
        }

        private void cboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboGrupo.Text)
            {
                case "Grupo A":
                    lstResultado.Items.Clear();
                    lstResultado.Items.Add("CPU");
                    lstResultado.Items.Add("Micro");
                    lstResultado.Items.Add("Placa");
                    lstResultado.Items.Add("Memoria");
                    break;


                case "Grupo B":
                    lstResultado.Items.Clear();
                    lstResultado.Items.Add("Visual");
                    lstResultado.Items.Add("C#");
                    lstResultado.Items.Add("Desktop");
                    break;
                case "Grupo C":
                    lstResultado.Items.Clear();
                    lstResultado.Items.Add("Server");
                    lstResultado.Items.Add("AWS");
                    lstResultado.Items.Add("Cloud");
                    break;

            }
        }


        private void Grupo_Load(object sender, EventArgs e)
        {
            cboGrupo.Items.Add("Grupo A");
            cboGrupo.Items.Add("Grupo B");
            cboGrupo.Items.Add("Grupo C");

            cboGrupo.DropDownStyle = ComboBoxStyle.DropDownList;

            vectorGrupoA[0] = "CPU";
            vectorGrupoA[1] = "Micro";
            vectorGrupoA[2] = "Placa";
            vectorGrupoA[3] = "Memoria";

            vectorGrupoB[0] = "Visual";
            vectorGrupoB[1] = "C#";
            vectorGrupoB[2] = "Desktop";

            vectorGrupoC[0] = "Server";
            vectorGrupoC[1] = "AWS";
            vectorGrupoC[2] = "Cloud";

        }

    }
}
