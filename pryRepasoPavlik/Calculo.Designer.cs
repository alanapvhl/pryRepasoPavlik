namespace pryRepasoPavlik
{
    partial class Calculo
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
            lblMonto = new Label();
            lblIva = new Label();
            txtMonto = new TextBox();
            cbxIva = new ComboBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(32, 62);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(46, 15);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Monto:";
            // 
            // lblIva
            // 
            lblIva.AutoSize = true;
            lblIva.Location = new Point(32, 120);
            lblIva.Name = "lblIva";
            lblIva.Size = new Size(27, 15);
            lblIva.TabIndex = 1;
            lblIva.Text = "IVA:";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(94, 59);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(117, 23);
            txtMonto.TabIndex = 2;
            // 
            // cbxIva
            // 
            cbxIva.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxIva.FormattingEnabled = true;
            cbxIva.Items.AddRange(new object[] { "10%", "21%" });
            cbxIva.Location = new Point(94, 112);
            cbxIva.Name = "cbxIva";
            cbxIva.Size = new Size(117, 23);
            cbxIva.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(192, 177);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Calculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 240);
            Controls.Add(btnCalcular);
            Controls.Add(cbxIva);
            Controls.Add(txtMonto);
            Controls.Add(lblIva);
            Controls.Add(lblMonto);
            Name = "Calculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMonto;
        private Label lblIva;
        private TextBox txtMonto;
        private ComboBox cbxIva;
        private Button btnCalcular;
    }
}