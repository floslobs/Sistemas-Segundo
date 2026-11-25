namespace EManzanilla.FE
{
    partial class Resumen
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
            dataGridViewResumen = new DataGridView();
            labelEmpleadoResumen = new Label();
            txtBuscar2 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResumen).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewResumen
            // 
            dataGridViewResumen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResumen.Location = new Point(28, 52);
            dataGridViewResumen.Name = "dataGridViewResumen";
            dataGridViewResumen.Size = new Size(1119, 366);
            dataGridViewResumen.TabIndex = 0;
            // 
            // labelEmpleadoResumen
            // 
            labelEmpleadoResumen.AutoSize = true;
            labelEmpleadoResumen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelEmpleadoResumen.Location = new Point(156, 23);
            labelEmpleadoResumen.Name = "labelEmpleadoResumen";
            labelEmpleadoResumen.Size = new Size(92, 21);
            labelEmpleadoResumen.TabIndex = 1;
            labelEmpleadoResumen.Text = "EMPLEADO";
            // 
            // txtBuscar2
            // 
            txtBuscar2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtBuscar2.Location = new Point(867, 20);
            txtBuscar2.Name = "txtBuscar2";
            txtBuscar2.Size = new Size(100, 29);
            txtBuscar2.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(794, 26);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 44;
            label2.Text = "Buscar";
            // 
            // Resumen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Manzanilla;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1174, 450);
            Controls.Add(txtBuscar2);
            Controls.Add(label2);
            Controls.Add(labelEmpleadoResumen);
            Controls.Add(dataGridViewResumen);
            Name = "Resumen";
            Text = "Resumen";
            Load += Resumen_Load;
            TextChanged += Resumen_TextChanged;
            ((System.ComponentModel.ISupportInitialize)dataGridViewResumen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewResumen;
        private Label labelEmpleadoResumen;
        private TextBox txtBuscar;
        private Label label2;
        private TextBox txtBuscar2;
    }
}