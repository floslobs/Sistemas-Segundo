
namespace Empleados.FE

{
    public partial class Empleados
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
            num = new Label();
            nom = new Label();
            PrecioH = new Label();
            fechN = new Label();
            NomBre = new TextBox();
            FechaNac = new DateTimePicker();
            btGuardar = new Button();
            btModificar = new Button();
            btEliminar = new Button();
            dataGridEmple = new DataGridView();
            NumeroL = new NumericUpDown();
            PrecioHora = new NumericUpDown();
            btnCargarHS = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridEmple).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumeroL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrecioHora).BeginInit();
            SuspendLayout();
            // 
            // num
            // 
            num.AutoSize = true;
            num.Location = new Point(26, 33);
            num.Name = "num";
            num.Size = new Size(51, 15);
            num.TabIndex = 0;
            num.Text = "Numero";
            // 
            // nom
            // 
            nom.AutoSize = true;
            nom.Location = new Point(26, 71);
            nom.Name = "nom";
            nom.Size = new Size(51, 15);
            nom.TabIndex = 1;
            nom.Text = "Nombre";
            // 
            // PrecioH
            // 
            PrecioH.AutoSize = true;
            PrecioH.Location = new Point(26, 111);
            PrecioH.Name = "PrecioH";
            PrecioH.Size = new Size(69, 15);
            PrecioH.TabIndex = 2;
            PrecioH.Text = "Precio Hora";
            // 
            // fechN
            // 
            fechN.AutoSize = true;
            fechN.Location = new Point(26, 151);
            fechN.Name = "fechN";
            fechN.Size = new Size(62, 15);
            fechN.TabIndex = 3;
            fechN.Text = "Fecha Nac";
            // 
            // NomBre
            // 
            NomBre.Location = new Point(123, 63);
            NomBre.Name = "NomBre";
            NomBre.Size = new Size(100, 23);
            NomBre.TabIndex = 7;
            // 
            // FechaNac
            // 
            FechaNac.Location = new Point(123, 145);
            FechaNac.Name = "FechaNac";
            FechaNac.Size = new Size(218, 23);
            FechaNac.TabIndex = 8;
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(484, 12);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(118, 29);
            btGuardar.TabIndex = 10;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // btModificar
            // 
            btModificar.Location = new Point(484, 57);
            btModificar.Name = "btModificar";
            btModificar.Size = new Size(118, 29);
            btModificar.TabIndex = 11;
            btModificar.Text = "Modificar";
            btModificar.UseVisualStyleBackColor = true;
            btModificar.Click += btModificar_Click;
            // 
            // btEliminar
            // 
            btEliminar.Location = new Point(484, 103);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(118, 29);
            btEliminar.TabIndex = 12;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = true;
            btEliminar.Click += btEliminar_Click;
            // 
            // dataGridEmple
            // 
            dataGridEmple.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmple.Location = new Point(32, 234);
            dataGridEmple.Name = "dataGridEmple";
            dataGridEmple.Size = new Size(699, 207);
            dataGridEmple.TabIndex = 13;
            // 
            // NumeroL
            // 
            NumeroL.Location = new Point(123, 25);
            NumeroL.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            NumeroL.Name = "NumeroL";
            NumeroL.Size = new Size(100, 23);
            NumeroL.TabIndex = 14;
            // 
            // PrecioHora
            // 
            PrecioHora.Location = new Point(123, 103);
            PrecioHora.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            PrecioHora.Name = "PrecioHora";
            PrecioHora.Size = new Size(100, 23);
            PrecioHora.TabIndex = 15;
            // 
            // btnCargarHS
            // 
            btnCargarHS.Location = new Point(484, 151);
            btnCargarHS.Name = "btnCargarHS";
            btnCargarHS.Size = new Size(118, 29);
            btnCargarHS.TabIndex = 16;
            btnCargarHS.Text = "Cargar HS";
            btnCargarHS.UseVisualStyleBackColor = true;
            btnCargarHS.Click += btnCargarHS_Click;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCargarHS);
            Controls.Add(PrecioHora);
            Controls.Add(NumeroL);
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
            Name = "Empleados";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridEmple).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumeroL).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrecioHora).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label num;
        private Label nom;
        private Label PrecioH;
        private Label fechN;
        private TextBox NomBre;
        private DateTimePicker FechaNac;
        private Button btGuardar;
        private Button btModificar;
        private Button btEliminar;
        private DataGridView dataGridEmple;
        private NumericUpDown NumeroL;
        private NumericUpDown PrecioHora;
        private Button btnCargarHS;
    }
}
