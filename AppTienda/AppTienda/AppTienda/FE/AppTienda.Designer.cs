namespace AppTienda.FE
{
    partial class AppTienda
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
            dataGridViewStock = new DataGridView();
            textBox5 = new TextBox();
            label1 = new Label();
            btnRegistrarCliente = new Button();
            btnCargarProducto = new Button();
            btnRealizarVenta = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStock).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStock
            // 
            dataGridViewStock.BackgroundColor = SystemColors.Control;
            dataGridViewStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStock.Location = new Point(15, 46);
            dataGridViewStock.Name = "dataGridViewStock";
            dataGridViewStock.Size = new Size(772, 105);
            dataGridViewStock.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(687, 24);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(639, 28);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Buscar";
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Location = new Point(36, 189);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(148, 50);
            btnRegistrarCliente.TabIndex = 6;
            btnRegistrarCliente.Text = "Registrar Cliente";
            btnRegistrarCliente.UseVisualStyleBackColor = true;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click_1;
            // 
            // btnCargarProducto
            // 
            btnCargarProducto.Location = new Point(36, 330);
            btnCargarProducto.Name = "btnCargarProducto";
            btnCargarProducto.Size = new Size(75, 42);
            btnCargarProducto.TabIndex = 7;
            btnCargarProducto.Text = "Cargar Producto";
            btnCargarProducto.UseVisualStyleBackColor = true;
            btnCargarProducto.Click += btnCargarProducto_Click;
            // 
            // btnRealizarVenta
            // 
            btnRealizarVenta.Location = new Point(220, 189);
            btnRealizarVenta.Name = "btnRealizarVenta";
            btnRealizarVenta.Size = new Size(197, 47);
            btnRealizarVenta.TabIndex = 8;
            btnRealizarVenta.Text = "Realizar Venta";
            btnRealizarVenta.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 28);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 9;
            label5.Text = "Productos";
            // 
            // AppTienda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 586);
            Controls.Add(label5);
            Controls.Add(btnRealizarVenta);
            Controls.Add(btnCargarProducto);
            Controls.Add(btnRegistrarCliente);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(dataGridViewStock);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AppTienda";
            Text = "AppTienda";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewStock;
        private TextBox textBox5;
        private Label label1;
        private Button btnRegistrarCliente;
        private Button btnCargarProducto;
        private Button btnRealizarVenta;
        private Label label5;
    }
}