namespace EManzanilla.FE
{
    partial class HorasTrabajo
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
            HorasSalida = new DateTimePicker();
            HorasEntrada = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            HorasSalida2 = new DateTimePicker();
            HorasEntrada2 = new DateTimePicker();
            HorasDescanso2 = new DateTimePicker();
            HorasDescanso1 = new DateTimePicker();
            label3 = new Label();
            labelNombreEmple = new Label();
            label6 = new Label();
            dateTimePickerFecha = new DateTimePicker();
            checkBoxFeriadoOdomingo = new CheckBox();
            numericUpDownPHora2 = new NumericUpDown();
            txtPHora = new Label();
            groupBoxHorasdeTrabajo = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPHora2).BeginInit();
            groupBoxHorasdeTrabajo.SuspendLayout();
            SuspendLayout();
            // 
            // btnListo
            // 
            btnListo.BackColor = Color.White;
            btnListo.FlatAppearance.BorderColor = Color.Yellow;
            btnListo.FlatAppearance.BorderSize = 2;
            btnListo.FlatStyle = FlatStyle.Flat;
            btnListo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnListo.Location = new Point(315, 396);
            btnListo.Name = "btnListo";
            btnListo.Size = new Size(131, 32);
            btnListo.TabIndex = 22;
            btnListo.Text = "Listo";
            btnListo.UseVisualStyleBackColor = false;
            btnListo.Click += btnListo_Click;
            // 
            // HorasSalida
            // 
            HorasSalida.CustomFormat = "HH:mm";
            HorasSalida.Format = DateTimePickerFormat.Custom;
            HorasSalida.Location = new Point(222, 59);
            HorasSalida.Name = "HorasSalida";
            HorasSalida.Size = new Size(61, 29);
            HorasSalida.TabIndex = 21;
            HorasSalida.Value = new DateTime(2025, 5, 23, 21, 55, 0, 0);
            // 
            // HorasEntrada
            // 
            HorasEntrada.CustomFormat = "HH:mm";
            HorasEntrada.Format = DateTimePickerFormat.Custom;
            HorasEntrada.Location = new Point(122, 59);
            HorasEntrada.Name = "HorasEntrada";
            HorasEntrada.Size = new Size(63, 29);
            HorasEntrada.TabIndex = 20;
            HorasEntrada.Value = new DateTime(2025, 5, 23, 21, 55, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(220, 39);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 19;
            label2.Text = "Salida";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(122, 39);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 18;
            label1.Text = "Ingreso";
            // 
            // HorasSalida2
            // 
            HorasSalida2.CustomFormat = "HH:mm";
            HorasSalida2.Format = DateTimePickerFormat.Custom;
            HorasSalida2.Location = new Point(220, 88);
            HorasSalida2.Name = "HorasSalida2";
            HorasSalida2.Size = new Size(61, 29);
            HorasSalida2.TabIndex = 26;
            HorasSalida2.Value = new DateTime(2025, 5, 23, 21, 55, 0, 0);
            // 
            // HorasEntrada2
            // 
            HorasEntrada2.CustomFormat = "HH:mm";
            HorasEntrada2.Format = DateTimePickerFormat.Custom;
            HorasEntrada2.Location = new Point(122, 93);
            HorasEntrada2.Name = "HorasEntrada2";
            HorasEntrada2.Size = new Size(63, 29);
            HorasEntrada2.TabIndex = 25;
            HorasEntrada2.Value = new DateTime(2025, 5, 23, 21, 55, 0, 0);
            // 
            // HorasDescanso2
            // 
            HorasDescanso2.CustomFormat = "HH:mm";
            HorasDescanso2.Format = DateTimePickerFormat.Custom;
            HorasDescanso2.Location = new Point(113, 163);
            HorasDescanso2.Name = "HorasDescanso2";
            HorasDescanso2.Size = new Size(61, 29);
            HorasDescanso2.TabIndex = 28;
            HorasDescanso2.Value = new DateTime(2025, 5, 23, 21, 55, 0, 0);
            // 
            // HorasDescanso1
            // 
            HorasDescanso1.CustomFormat = "HH:mm";
            HorasDescanso1.Format = DateTimePickerFormat.Custom;
            HorasDescanso1.Location = new Point(9, 163);
            HorasDescanso1.Name = "HorasDescanso1";
            HorasDescanso1.Size = new Size(63, 29);
            HorasDescanso1.TabIndex = 27;
            HorasDescanso1.Value = new DateTime(2025, 5, 23, 21, 55, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 135);
            label3.Name = "label3";
            label3.Size = new Size(126, 21);
            label3.TabIndex = 29;
            label3.Text = "Horas Descanso";
            // 
            // labelNombreEmple
            // 
            labelNombreEmple.AutoSize = true;
            labelNombreEmple.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombreEmple.Location = new Point(132, 9);
            labelNombreEmple.Name = "labelNombreEmple";
            labelNombreEmple.Size = new Size(111, 25);
            labelNombreEmple.TabIndex = 30;
            labelNombreEmple.Text = "EMPLEADO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(12, 40);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 33;
            label6.Text = "Fecha";
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dateTimePickerFecha.Format = DateTimePickerFormat.Custom;
            dateTimePickerFecha.Location = new Point(12, 64);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(98, 29);
            dateTimePickerFecha.TabIndex = 34;
            // 
            // checkBoxFeriadoOdomingo
            // 
            checkBoxFeriadoOdomingo.AutoSize = true;
            checkBoxFeriadoOdomingo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            checkBoxFeriadoOdomingo.Location = new Point(238, 69);
            checkBoxFeriadoOdomingo.Name = "checkBoxFeriadoOdomingo";
            checkBoxFeriadoOdomingo.Size = new Size(170, 25);
            checkBoxFeriadoOdomingo.TabIndex = 35;
            checkBoxFeriadoOdomingo.Text = "Feriado o Domingo";
            checkBoxFeriadoOdomingo.UseVisualStyleBackColor = true;
            // 
            // numericUpDownPHora2
            // 
            numericUpDownPHora2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            numericUpDownPHora2.Location = new Point(112, 137);
            numericUpDownPHora2.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericUpDownPHora2.Name = "numericUpDownPHora2";
            numericUpDownPHora2.Size = new Size(108, 29);
            numericUpDownPHora2.TabIndex = 41;
            // 
            // txtPHora
            // 
            txtPHora.AutoSize = true;
            txtPHora.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtPHora.Location = new Point(113, 113);
            txtPHora.Name = "txtPHora";
            txtPHora.Size = new Size(96, 21);
            txtPHora.TabIndex = 40;
            txtPHora.Text = "Precio Hora";
            // 
            // groupBoxHorasdeTrabajo
            // 
            groupBoxHorasdeTrabajo.Controls.Add(label1);
            groupBoxHorasdeTrabajo.Controls.Add(label2);
            groupBoxHorasdeTrabajo.Controls.Add(HorasEntrada);
            groupBoxHorasdeTrabajo.Controls.Add(HorasSalida);
            groupBoxHorasdeTrabajo.Controls.Add(HorasEntrada2);
            groupBoxHorasdeTrabajo.Controls.Add(HorasSalida2);
            groupBoxHorasdeTrabajo.Controls.Add(label3);
            groupBoxHorasdeTrabajo.Controls.Add(HorasDescanso1);
            groupBoxHorasdeTrabajo.Controls.Add(HorasDescanso2);
            groupBoxHorasdeTrabajo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBoxHorasdeTrabajo.Location = new Point(35, 172);
            groupBoxHorasdeTrabajo.Name = "groupBoxHorasdeTrabajo";
            groupBoxHorasdeTrabajo.Size = new Size(303, 198);
            groupBoxHorasdeTrabajo.TabIndex = 44;
            groupBoxHorasdeTrabajo.TabStop = false;
            groupBoxHorasdeTrabajo.Text = "Horas de trabajo";
            // 
            // HorasTrabajo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Manzanilla1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(467, 440);
            Controls.Add(groupBoxHorasdeTrabajo);
            Controls.Add(numericUpDownPHora2);
            Controls.Add(txtPHora);
            Controls.Add(checkBoxFeriadoOdomingo);
            Controls.Add(dateTimePickerFecha);
            Controls.Add(label6);
            Controls.Add(labelNombreEmple);
            Controls.Add(btnListo);
            Name = "HorasTrabajo";
            Text = "HorasTrabajo";
            Load += HorasTrabajo_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownPHora2).EndInit();
            groupBoxHorasdeTrabajo.ResumeLayout(false);
            groupBoxHorasdeTrabajo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListo;
        private DateTimePicker HorasSalida;
        private DateTimePicker HorasEntrada;
        private Label label2;
        private Label label1;
        private DateTimePicker HorasSalida2;
        private DateTimePicker HorasEntrada2;
        private DateTimePicker HorasDescanso2;
        private DateTimePicker HorasDescanso1;
        private Label label3;
        private Label labelNombreEmple;
        private Label label6;
        private DateTimePicker dateTimePickerFecha;
        private CheckBox checkBoxFeriadoOdomingo;
        private NumericUpDown numericUpDownPHora2;
        private Label txtPHora;
        private GroupBox groupBoxHorasdeTrabajo;
    }
}