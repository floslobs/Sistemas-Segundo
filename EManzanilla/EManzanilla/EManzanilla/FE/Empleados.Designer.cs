namespace EManzanilla.FE
{
    partial class Empleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewEmple = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            numericUpDownPHora = new NumericUpDown();
            numericUpDownTelefono = new NumericUpDown();
            numericUpDownDni = new NumericUpDown();
            txtPHora = new Label();
            comboBoxNomyApe = new ComboBox();
            txtTelefono = new Label();
            txtDni = new Label();
            txtNomnreyApellido = new Label();
            groupBox1 = new GroupBox();
            dateTimePickerFechaIngreso = new DateTimePicker();
            labelFecha = new Label();
            checkBoxActivo = new CheckBox();
            btnCargarHoras = new Button();
            label1 = new Label();
            btnResumen = new Button();
            btnHistorialInactivos = new Button();
            label2 = new Label();
            txtBuscar = new TextBox();
            btnPago = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmple).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPHora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTelefono).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDni).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEmple
            // 
            dataGridViewEmple.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmple.Location = new Point(12, 54);
            dataGridViewEmple.Name = "dataGridViewEmple";
            dataGridViewEmple.Size = new Size(547, 323);
            dataGridViewEmple.TabIndex = 0;
            dataGridViewEmple.SelectionChanged += dataGridViewEmple_SelectionChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderColor = Color.Yellow;
            btnAgregar.FlatAppearance.BorderSize = 2;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAgregar.Location = new Point(949, 54);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(88, 39);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderColor = Color.Yellow;
            btnEditar.FlatAppearance.BorderSize = 2;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnEditar.Location = new Point(949, 101);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(88, 34);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderColor = Color.Yellow;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnEliminar.Location = new Point(949, 144);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 36);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // numericUpDownPHora
            // 
            numericUpDownPHora.Location = new Point(174, 200);
            numericUpDownPHora.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericUpDownPHora.Name = "numericUpDownPHora";
            numericUpDownPHora.Size = new Size(151, 29);
            numericUpDownPHora.TabIndex = 21;
            numericUpDownPHora.ValueChanged += numericUpDownPHora_ValueChanged;
            // 
            // numericUpDownTelefono
            // 
            numericUpDownTelefono.Location = new Point(174, 165);
            numericUpDownTelefono.Maximum = new decimal(new int[] { -1530494977, 232830, 0, 0 });
            numericUpDownTelefono.Name = "numericUpDownTelefono";
            numericUpDownTelefono.Size = new Size(151, 29);
            numericUpDownTelefono.TabIndex = 20;
            numericUpDownTelefono.ValueChanged += numericUpDownTelefono_ValueChanged;
            // 
            // numericUpDownDni
            // 
            numericUpDownDni.Location = new Point(174, 130);
            numericUpDownDni.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownDni.Name = "numericUpDownDni";
            numericUpDownDni.Size = new Size(151, 29);
            numericUpDownDni.TabIndex = 19;
            numericUpDownDni.ValueChanged += numericUpDownDni_ValueChanged;
            // 
            // txtPHora
            // 
            txtPHora.AutoSize = true;
            txtPHora.Location = new Point(17, 200);
            txtPHora.Name = "txtPHora";
            txtPHora.Size = new Size(95, 21);
            txtPHora.TabIndex = 17;
            txtPHora.Text = "Precio Hora";
            // 
            // comboBoxNomyApe
            // 
            comboBoxNomyApe.FormattingEnabled = true;
            comboBoxNomyApe.Location = new Point(174, 95);
            comboBoxNomyApe.Name = "comboBoxNomyApe";
            comboBoxNomyApe.Size = new Size(152, 29);
            comboBoxNomyApe.TabIndex = 16;
            comboBoxNomyApe.TextChanged += comboBoxNomyApe_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.AutoSize = true;
            txtTelefono.Location = new Point(17, 167);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(72, 21);
            txtTelefono.TabIndex = 15;
            txtTelefono.Text = "Telefono";
            // 
            // txtDni
            // 
            txtDni.AutoSize = true;
            txtDni.Location = new Point(17, 130);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(36, 21);
            txtDni.TabIndex = 14;
            txtDni.Text = "Dni";
            // 
            // txtNomnreyApellido
            // 
            txtNomnreyApellido.AutoSize = true;
            txtNomnreyApellido.Location = new Point(17, 95);
            txtNomnreyApellido.Name = "txtNomnreyApellido";
            txtNomnreyApellido.Size = new Size(145, 21);
            txtNomnreyApellido.TabIndex = 13;
            txtNomnreyApellido.Text = "Nombre y Apellido";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePickerFechaIngreso);
            groupBox1.Controls.Add(labelFecha);
            groupBox1.Controls.Add(checkBoxActivo);
            groupBox1.Controls.Add(numericUpDownPHora);
            groupBox1.Controls.Add(numericUpDownTelefono);
            groupBox1.Controls.Add(numericUpDownDni);
            groupBox1.Controls.Add(txtPHora);
            groupBox1.Controls.Add(comboBoxNomyApe);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(txtNomnreyApellido);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(565, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 288);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // dateTimePickerFechaIngreso
            // 
            dateTimePickerFechaIngreso.Format = DateTimePickerFormat.Short;
            dateTimePickerFechaIngreso.Location = new Point(42, 53);
            dateTimePickerFechaIngreso.Name = "dateTimePickerFechaIngreso";
            dateTimePickerFechaIngreso.Size = new Size(120, 29);
            dateTimePickerFechaIngreso.TabIndex = 24;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Location = new Point(75, 29);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(51, 21);
            labelFecha.TabIndex = 23;
            labelFecha.Text = "Fecha";
            // 
            // checkBoxActivo
            // 
            checkBoxActivo.AutoSize = true;
            checkBoxActivo.Location = new Point(234, 53);
            checkBoxActivo.Name = "checkBoxActivo";
            checkBoxActivo.Size = new Size(75, 25);
            checkBoxActivo.TabIndex = 22;
            checkBoxActivo.Text = "Activo";
            checkBoxActivo.UseVisualStyleBackColor = true;
            checkBoxActivo.CheckedChanged += checkBoxActivo_CheckedChanged;
            // 
            // btnCargarHoras
            // 
            btnCargarHoras.FlatAppearance.BorderColor = Color.Yellow;
            btnCargarHoras.FlatAppearance.BorderSize = 2;
            btnCargarHoras.FlatStyle = FlatStyle.Flat;
            btnCargarHoras.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCargarHoras.Location = new Point(949, 200);
            btnCargarHoras.Name = "btnCargarHoras";
            btnCargarHoras.Size = new Size(88, 62);
            btnCargarHoras.TabIndex = 6;
            btnCargarHoras.Text = "Cargar Horas";
            btnCargarHoras.UseVisualStyleBackColor = true;
            btnCargarHoras.Click += btnCargarHoras_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 29);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 23;
            label1.Text = "Empleados";
            // 
            // btnResumen
            // 
            btnResumen.FlatAppearance.BorderColor = Color.Yellow;
            btnResumen.FlatAppearance.BorderSize = 2;
            btnResumen.FlatStyle = FlatStyle.Flat;
            btnResumen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnResumen.Location = new Point(949, 304);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(88, 38);
            btnResumen.TabIndex = 40;
            btnResumen.Text = "Resumen";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click;
            // 
            // btnHistorialInactivos
            // 
            btnHistorialInactivos.FlatAppearance.BorderColor = Color.Yellow;
            btnHistorialInactivos.FlatAppearance.BorderSize = 2;
            btnHistorialInactivos.FlatStyle = FlatStyle.Flat;
            btnHistorialInactivos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistorialInactivos.Location = new Point(283, 383);
            btnHistorialInactivos.Name = "btnHistorialInactivos";
            btnHistorialInactivos.Size = new Size(201, 41);
            btnHistorialInactivos.TabIndex = 41;
            btnHistorialInactivos.Text = "Hostorial Inactivos";
            btnHistorialInactivos.UseVisualStyleBackColor = true;
            btnHistorialInactivos.Click += btnHistorialInactivos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(406, 29);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 42;
            label2.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(454, 26);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 23);
            txtBuscar.TabIndex = 43;
            txtBuscar.TextChanged += textBuscar_TextChanged;
            // 
            // btnPago
            // 
            btnPago.FlatAppearance.BorderColor = Color.Yellow;
            btnPago.FlatAppearance.BorderSize = 2;
            btnPago.FlatStyle = FlatStyle.Flat;
            btnPago.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnPago.Location = new Point(799, 377);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(88, 47);
            btnPago.TabIndex = 44;
            btnPago.Text = "Pago";
            btnPago.UseVisualStyleBackColor = true;
            btnPago.Click += btnPago_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Manzanilla;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1082, 436);
            Controls.Add(btnPago);
            Controls.Add(txtBuscar);
            Controls.Add(label2);
            Controls.Add(btnHistorialInactivos);
            Controls.Add(btnResumen);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(btnCargarHoras);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridViewEmple);
            Name = "Empleados";
            Text = "Empleados";
            Load += Empleados_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmple).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPHora).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTelefono).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDni).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewEmple;
        private Button btnAgregar;
        private Label empleados;
        private Button btnEditar;
        private Button btnEliminar;
        private NumericUpDown numericUpDownPHora;
        private NumericUpDown numericUpDownTelefono;
        private NumericUpDown numericUpDownDni;
        private Label txtPHora;
        private ComboBox comboBoxNomyApe;
        private Label txtTelefono;
        private Label txtDni;
        private Label txtNomnreyApellido;
        private GroupBox groupBox1;
        private Button btnCargarHoras;
        private Label label1;
        private CheckBox checkBoxActivo;
        private DateTimePicker dateTimePickerFechaIngreso;
        private Label labelFecha;
        private Button btnResumen;
        private Button btnHistorialInactivos;
        private Label label2;
        private TextBox txtBuscar;
        private Button btnPago;
        private ErrorProvider errorProvider1;
    }
}