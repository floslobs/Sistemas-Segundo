namespace EManzanilla.FE
{
    partial class Pago
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
            dataGridViewPagos = new DataGridView();
            labelEmple2 = new Label();
            btnPagar = new Button();
            checkBoxSeleccionarTodo = new CheckBox();
            labelTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPagos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPagos
            // 
            dataGridViewPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPagos.Location = new Point(41, 70);
            dataGridViewPagos.Name = "dataGridViewPagos";
            dataGridViewPagos.Size = new Size(564, 259);
            dataGridViewPagos.TabIndex = 0;
            dataGridViewPagos.CellValueChanged += dataGridViewPagos_CellValueChanged;
            dataGridViewPagos.CurrentCellDirtyStateChanged += dataGridViewPagos_CurrentCellDirtyStateChanged;
            // 
            // labelEmple2
            // 
            labelEmple2.AutoSize = true;
            labelEmple2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmple2.ImageAlign = ContentAlignment.MiddleRight;
            labelEmple2.Location = new Point(132, 35);
            labelEmple2.Name = "labelEmple2";
            labelEmple2.Size = new Size(92, 21);
            labelEmple2.TabIndex = 1;
            labelEmple2.Text = "EMPLEADO";
            // 
            // btnPagar
            // 
            btnPagar.FlatAppearance.BorderColor = Color.Yellow;
            btnPagar.FlatAppearance.BorderSize = 2;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Location = new Point(633, 267);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(75, 40);
            btnPagar.TabIndex = 2;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // checkBoxSeleccionarTodo
            // 
            checkBoxSeleccionarTodo.AutoSize = true;
            checkBoxSeleccionarTodo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxSeleccionarTodo.Location = new Point(451, 39);
            checkBoxSeleccionarTodo.Name = "checkBoxSeleccionarTodo";
            checkBoxSeleccionarTodo.Size = new Size(154, 25);
            checkBoxSeleccionarTodo.TabIndex = 3;
            checkBoxSeleccionarTodo.Text = "Seleccionar Todo";
            checkBoxSeleccionarTodo.UseVisualStyleBackColor = true;
            checkBoxSeleccionarTodo.CheckedChanged += checkBoxSeleccionarTodo_CheckedChanged;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotal.Location = new Point(611, 223);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(56, 21);
            labelTotal.TabIndex = 4;
            labelTotal.Text = "TOTAL";
            // 
            // Pago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Manzanilla;
            ClientSize = new Size(736, 369);
            Controls.Add(labelTotal);
            Controls.Add(checkBoxSeleccionarTodo);
            Controls.Add(btnPagar);
            Controls.Add(labelEmple2);
            Controls.Add(dataGridViewPagos);
            Name = "Pago";
            Text = "Pago";
            Load += Pago_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPagos;
        private Label labelEmple2;
        private Button btnPagar;
        private CheckBox checkBoxSeleccionarTodo;
        private Label labelTotal;
    }
}