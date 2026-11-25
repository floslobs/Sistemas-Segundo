namespace EmpleadosOrigin.FE
{
    partial class EmpleadosHs
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
            btnMas = new Button();
            dataGridEmpleHS = new DataGridView();
            dtFecha = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridEmpleHS).BeginInit();
            SuspendLayout();
            // 
            // btnMas
            // 
            btnMas.BackColor = Color.DarkKhaki;
            btnMas.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMas.Location = new Point(385, 135);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(34, 60);
            btnMas.TabIndex = 7;
            btnMas.Text = "+";
            btnMas.UseVisualStyleBackColor = false;
            btnMas.Click += btnMas_Click;
            // 
            // dataGridEmpleHS
            // 
            dataGridEmpleHS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmpleHS.Location = new Point(25, 87);
            dataGridEmpleHS.Name = "dataGridEmpleHS";
            dataGridEmpleHS.Size = new Size(334, 190);
            dataGridEmpleHS.TabIndex = 6;
            // 
            // dtFecha
            // 
            dtFecha.Format = DateTimePickerFormat.Custom;
            dtFecha.Location = new Point(108, 31);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(101, 23);
            dtFecha.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 31);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 4;
            label1.Text = "FECHA";
            // 
            // EmpleadosHs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(480, 309);
            Controls.Add(btnMas);
            Controls.Add(dataGridEmpleHS);
            Controls.Add(dtFecha);
            Controls.Add(label1);
            Name = "EmpleadosHs";
            Text = "EmpleadosHs";
            Load += EmpleadosHs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridEmpleHS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMas;
        private DataGridView dataGridEmpleHS;
        private DateTimePicker dtFecha;
        private Label label1;
    }
}