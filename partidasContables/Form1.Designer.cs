namespace partidasContables
{
    partial class formularioPartida
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
            label1 = new Label();
            lblOperacion = new Label();
            fechaPartida = new DateTimePicker();
            lblMesOperacion = new Label();
            lblAnioOperacion = new Label();
            label2 = new Label();
            txtNumeroCuenta = new TextBox();
            label3 = new Label();
            txtMonto = new TextBox();
            lblTipo = new Label();
            cmbTipoCuenta = new ComboBox();
            label4 = new Label();
            btnGuardar = new Button();
            lblMesOp = new Label();
            label6 = new Label();
            lblEstadoOp = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 75);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 0;
            label1.Text = "Fecha Partida";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperacion.Location = new Point(47, 22);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(163, 21);
            lblOperacion.TabIndex = 1;
            lblOperacion.Text = "Datos de la Operación";
            lblOperacion.Click += label2_Click;
            // 
            // fechaPartida
            // 
            fechaPartida.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fechaPartida.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fechaPartida.Format = DateTimePickerFormat.Short;
            fechaPartida.Location = new Point(155, 74);
            fechaPartida.Name = "fechaPartida";
            fechaPartida.RightToLeft = RightToLeft.No;
            fechaPartida.Size = new Size(432, 29);
            fechaPartida.TabIndex = 2;
            // 
            // lblMesOperacion
            // 
            lblMesOperacion.AutoSize = true;
            lblMesOperacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMesOperacion.Location = new Point(217, 22);
            lblMesOperacion.Name = "lblMesOperacion";
            lblMesOperacion.Size = new Size(42, 21);
            lblMesOperacion.TabIndex = 3;
            lblMesOperacion.Text = "Mes:";
            lblMesOperacion.Click += label3_Click;
            // 
            // lblAnioOperacion
            // 
            lblAnioOperacion.AutoSize = true;
            lblAnioOperacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnioOperacion.Location = new Point(336, 23);
            lblAnioOperacion.Name = "lblAnioOperacion";
            lblAnioOperacion.Size = new Size(41, 21);
            lblAnioOperacion.TabIndex = 4;
            lblAnioOperacion.Text = "Año:";
            lblAnioOperacion.Click += lblAnioOperacion_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 125);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 5;
            label2.Text = "Cuenta";
            // 
            // txtNumeroCuenta
            // 
            txtNumeroCuenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumeroCuenta.Location = new Point(154, 122);
            txtNumeroCuenta.Name = "txtNumeroCuenta";
            txtNumeroCuenta.Size = new Size(433, 29);
            txtNumeroCuenta.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(50, 171);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 7;
            label3.Text = "Monto";
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonto.Location = new Point(154, 171);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(433, 29);
            txtMonto.TabIndex = 8;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.Location = new Point(47, 226);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(93, 21);
            lblTipo.TabIndex = 9;
            lblTipo.Text = "Tipo Cuenta";
            // 
            // cmbTipoCuenta
            // 
            cmbTipoCuenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoCuenta.FormattingEnabled = true;
            cmbTipoCuenta.Items.AddRange(new object[] { "DEBE", "HABER" });
            cmbTipoCuenta.Location = new Point(155, 223);
            cmbTipoCuenta.Name = "cmbTipoCuenta";
            cmbTipoCuenta.Size = new Size(430, 29);
            cmbTipoCuenta.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(444, 23);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 11;
            label4.Text = "Estado:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.MenuHighlight;
            btnGuardar.FlatAppearance.BorderColor = Color.MintCream;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Location = new Point(438, 372);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(147, 41);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "GuardarPartida";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblMesOp
            // 
            lblMesOp.AutoSize = true;
            lblMesOp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMesOp.ForeColor = Color.Teal;
            lblMesOp.Location = new Point(259, 23);
            lblMesOp.Name = "lblMesOp";
            lblMesOp.Size = new Size(73, 21);
            lblMesOp.TabIndex = 14;
            lblMesOp.Text = "AGOSTO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(380, 23);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 15;
            label6.Text = "2023";
            // 
            // lblEstadoOp
            // 
            lblEstadoOp.AutoSize = true;
            lblEstadoOp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoOp.ForeColor = Color.FromArgb(0, 192, 0);
            lblEstadoOp.Location = new Point(509, 23);
            lblEstadoOp.Name = "lblEstadoOp";
            lblEstadoOp.Size = new Size(75, 21);
            lblEstadoOp.TabIndex = 16;
            lblEstadoOp.Text = "ABIERTO";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(154, 274);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(433, 29);
            txtDescripcion.TabIndex = 18;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(50, 274);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(91, 21);
            lblDescripcion.TabIndex = 17;
            lblDescripcion.Text = "Descripción";
            // 
            // formularioPartida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 465);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lblEstadoOp);
            Controls.Add(label6);
            Controls.Add(lblMesOp);
            Controls.Add(btnGuardar);
            Controls.Add(label4);
            Controls.Add(cmbTipoCuenta);
            Controls.Add(lblTipo);
            Controls.Add(txtMonto);
            Controls.Add(label3);
            Controls.Add(txtNumeroCuenta);
            Controls.Add(label2);
            Controls.Add(lblAnioOperacion);
            Controls.Add(lblMesOperacion);
            Controls.Add(fechaPartida);
            Controls.Add(lblOperacion);
            Controls.Add(label1);
            Name = "formularioPartida";
            Text = "Partidas Contables";
            Load += formularioPartida_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblOperacion;
        private DateTimePicker fechaPartida;
        private Label lblMesOperacion;
        private Label lblAnioOperacion;
        private Label label2;
        private TextBox txtNumeroCuenta;
        private Label label3;
        private TextBox txtMonto;
        private Label lblTipo;
        private ComboBox cmbTipoCuenta;
        private Label label4;
        private Button btnGuardar;
        private Label lblMesOp;
        private Label label6;
        private Label lblEstadoOp;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
    }
}