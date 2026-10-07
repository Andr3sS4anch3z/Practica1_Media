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
    }
}
