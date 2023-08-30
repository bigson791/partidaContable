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
            label5 = new Label();
            btnGuardar = new Button();
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
            lblMesOperacion.Location = new Point(216, 22);
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
            label2.Location = new Point(47, 112);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 5;
            label2.Text = "Cuenta";
            // 
            // txtNumeroCuenta
            // 
            txtNumeroCuenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumeroCuenta.Location = new Point(154, 109);
            txtNumeroCuenta.Name = "txtNumeroCuenta";
            txtNumeroCuenta.Size = new Size(433, 29);
            txtNumeroCuenta.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(47, 157);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 7;
            label3.Text = "Monto";
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonto.Location = new Point(154, 157);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(433, 29);
            txtMonto.TabIndex = 8;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.Location = new Point(47, 203);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(93, 21);
            lblTipo.TabIndex = 9;
            lblTipo.Text = "Tipo Cuenta";
            // 
            // cmbTipoCuenta
            // 
            cmbTipoCuenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoCuenta.FormattingEnabled = true;
            cmbTipoCuenta.Location = new Point(157, 201);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(47, 250);
            label5.Name = "label5";
            label5.Size = new Size(93, 21);
            label5.TabIndex = 12;
            label5.Text = "Tipo Cuenta";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.MenuHighlight;
            btnGuardar.FlatAppearance.BorderColor = Color.MintCream;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Location = new Point(450, 283);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(137, 33);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "GuardarPartida";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // formularioPartida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 356);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
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
        private Label label5;
        private Button btnGuardar;
    }
}