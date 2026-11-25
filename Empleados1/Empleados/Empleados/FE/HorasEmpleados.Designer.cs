namespace Empleados.FE
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtEntrada = new DateTimePicker();
            dtSalida = new DateTimePicker();
            dtDescansoInicio = new DateTimePicker();
            dtDescansoFin = new DateTimePicker();
            btnListo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 41);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Hs Ingreso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 41);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Hs Salida";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 2;
            label3.Text = "Descanso Desde";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 120);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 3;
            label4.Text = "Descanso Hasta";
            // 
            // dtEntrada
            // 
            dtEntrada.CustomFormat = "HH:mm";
            dtEntrada.Format = DateTimePickerFormat.Custom;
            dtEntrada.Location = new Point(115, 35);
            dtEntrada.Name = "dtEntrada";
            dtEntrada.Size = new Size(63, 23);
            dtEntrada.TabIndex = 4;
            dtEntrada.Value = new DateTime(2025, 5, 23, 21, 55, 0, 0);
            // 
            // dtSalida
            // 
            dtSalida.CustomFormat = "HH:mm";
            dtSalida.Format = DateTimePickerFormat.Custom;
            dtSalida.Location = new Point(288, 35);
            dtSalida.Name = "dtSalida";
            dtSalida.Size = new Size(61, 23);
            dtSalida.TabIndex = 5;
            dtSalida.Value = new DateTime(2025, 5, 23, 21, 55, 0, 0);
            // 
            // dtDescansoInicio
            // 
            dtDescansoInicio.CustomFormat = "HH:mm";
            dtDescansoInicio.Format = DateTimePickerFormat.Custom;
            dtDescansoInicio.Location = new Point(115, 112);
            dtDescansoInicio.Name = "dtDescansoInicio";
            dtDescansoInicio.Size = new Size(63, 23);
            dtDescansoInicio.TabIndex = 6;
            dtDescansoInicio.Value = new DateTime(2025, 5, 23, 21, 55, 0, 0);
            // 
            // dtDescansoFin
            // 
            dtDescansoFin.CustomFormat = "HH:mm";
            dtDescansoFin.Format = DateTimePickerFormat.Custom;
            dtDescansoFin.Location = new Point(323, 112);
            dtDescansoFin.Name = "dtDescansoFin";
            dtDescansoFin.Size = new Size(61, 23);
            dtDescansoFin.TabIndex = 7;
            dtDescansoFin.Value = new DateTime(2025, 5, 23, 21, 55, 0, 0);
            // 
            // btnListo
            // 
            btnListo.BackColor = SystemColors.ActiveCaption;
            btnListo.Location = new Point(291, 172);
            btnListo.Name = "btnListo";
            btnListo.Size = new Size(93, 36);
            btnListo.TabIndex = 8;
            btnListo.Text = "Listo";
            btnListo.UseVisualStyleBackColor = false;
            // 
            // HorasEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 220);
            Controls.Add(btnListo);
            Controls.Add(dtDescansoFin);
            Controls.Add(dtDescansoInicio);
            Controls.Add(dtSalida);
            Controls.Add(dtEntrada);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HorasEmpleados";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtEntrada;
        private DateTimePicker dtSalida;
        private DateTimePicker dtDescansoInicio;
        private DateTimePicker dtDescansoFin;
        private Button btnListo;
    }
}