namespace EmpleadosOrigin.FE
{
    partial class Liquidacion
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
            lblfecha = new Label();
            lblHoras = new Label();
            lblPrecioHora = new Label();
            lblTotal = new Label();
            lblnombre = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(185, 29);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 0;
            label1.Text = "RECIBO DE SUELDO";
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblfecha.Location = new Point(136, 78);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(50, 17);
            lblfecha.TabIndex = 2;
            lblfecha.Text = "Mes:    ";
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblHoras.Location = new Point(12, 228);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(161, 17);
            lblHoras.TabIndex = 3;
            lblHoras.Text = "Horas trabajadas:             ";
            // 
            // lblPrecioHora
            // 
            lblPrecioHora.AutoSize = true;
            lblPrecioHora.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblPrecioHora.Location = new Point(12, 255);
            lblPrecioHora.Name = "lblPrecioHora";
            lblPrecioHora.Size = new Size(150, 17);
            lblPrecioHora.TabIndex = 4;
            lblPrecioHora.Text = "Precio por hora:            ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblTotal.Location = new Point(12, 280);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(145, 17);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total a cobrar:             ";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblnombre.Location = new Point(12, 115);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(120, 17);
            lblnombre.TabIndex = 6;
            lblnombre.Text = "Empleado:             ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 11);
            label2.Name = "label2";
            label2.Size = new Size(507, 15);
            label2.TabIndex = 7;
            label2.Text = "----------------------------------------------------------------------------------------------------";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 47);
            label3.Name = "label3";
            label3.Size = new Size(507, 15);
            label3.TabIndex = 8;
            label3.Text = "----------------------------------------------------------------------------------------------------";
            // 
            // Liquidacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(506, 320);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblnombre);
            Controls.Add(lblTotal);
            Controls.Add(lblPrecioHora);
            Controls.Add(lblHoras);
            Controls.Add(lblfecha);
            Controls.Add(label1);
            Name = "Liquidacion";
            Text = "Liquidacion";
            Load += Liquidacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblfecha;
        private Label lblHoras;
        private Label lblPrecioHora;
        private Label lblTotal;
        private Label lblnombre;
        private Label label2;
        private Label label3;
    }
}