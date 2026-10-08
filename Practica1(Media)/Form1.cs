namespace Practica1_Media_
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void gbTotales_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lstResultados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnImperativo_Click(object sender, EventArgs e)
        {
            string huesped = txtHuesped.Text;
            int noches = (int)nudNoches.Value;
            decimal tarifa = Convert.ToDecimal(txtTarifa.Text);
            bool temporadaAlta = ckTemporada.Checked;
            bool FinDeSemana = chkFinSemana.Checked;

            decimal subtotal = noches * tarifa;
            decimal descuento = 0m;
            if (noches >= 7)
            {
                descuento = subtotal * 0.10m;
            }

            decimal baseImponible = subtotal - descuento;
            decimal itbis = baseImponible * 0.18m;
            decimal servicio = baseImponible * 0.10m;
            decimal total = (baseImponible + itbis + servicio);

            if (temporadaAlta)
            {
                total += total * 0.25m;
            }

            if (FinDeSemana)
            {
                total += total * 0.15m;
            }

            lstResultados.Items.Add($"[imperativo] {huesped}: US$ {total:N2}");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();
            txtHuesped.Clear();
            nudNoches.Value = 1;
            txtTarifa.Clear();
        }

        private void btnNivel1_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 3;
            int r = a / b; //la respuesta es 3//

            decimal R = 10 / 4m; //la respuesta es 2.5//

            int x = 5;
            x = x + 2;
            x = x * 3; //la respuesta es 21//

            decimal p = 200m;
            decimal o = p * 0.18m; //la respuesta es 36//

            int n = 7;
            decimal d = 0m;
            if (n > 7)
            {
                d = 50m; // la respuesta es 0//
            }

            int N = 7;
            bool larga = N >= 7; //la respuesta es true//

            string s = "Villa" + "Coral"; //la respuesta es VillaCoral//

            int I = 4;
            decimal t = 100m;
            decimal total = I * t * 1.28m; //la respuesta es 512//

            decimal T = 120m;
            T = T + T * 0.25m; //la respuesta es 150//

            int noches = (int)8.9m; //la respuesta es 8//
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnPesos_Click(object sender, EventArgs e)
        {
            int noches = (int)nudNoches.Value;
            decimal tarifa = Convert.ToDecimal(txtTarifa.Text);
            int CantidadHuespedes = (int)nudHuespedes.Value;
            bool temporadaAlta = ckTemporada.Checked;
            bool FinDeSemana = chkFinSemana.Checked;

            decimal subtotal = noches * tarifa;
            decimal baseImponible = subtotal;
            decimal itbis = baseImponible * 0.18m;
            decimal servicio = baseImponible * 0.10m;
            decimal total = (baseImponible + itbis + servicio);

            if (temporadaAlta)
            {
                total += total * 0.25m;
            }

            if (FinDeSemana)
            {
                total += total * 0.15m;
            }


            decimal tasa = Convert.ToDecimal(nudTasa.Value);
            decimal pesos = tasa * total;
            lstResultados.Items.Add($"Total en pesos: RD$ {pesos:N2}");
        }

        private void btnPorPersona_Click(object sender, EventArgs e)
        {
            string huesped = txtHuesped.Text;
            int noches = (int)nudNoches.Value;
            decimal tarifa = Convert.ToDecimal(txtTarifa.Text);
            int CantidadHuespedes = (int)nudHuespedes.Value;
            bool temporadaAlta = ckTemporada.Checked;
            bool FinDeSemana = chkFinSemana.Checked;

            decimal subtotal = noches * tarifa;
            decimal descuento = 0m;
            if (noches >= 7)
            {
                descuento = subtotal * 0.10m;
            }

            decimal baseImponible = subtotal - descuento;
            decimal itbis = baseImponible * 0.18m;
            decimal servicio = baseImponible * 0.10m;
            decimal total = (baseImponible + itbis + servicio); // la respuesta es 512//

            if (temporadaAlta)
            {
                total += total * 0.25m;
            }

            if (FinDeSemana)
            {
                total += total * 0.15m;
            }

            decimal totalPorPersona = total / CantidadHuespedes;

            lstResultados.Items.Add($"[En total:] {huesped}: US$ {total:N2} [Por persona] US$ {totalPorPersona:N2} ");
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            int noches = (int)nudNoches.Value;
            decimal tarifa = Convert.ToDecimal(txtTarifa.Text);
            int CantidadHuespedes = (int)nudHuespedes.Value;
            bool temporadaAlta = ckTemporada.Checked;
            bool FinDeSemana = chkFinSemana.Checked;

            decimal subtotal = noches * tarifa;
            decimal baseImponible = subtotal;
            decimal itbis = baseImponible * 0.18m;
            decimal servicio = baseImponible * 0.10m;
            decimal total = (baseImponible + itbis + servicio);

            if (temporadaAlta)
            {
                total += total * 0.25m;
            }

            if (FinDeSemana)
            {
                total += total * 0.15m;
            }


            decimal tasa = Convert.ToDecimal(nudTasa.Value);
            decimal pesos = tasa * total;

            decimal deposito = pesos * 0.30m;
            decimal saldoPendiente = pesos - deposito;

            lstResultados.Items.Add($"Deposito inicial: RD$ {deposito:N2}");
            lstResultados.Items.Add($"Pendiente: RD$ {saldoPendiente:N2}");
        }

        private void btnFinSemana_Click(object sender, EventArgs e)
        {
            string huesped = txtHuesped.Text;
            int noches = (int)nudNoches.Value;
            decimal tarifa = Convert.ToDecimal(txtTarifa.Text);
            bool temporadaAlta = ckTemporada.Checked;
            bool FinDeSemana = chkFinSemana.Checked;

            decimal subtotal = noches * tarifa;
            decimal descuento = 0m;
            if (noches >= 7)
            {
                descuento = subtotal * 0.10m;
            }

            decimal baseImponible = subtotal - descuento;
            decimal itbis = baseImponible * 0.18m;
            decimal servicio = baseImponible * 0.10m;
            decimal total = (baseImponible + itbis + servicio);

            if (temporadaAlta)
            {
                total += total * 0.25m;
            }

            if (FinDeSemana)
            {
                total = total * 0.15m;
            }

            lstResultados.Items.Add($"[Fin de semana (15%)] {huesped}: US$ {total:N2}");
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            string huesped = txtHuesped.Text;
            int noches = (int)nudNoches.Value;
            decimal tarifa = Convert.ToDecimal(txtTarifa.Text);
            bool temporadaAlta = ckTemporada.Checked;
            bool FinDeSemana = chkFinSemana.Checked;

            decimal subtotal = noches * tarifa;
            decimal descuento = 0m;
            if (noches >= 7)
            {
                descuento = subtotal * 0.10m;
            }

            decimal baseImponible = subtotal - descuento;
            decimal itbis = baseImponible * 0.18m;
            decimal servicio = baseImponible * 0.10m;
            decimal total = (baseImponible + itbis + servicio);

            if (temporadaAlta)
            {
                total += total * 0.25m;
            }

            if (FinDeSemana)
            {
                total += total * 0.15m;
            }

            lstResultados.Items.Add($"[Subtotal] {huesped}: US$ {subtotal:N2}");
            lstResultados.Items.Add($"[Descuento] {huesped}: US$ {descuento:N2}");
            lstResultados.Items.Add($"[Base imponible] {huesped}: US$ {baseImponible:N2}");
            lstResultados.Items.Add($"[ITBS] {huesped}: US$ {itbis:N2}");
            lstResultados.Items.Add($"[Servicio] {huesped}: US$ {servicio:N2}");
            lstResultados.Items.Add($"[Total] {huesped}: US$ {total:N2}");
        }
    }
}
