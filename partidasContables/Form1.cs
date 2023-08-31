namespace partidasContables
{
    public partial class formularioPartida : Form
    {
        struct Mes
        {
            public int Numero { get; set; }
            public string Nombre { get; set; }
        }

        private Mes[] meses = new Mes[]
        {
            new Mes { Numero = 1, Nombre = "Enero" },
            new Mes { Numero = 2, Nombre = "Febrero" },
            new Mes { Numero = 3, Nombre = "Marzo" },
            new Mes { Numero = 4, Nombre = "Abril" },
            new Mes { Numero = 5, Nombre = "Mayo" },
            new Mes { Numero = 6, Nombre = "Junio" },
            new Mes { Numero = 7, Nombre = "Julio" },
            new Mes { Numero = 8, Nombre = "Agosto" },
            new Mes { Numero = 9, Nombre = "Septiembre" },
            new Mes { Numero = 10, Nombre = "Octubre" },
            new Mes { Numero = 11, Nombre = "Noviembre" },
            new Mes { Numero = 12, Nombre = "Diciembre" }
        };
        public formularioPartida()
        {
            InitializeComponent();
            if (lblEstadoOp.Text == "CERRADO")
            {

                fechaPartida.Enabled = false;
                txtNumeroCuenta.Enabled = false;
                txtMonto.Enabled = false;
                cmbTipoCuenta.Enabled = false;
                txtDescripcion.Enabled = false;
                btnGuardar.Enabled = false;
            }
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

            String fecha = fechaPartida.Value.ToString("dd/MM/yyyy");
            String cuenta = txtNumeroCuenta.Text;
            String cantidad = txtMonto.Text;
            String tipoCuenta = cmbTipoCuenta.Text;
            String descripcion = txtDescripcion.Text;



            if (fecha == "" || cuenta == "" || cantidad =="" || tipoCuenta == "" || descripcion == "")
            {
                if (fecha == "")
                {
                    MessageBox.Show("Ingresa la fecha de la factura");
                    fechaPartida.Focus();
                }
                if (cuenta == "")
                {
                    MessageBox.Show("Ingresa el número de cuenta");
                    txtNumeroCuenta.Focus();
                }
                if (cantidad == "")
                {
                    MessageBox.Show("Ingresa el monto de la operación");
                    txtMonto.Focus();
                }
                if (tipoCuenta == "")
                {
                    MessageBox.Show("Ingresa el tipo de operación");
                    cmbTipoCuenta.Focus();
                }
                else if (tipoCuenta == "DEBE" || tipoCuenta == "HABER")
                {

                }
                else
                {
                    MessageBox.Show("Selecciona un tipo de operación correcta");
                    cmbTipoCuenta.Focus();
                }
                if (descripcion == "")
                {
                    MessageBox.Show(" Debes Ingresar la descripción");
                    txtDescripcion.Focus();
                }
            }
            else
            {
                if (validaEstadoMes())
                {
                    MessageBox.Show("El mes esta activo");
                    MessageBox.Show(fecha + cuenta + cantidad + tipoCuenta + descripcion);
                    int anio = ExtraerAniodeFecha(fecha);
                    int mes = ExtraerMesdeFecha(fecha);

                    String mesDigitado = ObtenerNombreMes(mes).ToUpper();

                    if (mesDigitado == lblMesOp.Text)
                    {
                        MessageBox.Show("Estas dentro del mes");

                    }
                    else {
                        MessageBox.Show("Estas tratando de ingresar información en un mes diferente"+
                            ", el mes del periodo es: "+lblMesOp.Text);
                    }

                    MessageBox.Show("El mes que estas digitando es: "+mesDigitado);

                }
                else
                {
                    MessageBox.Show("El mes esta cerrado, comuniquese al departamento de informatica");

                    fechaPartida.Enabled = false;
                    txtNumeroCuenta.Enabled = false;
                    txtMonto.Enabled = false;
                    cmbTipoCuenta.Enabled = false;
                    txtDescripcion.Enabled = false;

                }

            }


        }

        private void txtNumeroCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(Convert.ToInt16(e.KeyChar).ToString());

            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtMonto.Text.Length; i++)
            {
                if (txtMonto.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;

        }

        private void generarPoliza()
        {
        }

        private void validarMes(String fecha)
        {
            

        }

        bool validaEstadoMes()
        {
            String estadoMes = lblEstadoOp.Text.ToUpper();
            bool estado;
            if (estadoMes == "ABIERTO")
            {
                estado = true;
            }
            else
            {
                estado = false;
            }
            return estado;
        }
        private int ExtraerMesdeFecha(string date)
        {
            DateTime parsedDate;
            if (DateTime.TryParseExact(date, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                return parsedDate.Month;
            }
            else
            {
                throw new ArgumentException("Fecha no válida en el formato dd/mm/yyyy", nameof(date));
            }
        }

        private int ExtraerAniodeFecha(string date)
        {
            DateTime parsedDate;
            if (DateTime.TryParseExact(date, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                return parsedDate.Year;
            }
            else
            {
                throw new ArgumentException("Fecha no válida en el formato dd/mm/yyyy", nameof(date));
            }
        }

        private string ObtenerNombreMes(int monthNumber)
        {
            foreach (Mes mes in meses)
            {
                if (mes.Numero == monthNumber)
                {
                    return mes.Nombre;
                }
            }
            return "Mes no encontrado";
        }

    }
}