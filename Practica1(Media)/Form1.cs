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

            decimal subtotal = noches * tarifa;
            decimal descuento = 0m;
            if (noches >= 7)
            {
                descuento = subtotal * 0.10m;
            }

            decimal baseImponible = subtotal - descuento;
            decimal itbis = baseImponible * 0.10m;
            decimal servicio = baseImponible * 0.10m;
            decimal total = baseImponible + itbis + servicio;

            lstResultados.Items.Add($"[imperativo] {huesped}: US$ {total:N2}");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();
            txtHuesped.Clear();
            nudNoches.Value = 1;
            txtTarifa.Clear();
        }
    }
}
