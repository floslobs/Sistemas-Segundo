namespace EmpleadosOrigin.FE
{
    partial class PrincipalEmpleados
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
            btnEmpleados = new Button();
            btnHoras = new Button();
            btnLiquidacion = new Button();
            SuspendLayout();
            // 
            // btnEmpleados
            // 
            btnEmpleados.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEmpleados.Location = new Point(706, 2);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(208, 62);
            btnEmpleados.TabIndex = 1;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnHoras
            // 
            btnHoras.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnHoras.Location = new Point(706, 70);
            btnHoras.Name = "btnHoras";
            btnHoras.Size = new Size(208, 62);
            btnHoras.TabIndex = 2;
            btnHoras.Text = "Horas";
            btnHoras.UseVisualStyleBackColor = true;
            btnHoras.Click += btnHoras_Click;
            // 
            // btnLiquidacion
            // 
            btnLiquidacion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLiquidacion.Location = new Point(706, 138);
            btnLiquidacion.Name = "btnLiquidacion";
            btnLiquidacion.Size = new Size(208, 62);
            btnLiquidacion.TabIndex = 4;
            btnLiquidacion.Text = "Liquidacion";
            btnLiquidacion.UseVisualStyleBackColor = true;
            btnLiquidacion.Click += btnLiquidacion_Click;
            // 
            // PrincipalEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(932, 471);
            Controls.Add(btnLiquidacion);
            Controls.Add(btnHoras);
            Controls.Add(btnEmpleados);
            IsMdiContainer = true;
            Name = "PrincipalEmpleados";
            Text = "PrincipalEmpleados";
            Load += PrincipalEmpleados_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnEmpleados;
        private Button btnHoras;
        private Button btnLiquidacion;
    }
}