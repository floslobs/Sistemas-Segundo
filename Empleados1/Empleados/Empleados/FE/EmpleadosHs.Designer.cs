namespace Empleados.FE
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
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridEmpleHS = new DataGridView();
            btnMas = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridEmpleHS).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 65);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(91, 59);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // dataGridEmpleHS
            // 
            dataGridEmpleHS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmpleHS.Location = new Point(36, 122);
            dataGridEmpleHS.Name = "dataGridEmpleHS";
            dataGridEmpleHS.Size = new Size(334, 190);
            dataGridEmpleHS.TabIndex = 2;
            // 
            // btnMas
            // 
            btnMas.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMas.Location = new Point(396, 199);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(36, 45);
            btnMas.TabIndex = 3;
            btnMas.Text = "+";
            btnMas.UseVisualStyleBackColor = true;
            btnMas.Click += btnMas_Click;
            // 
            // EmpleadosHs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 450);
            Controls.Add(btnMas);
            Controls.Add(dataGridEmpleHS);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "EmpleadosHs";
            Text = "Form1";
            Load += EmpleadosHs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridEmpleHS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridEmpleHS;
        private Button btnMas;
    }
}