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
            gbTotales = new GroupBox();
            lblTotal = new Label();
            lblServicio = new Label();
            lblITBS = new Label();
            lblDescuento = new Label();
            lblSubTotal = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnImperativo = new Button();
            lstResultados = new ListBox();
            btnNivel1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            gbCotizador.SuspendLayout();
            gbTotales.SuspendLayout();
            SuspendLayout();
            // 
            // lblHuesped
            // 
            lblHuesped.AutoSize = true;
            lblHuesped.Location = new Point(23, 23);
            lblHuesped.Name = "lblHuesped";
            lblHuesped.Size = new Size(71, 20);
            lblHuesped.TabIndex = 0;
            lblHuesped.Text = "Huesped:";
            lblHuesped.Click += label1_Click;
            // 
            // txtHuesped
            // 
            txtHuesped.Location = new Point(188, 20);
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
            nudNoches.Location = new Point(188, 64);
            nudNoches.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(262, 27);
            nudNoches.TabIndex = 3;
            nudNoches.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(23, 108);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(159, 20);
            lblTarifa.TabIndex = 4;
            lblTarifa.Text = "Tarifa por noche (USD)";
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(188, 108);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(174, 27);
            txtTarifa.TabIndex = 5;
            txtTarifa.TextChanged += textBox1_TextChanged;
            // 
            // ckTemporada
            // 
            ckTemporada.AutoSize = true;
            ckTemporada.Location = new Point(23, 152);
            ckTemporada.Name = "ckTemporada";
            ckTemporada.Size = new Size(190, 24);
            ckTemporada.TabIndex = 6;
            ckTemporada.Text = "Temporada Alta (+25%)";
            ckTemporada.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(27, 481);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(131, 481);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // gbCotizador
            // 
            gbCotizador.Controls.Add(lblHuesped);
            gbCotizador.Controls.Add(txtHuesped);
            gbCotizador.Controls.Add(lblNoches);
            gbCotizador.Controls.Add(ckTemporada);
            gbCotizador.Controls.Add(nudNoches);
            gbCotizador.Controls.Add(txtTarifa);
            gbCotizador.Controls.Add(lblTarifa);
            gbCotizador.Location = new Point(12, 12);
            gbCotizador.Name = "gbCotizador";
            gbCotizador.Size = new Size(450, 179);
            gbCotizador.TabIndex = 9;
            gbCotizador.TabStop = false;
            gbCotizador.Text = "Cotizador";
            // 
            // gbTotales
            // 
            gbTotales.Controls.Add(lblTotal);
            gbTotales.Controls.Add(lblServicio);
            gbTotales.Controls.Add(lblITBS);
            gbTotales.Controls.Add(lblDescuento);
            gbTotales.Controls.Add(lblSubTotal);
            gbTotales.Controls.Add(label6);
            gbTotales.Controls.Add(label5);
            gbTotales.Controls.Add(label4);
            gbTotales.Controls.Add(label3);
            gbTotales.Controls.Add(label2);
            gbTotales.Controls.Add(label1);
            gbTotales.Location = new Point(12, 197);
            gbTotales.Name = "gbTotales";
            gbTotales.Size = new Size(450, 265);
            gbTotales.TabIndex = 10;
            gbTotales.TabStop = false;
            gbTotales.Text = "Totales";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(179, 157);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(17, 20);
            lblTotal.TabIndex = 18;
            lblTotal.Text = "0";
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(179, 121);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(17, 20);
            lblServicio.TabIndex = 17;
            lblServicio.Text = "0";
            // 
            // lblITBS
            // 
            lblITBS.AutoSize = true;
            lblITBS.Location = new Point(179, 87);
            lblITBS.Name = "lblITBS";
            lblITBS.Size = new Size(17, 20);
            lblITBS.TabIndex = 16;
            lblITBS.Text = "0";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(179, 57);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(17, 20);
            lblDescuento.TabIndex = 15;
            lblDescuento.Text = "0";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(179, 30);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(17, 20);
            lblSubTotal.TabIndex = 14;
            lblSubTotal.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 157);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 13;
            label6.Text = "Total RD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 121);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 12;
            label5.Text = "Servicio 10%";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 87);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 11;
            label4.Text = "ITBS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 57);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 10;
            label3.Text = "Descuentos";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 30);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 9;
            label2.Text = "SubTotal";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 73);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 8;
            // 
            // btnImperativo
            // 
            btnImperativo.Location = new Point(231, 481);
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
            btnNivel1.Location = new Point(331, 481);
            btnNivel1.Name = "btnNivel1";
            btnNivel1.Size = new Size(94, 29);
            btnNivel1.TabIndex = 13;
            btnNivel1.Text = "Nivel 1";
            btnNivel1.UseVisualStyleBackColor = true;
            btnNivel1.Click += btnNivel1_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 553);
            Controls.Add(btnNivel1);
            Controls.Add(lstResultados);
            Controls.Add(btnImperativo);
            Controls.Add(gbTotales);
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
            gbTotales.ResumeLayout(false);
            gbTotales.PerformLayout();
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
        private GroupBox gbTotales;
        private Label label1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label lblSubTotal;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblTotal;
        private Label lblServicio;
        private Label lblITBS;
        private Label lblDescuento;
        private Button btnImperativo;
        private ListBox lstResultados;
        private Button btnNivel1;
    }
}
