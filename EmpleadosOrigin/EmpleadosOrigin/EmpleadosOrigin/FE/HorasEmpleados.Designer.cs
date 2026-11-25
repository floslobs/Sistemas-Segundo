namespace EmpleadosOrigin.FE
{
    partial class HorasEmpleados
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
            btnListo = new Button();
            dtSalida = new DateTimePicker();
            dtEntrada = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnListo
            // 
            btnListo.BackColor = Color.DarkKhaki;
            btnListo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnListo.Location = new Point(117, 97);
            btnListo.Name = "btnListo";
            btnListo.Size = new Size(131, 32);
            btnListo.TabIndex = 17;
            btnListo.Text = "Listo";
            btnListo.UseVisualStyleBackColor = false;
            btnListo.Click += btnListo_Click;
            // 
            // dtSalida
            // 
            dtSalida.CustomFormat = "HH:mm";
            dtSalida.Format = DateTimePickerFormat.Custom;
            dtSalida.Location = new Point(233, 41);
            dtSalida.Name = "dtSalida";
            dtSalida.Size = new Size(61, 23);
            dtSalida.TabIndex = 14;
            dtSalida.Value = new DateTime(2025, 5, 23, 21, 55, 0, 0);
            // 
            // dtEntrada
            // 
            dtEntrada.CustomFormat = "HH:mm";
            dtEntrada.Format = DateTimePickerFormat.Custom;
            dtEntrada.Location = new Point(53, 41);
            dtEntrada.Name = "dtEntrada";
            dtEntrada.Size = new Size(63, 23);
            dtEntrada.TabIndex = 13;
            dtEntrada.Value = new DateTime(2025, 5, 23, 21, 55, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(233, 21);
            label2.Name = "label2";
            label2.Size = new Size(63, 17);
            label2.TabIndex = 10;
            label2.Text = "Hs Salida";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 21);
            label1.Name = "label1";
            label1.Size = new Size(70, 17);
            label1.TabIndex = 9;
            label1.Text = "Hs Ingreso";
            // 
            // HorasEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(354, 194);
            Controls.Add(btnListo);
            Controls.Add(dtSalida);
            Controls.Add(dtEntrada);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HorasEmpleados";
            Text = "HorasEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListo;
        private DateTimePicker dtSalida;
        private DateTimePicker dtEntrada;
        private Label label2;
        private Label label1;
    }
}