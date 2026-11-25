namespace EmpleadosOrigin.FE
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
            PrecioHora = new NumericUpDown();
            Legajo = new NumericUpDown();
            dataGridEmple = new DataGridView();
            btEliminar = new Button();
            btModificar = new Button();
            btGuardar = new Button();
            FechaNac = new DateTimePicker();
            NomBre = new TextBox();
            fechN = new Label();
            PrecioH = new Label();
            nom = new Label();
            num = new Label();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)PrecioHora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Legajo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridEmple).BeginInit();
            SuspendLayout();
            // 
            // PrecioHora
            // 
            PrecioHora.Location = new Point(156, 87);
            PrecioHora.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            PrecioHora.Name = "PrecioHora";
            PrecioHora.Size = new Size(100, 25);
            PrecioHora.TabIndex = 28;
            // 
            // Legajo
            // 
            Legajo.Location = new Point(156, 20);
            Legajo.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            Legajo.Name = "Legajo";
            Legajo.Size = new Size(100, 25);
            Legajo.TabIndex = 27;
            // 
            // dataGridEmple
            // 
            dataGridEmple.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmple.Location = new Point(48, 207);
            dataGridEmple.Name = "dataGridEmple";
            dataGridEmple.Size = new Size(570, 235);
            dataGridEmple.TabIndex = 26;
            dataGridEmple.CellClick += dataGridEmple_CellClick;
            // 
            // btEliminar
            // 
            btEliminar.BackColor = Color.DarkKhaki;
            btEliminar.Location = new Point(506, 116);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(118, 33);
            btEliminar.TabIndex = 25;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = false;
            btEliminar.Click += btEliminar_Click;
            // 
            // btModificar
            // 
            btModificar.BackColor = Color.DarkKhaki;
            btModificar.Location = new Point(506, 63);
            btModificar.Name = "btModificar";
            btModificar.Size = new Size(118, 33);
            btModificar.TabIndex = 24;
            btModificar.Text = "Modificar";
            btModificar.UseVisualStyleBackColor = false;
            btModificar.Click += btModificar_Click;
            // 
            // btGuardar
            // 
            btGuardar.BackColor = Color.DarkKhaki;
            btGuardar.Location = new Point(506, 12);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(118, 33);
            btGuardar.TabIndex = 23;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = false;
            btGuardar.Click += btGuardar_Click;
            // 
            // FechaNac
            // 
            FechaNac.Format = DateTimePickerFormat.Custom;
            FechaNac.Location = new Point(156, 124);
            FechaNac.Name = "FechaNac";
            FechaNac.Size = new Size(100, 25);
            FechaNac.TabIndex = 22;
            // 
            // NomBre
            // 
            NomBre.Location = new Point(156, 55);
            NomBre.Name = "NomBre";
            NomBre.Size = new Size(100, 25);
            NomBre.TabIndex = 21;
            // 
            // fechN
            // 
            fechN.AutoSize = true;
            fechN.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            fechN.Location = new Point(44, 132);
            fechN.Name = "fechN";
            fechN.Size = new Size(80, 17);
            fechN.TabIndex = 20;
            fechN.Text = "FECHA NAC";
            // 
            // PrecioH
            // 
            PrecioH.AutoSize = true;
            PrecioH.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            PrecioH.Location = new Point(44, 95);
            PrecioH.Name = "PrecioH";
            PrecioH.Size = new Size(94, 17);
            PrecioH.TabIndex = 19;
            PrecioH.Text = "PRECIO HORA";
            // 
            // nom
            // 
            nom.AutoSize = true;
            nom.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            nom.Location = new Point(44, 63);
            nom.Name = "nom";
            nom.Size = new Size(62, 17);
            nom.TabIndex = 18;
            nom.Text = "NOMBRE";
            // 
            // num
            // 
            num.AutoSize = true;
            num.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            num.Location = new Point(44, 28);
            num.Name = "num";
            num.Size = new Size(74, 17);
            num.TabIndex = 17;
            num.Text = "Nº LEGAJO";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DarkKhaki;
            btnActualizar.Location = new Point(431, 464);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(118, 33);
            btnActualizar.TabIndex = 29;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(639, 526);
            Controls.Add(btnActualizar);
            Controls.Add(PrecioHora);
            Controls.Add(Legajo);
            Controls.Add(dataGridEmple);
            Controls.Add(btEliminar);
            Controls.Add(btModificar);
            Controls.Add(btGuardar);
            Controls.Add(FechaNac);
            Controls.Add(NomBre);
            Controls.Add(fechN);
            Controls.Add(PrecioH);
            Controls.Add(nom);
            Controls.Add(num);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            ForeColor = SystemColors.ControlText;
            Name = "Empleados";
            Text = "Empleados";
            Load += Empleados_Load_1;
            ((System.ComponentModel.ISupportInitialize)PrecioHora).EndInit();
            ((System.ComponentModel.ISupportInitialize)Legajo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridEmple).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown PrecioHora;
        private NumericUpDown Legajo;
        private DataGridView dataGridEmple;
        private Button btEliminar;
        private Button btModificar;
        private Button btGuardar;
        private DateTimePicker FechaNac;
        private TextBox NomBre;
        private Label fechN;
        private Label PrecioH;
        private Label nom;
        private Label num;
        private Button btnActualizar;
    }
}