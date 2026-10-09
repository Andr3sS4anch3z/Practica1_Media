using Practica1Media;

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


            decimal deposito = total * 0.30m;
            decimal saldoPendiente = total - deposito;

            lstResultados.Items.Add($"Deposito inicial:  {deposito:N2}");
            lstResultados.Items.Add($"Pendiente:  {saldoPendiente:N2}");
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
                total = total * 1.15m;

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

        private void btnViajes_Click(object sender, EventArgs e)
        {
            Viaje v = new Viaje();
            string huesped = txtHuesped.Text;
            bool Nocturno = chkTrasladoNocturno.Checked;
            int CantidadHuespedes = (int)nudHuespedes.Value;
            v.Pasajeros = CantidadHuespedes;

            if (Nocturno)
            {
                v.Nocturno = true;

            }

            if (v.Nocturno == true)
            {

                decimal TrasladoNocturno = 1.20m * (v.subtotal);
                lstResultados.Items.Add($"[Noturno] {huesped}: US$ {TrasladoNocturno:N2}");
            }

            else
            {
                decimal traslado = (v.subtotal);
                lstResultados.Items.Add($"[Normal] {huesped}: US$ {traslado:N2}");
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excursion ex = new Excursion();

            string huesped = txtHuesped.Text;
            int CantidadHuespedes = (int)nudHuespedes.Value;

            ex.Personas = CantidadHuespedes;
            ex.PrecioPorPersona = 50m;

            if (ex.Personas >= 4)
            {
                decimal subtotal = (ex.subtotal);
                decimal descuento = (ex.descuento);
                decimal total = subtotal - descuento;
                lstResultados.Items.Add($"[Aplica descuento] {huesped}: US$ {total:N2}");

            }

            else
            {
                decimal subtotal = (ex.subtotal);
                lstResultados.Items.Add($"[normal] {huesped}: US$ {subtotal:N2}");
            }

        }

        private void btnUsoMinibar_Click(object sender, EventArgs e)
        {
            Minibar m = new Minibar();
            string huesped = txtHuesped.Text;
            m.Cantidad = (int)numConsumo.Value;
            m.precioUnitario = 3.50m;

            decimal CantidadDeConsumo = (m.Cantidad);
            decimal PrecioUnitario = (m.precioUnitario);
            decimal subtotal = (m.subtotal);
            decimal ITBS = (m.ITBS);
            decimal total = (m.total);

            lstResultados.Items.Add($"[Consumo] {huesped}: US$ {total:N2}");
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            Viaje v = new Viaje();
            Excursion ex = new Excursion();
            Minibar m = new Minibar();

            string huesped = txtHuesped.Text;
            int noches = (int)nudNoches.Value;
            decimal tarifa = Convert.ToDecimal(txtTarifa.Text);
            int CantidadHuespedes = (int)nudHuespedes.Value;
            v.Pasajeros = CantidadHuespedes;

            //Reserva

            decimal subtotal = noches * tarifa;
            decimal descuento = 0m;

            if (noches >= 7)
            {
                descuento = subtotal * 0.10m;
            }

            decimal baseImponible = subtotal - descuento;
            decimal itbis = baseImponible * 0.18m;
            decimal servicio = baseImponible * 0.10m;
            decimal totalReserva = (baseImponible + itbis + servicio);

            //Viajes

            bool Nocturno = chkTrasladoNocturno.Checked;

            if (Nocturno)
            {
                v.Nocturno = true;
            }

            if (v.Nocturno == true)
            {
                decimal TrasladoNocturno = 1.20m * (v.subtotal);
            }

            else
            {
                decimal traslado = (v.subtotal);
            }

            //Excursion

            ex.Personas = CantidadHuespedes;
            ex.PrecioPorPersona = 50m;

            if (ex.Personas >= 4)
            {
                decimal subtotalEx = (ex.subtotal);
                decimal descuentoEx = (ex.descuento);
                decimal totalEx = subtotalEx - descuentoEx;

            }

            else
            {
                decimal subtotalEx = (ex.subtotal);
            }

            //Minibar

            m.Cantidad = (int)numConsumo.Value;
            m.precioUnitario = 3.50m;

            decimal CantidadDeConsumo = (m.Cantidad);
            decimal PrecioUnitario = (m.precioUnitario);
            decimal subtotalbar = (m.subtotal);
            decimal ITBS = (m.ITBS);
            decimal totalbar = (m.total);

            decimal FacturaTotal = totalReserva + v.subtotal + ex.subtotal + totalbar;

            lstResultados.Items.Add($"[Consumo] {huesped}: US$ {FacturaTotal:N2}");
        }
    }
}
