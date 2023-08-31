namespace partidasContables
{
    public partial class formularioPartida : Form
    {
        int correlativo = 0;
        struct CuentaContable
        {
            public int NumeroCuenta { get; set; }
            public string NombreCuenta { get; set; }
            public string EstadoCuenta { get; set; }
        }

        private CuentaContable[] ct = new CuentaContable[]
        {
            new CuentaContable { NumeroCuenta = 123456, NombreCuenta = "COMBUSTIBLES Y LUBRICANTES", EstadoCuenta = "ACTIVO"},
            new CuentaContable { NumeroCuenta = 654321, NombreCuenta = "PAPELERIA Y UTILES", EstadoCuenta = "ACTIVO"},
            new CuentaContable { NumeroCuenta = 111111, NombreCuenta = "ATENCION AL PERSONAL", EstadoCuenta = "INACTIVO"},
        };
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

        struct Partida
        {
            public int CorrPartida { get; set; }
            public int CorrMes { get; set; }
            public string FechaPartida { get; set; }
            public int NumeroCta { get; set; }
            public decimal CantidadCuenta { get; set; }
            public string TipoCuenta { get; set; }
            public string DescripcionPartida { get; set; }
        }

        private List<Partida> partidasList = new List<Partida>();
        public formularioPartida()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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

            int cuentaCT = int.Parse(txtNumeroCuenta.Text);
            decimal montoPartida = decimal.Parse(txtMonto.Text);



            if (fecha == "" || cuenta == "" || cantidad == "" || tipoCuenta == "" || descripcion == "")
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
                if (ObtenerEstadoCuenta(Int32.Parse(cuenta)) == "ACTIVO")
                {
                    if (validaEstadoMes())
                    {
                        MessageBox.Show("El mes esta activo");
                        MessageBox.Show(fecha + cuenta + cantidad + tipoCuenta + descripcion);
                        int anio = ExtraerAniodeFecha(fecha);
                        int mesPartida = ExtraerMesdeFecha(fecha);

                        String mesDigitado = ObtenerNombreMes(mesPartida).ToUpper();

                        if (mesDigitado == lblMesOp.Text && anio == Int32.Parse(lblAnioOp.Text))
                        {
                            correlativo++;
                            AgregarPartida(correlativo, mesPartida, fecha, cuentaCT, montoPartida, tipoCuenta, descripcion);
                            MessageBox.Show("estos es" + correlativo + mesPartida + fecha + cuentaCT + montoPartida + tipoCuenta + descripcion);
                            InitializeDataGridView();
                            FillDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Estas tratando de ingresar información en un mes diferente" +
                                ", el mes del periodo es: " + lblMesOp.Text);
                        }


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
                else
                {
                    MessageBox.Show("El número de cuenta: " + cuenta + ", esta inactivo");
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

        private string ObtenerEstadoCuenta(int accountNumber)
        {
            foreach (CuentaContable cuenta in ct)
            {
                if (cuenta.NumeroCuenta == accountNumber)
                {
                    return cuenta.EstadoCuenta;
                }
            }
            return "Cuenta no encontrada";
        }

        private void AgregarPartida(int corrPartida, int corrMes, string fechaPartida,
                                   int numeroCta, decimal cantidadCuenta, string tipoCuenta, string descripcionPartida)
        {
            Partida nuevaPartida = new Partida
            {
                CorrPartida = corrPartida,
                CorrMes = corrMes,
                FechaPartida = fechaPartida,
                NumeroCta = numeroCta,
                CantidadCuenta = cantidadCuenta,
                TipoCuenta = tipoCuenta,
                DescripcionPartida = descripcionPartida
            };

            partidasList.Add(nuevaPartida);
        }

        private void FillDataGridView()
        {
            dataGridViewPartidas.Rows.Clear();

            foreach (Partida partida in partidasList)
            {
                dataGridViewPartidas.Rows.Add(partida.CorrPartida, partida.CorrMes, partida.FechaPartida, partida.NumeroCta,
                    partida.CantidadCuenta, partida.TipoCuenta, partida.DescripcionPartida);
            }
        }

        private void InitializeDataGridView()
        {
            dataGridViewPartidas.ColumnCount = 7; // Cambia esto al número correcto de columnas

            dataGridViewPartidas.Columns[0].Name = "No.";
            dataGridViewPartidas.Columns[1].Name = "No.Mes";
            dataGridViewPartidas.Columns[2].Name = "Fecha";
            dataGridViewPartidas.Columns[3].Name = "No.Cuenta";
            dataGridViewPartidas.Columns[4].Name = "Monto";
            dataGridViewPartidas.Columns[5].Name = "Tipo";
            dataGridViewPartidas.Columns[6].Name = "Descripción";
        }


    }
}