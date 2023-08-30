namespace partidasContables
{
    public partial class formularioPartida : Form
    {
        public formularioPartida()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void formularioPartida_Load(object sender, EventArgs e)
        {

        }

        private void lblAnioOperacion_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String fecha = fechaPartida.Text;
            String cuenta = txtNumeroCuenta.Text;
            String cantidad = txtMonto.Text;
            String tipoCuenta = cmbTipoCuenta.Text;
            String descripcion = txtDescripcion.Text;

            if (fecha == "" || cuenta == "" || cantidad == "" || tipoCuenta == "" || descripcion == "")
            {
                if (fecha == "")
                {
                    MessageBox.Show("Ingresa la fecha de la factura");
                    fechaPartida.Focus();
                }
                if (cuenta == "")
                {
                    MessageBox.Show("Ingresa el n�mero de cuenta");
                    txtNumeroCuenta.Focus();
                }
                if (cantidad == "")
                {
                    MessageBox.Show("Ingresa el monto de la operaci�n");
                    txtMonto.Focus();
                }
                if (tipoCuenta == "")
                {
                    MessageBox.Show("Ingresa el tipo de operaci�n");
                    cmbTipoCuenta.Focus();
                }
                else if (tipoCuenta == "DEBE" || tipoCuenta == "HABER")
                {

                }
                else
                {
                    MessageBox.Show("Selecciona un tipo de operaci�n correcta");
                    cmbTipoCuenta.Focus();
                }
                if (descripcion == "")
                {
                    MessageBox.Show(" Debes Ingresar la descripci�n");
                    txtDescripcion.Focus();
                }
            }
            else
            {
                MessageBox.Show(fecha + cuenta + cantidad + tipoCuenta + descripcion);
            }


        }
    }
}