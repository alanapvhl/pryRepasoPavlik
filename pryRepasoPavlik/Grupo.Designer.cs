namespace pryRepasoPavlik
{
    partial class Grupo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblGrupo = new Label();
            cboGrupo = new ComboBox();
            lstResultado = new ListBox();
            btnAgregar = new Button();
            lblGrupo2 = new Label();
            lblDato = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            btnGrabar = new Button();
            SuspendLayout();
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(31, 26);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(43, 15);
            lblGrupo.TabIndex = 0;
            lblGrupo.Text = "Grupo:";
            // 
            // cboGrupo
            // 
            cboGrupo.FormattingEnabled = true;
            cboGrupo.Location = new Point(89, 23);
            cboGrupo.Name = "cboGrupo";
            cboGrupo.Size = new Size(121, 23);
            cboGrupo.TabIndex = 1;
            cboGrupo.SelectedIndexChanged += cboGrupo_SelectedIndexChanged;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.Location = new Point(31, 69);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(179, 79);
            lstResultado.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(31, 175);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(179, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblGrupo2
            // 
            lblGrupo2.AutoSize = true;
            lblGrupo2.Location = new Point(31, 229);
            lblGrupo2.Name = "lblGrupo2";
            lblGrupo2.Size = new Size(43, 15);
            lblGrupo2.TabIndex = 4;
            lblGrupo2.Text = "Grupo:";
            // 
            // lblDato
            // 
            lblDato.AutoSize = true;
            lblDato.Location = new Point(31, 269);
            lblDato.Name = "lblDato";
            lblDato.Size = new Size(35, 15);
            lblDato.TabIndex = 5;
            lblDato.Text = "Dato:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(89, 226);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
           // comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(89, 266);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 7;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(135, 309);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 8;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            // 
            // Grupo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 355);
            Controls.Add(btnGrabar);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(lblDato);
            Controls.Add(lblGrupo2);
            Controls.Add(btnAgregar);
            Controls.Add(lstResultado);
            Controls.Add(cboGrupo);
            Controls.Add(lblGrupo);
            Name = "Grupo";
            Text = "Grupo";
            Load += Grupo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGrupo;
        private ComboBox cboGrupo;
        private ListBox lstResultado;
        private Button btnAgregar;
        private Label lblGrupo2;
        private Label lblDato;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button btnGrabar;
    }
}