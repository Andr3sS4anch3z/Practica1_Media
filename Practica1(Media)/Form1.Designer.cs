namespace Practica1_Media_
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHuesped = new Label();
            txtHuesped = new TextBox();
            lblNoches = new Label();
            nudNoches = new NumericUpDown();
            lblTarifa = new Label();
            txtTarifa = new TextBox();
            ckTemporada = new CheckBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            gbCotizador = new GroupBox();
            chkFinSemana = new CheckBox();
            nudHuespedes = new NumericUpDown();
            lblHuespedes = new Label();
            nudTasa = new NumericUpDown();
            lblTasa = new Label();
            btnImperativo = new Button();
            lstResultados = new ListBox();
            btnNivel1 = new Button();
            btnPesos = new Button();
            btnPorPersona = new Button();
            btnDeposito = new Button();
            btnFinSemana = new Button();
            btnFactura = new Button();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            gbCotizador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudHuespedes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTasa).BeginInit();
            SuspendLayout();
            // 
            // lblHuesped
            // 
            lblHuesped.AutoSize = true;
            lblHuesped.Location = new Point(23, 33);
            lblHuesped.Name = "lblHuesped";
            lblHuesped.Size = new Size(71, 20);
            lblHuesped.TabIndex = 0;
            lblHuesped.Text = "Huesped:";
            lblHuesped.Click += label1_Click;
            // 
            // txtHuesped
            // 
            txtHuesped.Location = new Point(179, 26);
            txtHuesped.Name = "txtHuesped";
            txtHuesped.PlaceholderText = "Ponga el nombre";
            txtHuesped.Size = new Size(262, 27);
            txtHuesped.TabIndex = 1;
            // 
            // lblNoches
            // 
            lblNoches.AutoSize = true;
            lblNoches.Location = new Point(23, 69);
            lblNoches.Name = "lblNoches";
            lblNoches.Size = new Size(65, 20);
            lblNoches.TabIndex = 2;
            lblNoches.Text = "Noches: ";
            // 
            // nudNoches
            // 
            nudNoches.Location = new Point(179, 67);
            nudNoches.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(262, 27);
            nudNoches.TabIndex = 3;
            nudNoches.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(23, 150);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(159, 20);
            lblTarifa.TabIndex = 4;
            lblTarifa.Text = "Tarifa por noche (USD)";
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(179, 147);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(174, 27);
            txtTarifa.TabIndex = 5;
            txtTarifa.TextChanged += textBox1_TextChanged;
            // 
            // ckTemporada
            // 
            ckTemporada.AutoSize = true;
            ckTemporada.Location = new Point(23, 182);
            ckTemporada.Name = "ckTemporada";
            ckTemporada.Size = new Size(190, 24);
            ckTemporada.TabIndex = 6;
            ckTemporada.Text = "Temporada Alta (+25%)";
            ckTemporada.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 342);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(112, 342);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // gbCotizador
            // 
            gbCotizador.Controls.Add(chkFinSemana);
            gbCotizador.Controls.Add(nudHuespedes);
            gbCotizador.Controls.Add(lblHuespedes);
            gbCotizador.Controls.Add(nudTasa);
            gbCotizador.Controls.Add(lblHuesped);
            gbCotizador.Controls.Add(txtHuesped);
            gbCotizador.Controls.Add(lblNoches);
            gbCotizador.Controls.Add(ckTemporada);
            gbCotizador.Controls.Add(nudNoches);
            gbCotizador.Controls.Add(txtTarifa);
            gbCotizador.Controls.Add(lblTarifa);
            gbCotizador.Location = new Point(12, 12);
            gbCotizador.Name = "gbCotizador";
            gbCotizador.Size = new Size(450, 324);
            gbCotizador.TabIndex = 9;
            gbCotizador.TabStop = false;
            gbCotizador.Text = "Cotizador";
            // 
            // chkFinSemana
            // 
            chkFinSemana.AutoSize = true;
            chkFinSemana.Location = new Point(219, 182);
            chkFinSemana.Name = "chkFinSemana";
            chkFinSemana.Size = new Size(178, 24);
            chkFinSemana.TabIndex = 10;
            chkFinSemana.Text = "Fin de semana (+15%)";
            chkFinSemana.UseVisualStyleBackColor = true;
            // 
            // nudHuespedes
            // 
            nudHuespedes.Location = new Point(179, 100);
            nudHuespedes.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudHuespedes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudHuespedes.Name = "nudHuespedes";
            nudHuespedes.Size = new Size(262, 27);
            nudHuespedes.TabIndex = 9;
            nudHuespedes.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblHuespedes
            // 
            lblHuespedes.AutoSize = true;
            lblHuespedes.Location = new Point(23, 100);
            lblHuespedes.Name = "lblHuespedes";
            lblHuespedes.Size = new Size(144, 20);
            lblHuespedes.TabIndex = 8;
            lblHuespedes.Text = "Total de huespedes: ";
            // 
            // nudTasa
            // 
            nudTasa.AutoSize = true;
            nudTasa.DecimalPlaces = 2;
            nudTasa.Location = new Point(179, 212);
            nudTasa.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTasa.Name = "nudTasa";
            nudTasa.Size = new Size(150, 27);
            nudTasa.TabIndex = 7;
            nudTasa.Click += label7_Click;
            // 
            // lblTasa
            // 
            lblTasa.Location = new Point(0, 0);
            lblTasa.Name = "lblTasa";
            lblTasa.Size = new Size(100, 23);
            lblTasa.TabIndex = 0;
            // 
            // btnImperativo
            // 
            btnImperativo.Location = new Point(212, 342);
            btnImperativo.Name = "btnImperativo";
            btnImperativo.Size = new Size(94, 29);
            btnImperativo.TabIndex = 11;
            btnImperativo.Text = "Imperativo";
            btnImperativo.UseVisualStyleBackColor = true;
            btnImperativo.Click += btnImperativo_Click;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(510, 23);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(367, 444);
            lstResultados.TabIndex = 12;
            lstResultados.SelectedIndexChanged += lstResultados_SelectedIndexChanged;
            // 
            // btnNivel1
            // 
            btnNivel1.Location = new Point(312, 342);
            btnNivel1.Name = "btnNivel1";
            btnNivel1.Size = new Size(94, 29);
            btnNivel1.TabIndex = 13;
            btnNivel1.Text = "Nivel 1";
            btnNivel1.UseVisualStyleBackColor = true;
            btnNivel1.Click += btnNivel1_Click;
            // 
            // btnPesos
            // 
            btnPesos.Location = new Point(12, 377);
            btnPesos.Name = "btnPesos";
            btnPesos.Size = new Size(194, 29);
            btnPesos.TabIndex = 14;
            btnPesos.Text = "Total en RD$";
            btnPesos.UseVisualStyleBackColor = true;
            btnPesos.Click += btnPesos_Click;
            // 
            // btnPorPersona
            // 
            btnPorPersona.Location = new Point(212, 377);
            btnPorPersona.Name = "btnPorPersona";
            btnPorPersona.Size = new Size(194, 29);
            btnPorPersona.TabIndex = 15;
            btnPorPersona.Text = "Por Persona";
            btnPorPersona.UseVisualStyleBackColor = true;
            btnPorPersona.Click += btnPorPersona_Click;
            // 
            // btnDeposito
            // 
            btnDeposito.Location = new Point(14, 412);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(192, 29);
            btnDeposito.TabIndex = 16;
            btnDeposito.Text = "Deposito";
            btnDeposito.UseVisualStyleBackColor = true;
            btnDeposito.Click += btnDeposito_Click;
            // 
            // btnFinSemana
            // 
            btnFinSemana.Location = new Point(212, 412);
            btnFinSemana.Name = "btnFinSemana";
            btnFinSemana.Size = new Size(192, 29);
            btnFinSemana.TabIndex = 17;
            btnFinSemana.Text = "Fin de semana";
            btnFinSemana.UseVisualStyleBackColor = true;
            btnFinSemana.Click += btnFinSemana_Click;
            // 
            // btnFactura
            // 
            btnFactura.Location = new Point(14, 447);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(192, 29);
            btnFactura.TabIndex = 18;
            btnFactura.Text = "Desglose";
            btnFactura.UseVisualStyleBackColor = true;
            btnFactura.Click += btnFactura_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 561);
            Controls.Add(btnFactura);
            Controls.Add(btnFinSemana);
            Controls.Add(btnDeposito);
            Controls.Add(btnPorPersona);
            Controls.Add(btnPesos);
            Controls.Add(btnNivel1);
            Controls.Add(lstResultados);
            Controls.Add(btnImperativo);
            Controls.Add(btnCalcular);
            Controls.Add(gbCotizador);
            Controls.Add(btnLimpiar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInicio";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cotizador Villa Coral Andrés Sánchez 2025-0561";
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            gbCotizador.ResumeLayout(false);
            gbCotizador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudHuespedes).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTasa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblHuesped;
        private TextBox txtHuesped;
        private Label lblNoches;
        private NumericUpDown nudNoches;
        private Label lblTarifa;
        private TextBox txtTarifa;
        private CheckBox ckTemporada;
        private Button btnCalcular;
        private Button btnLimpiar;
        private GroupBox gbCotizador;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnImperativo;
        private ListBox lstResultados;
        private Button btnNivel1;
        private NumericUpDown nudTasa;
        private Label lblTasa;
        private Button btnPesos;
        private Label lblHuespedes;
        private NumericUpDown nudHuespedes;
        private Button btnPorPersona;
        private Button btnDeposito;
        private CheckBox chkFinSemana;
        private Button btnFinSemana;
        private Button btnFactura;
    }
}
