namespace AppTienda.FE
{
    partial class Clientes
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
            groupBoxCliente = new GroupBox();
            numericUpDownDNI = new NumericUpDown();
            label4 = new Label();
            label6 = new Label();
            btnRegistrarCliente = new Button();
            txtNomApe = new TextBox();
            groupBoxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDNI).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCliente
            // 
            groupBoxCliente.Controls.Add(numericUpDownDNI);
            groupBoxCliente.Controls.Add(btnRegistrarCliente);
            groupBoxCliente.Controls.Add(label4);
            groupBoxCliente.Controls.Add(label6);
            groupBoxCliente.Controls.Add(txtNomApe);
            groupBoxCliente.Location = new Point(43, 25);
            groupBoxCliente.Name = "groupBoxCliente";
            groupBoxCliente.Size = new Size(321, 215);
            groupBoxCliente.TabIndex = 4;
            groupBoxCliente.TabStop = false;
            groupBoxCliente.Text = "Cargar Cliente";
            // 
            // numericUpDownDNI
            // 
            numericUpDownDNI.Location = new Point(178, 101);
            numericUpDownDNI.Name = "numericUpDownDNI";
            numericUpDownDNI.Size = new Size(137, 23);
            numericUpDownDNI.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 109);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 8;
            label4.Text = "DNI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 50);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 6;
            label6.Text = "Nombre y Apellido";
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Location = new Point(172, 157);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(84, 39);
            btnRegistrarCliente.TabIndex = 5;
            btnRegistrarCliente.Text = "Registrar";
            btnRegistrarCliente.UseVisualStyleBackColor = true;
            // 
            // txtNomApe
            // 
            txtNomApe.Location = new Point(172, 42);
            txtNomApe.Name = "txtNomApe";
            txtNomApe.Size = new Size(143, 23);
            txtNomApe.TabIndex = 0;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 257);
            Controls.Add(groupBoxCliente);
            Name = "Cliente";
            Text = "Cliente";
            groupBoxCliente.ResumeLayout(false);
            groupBoxCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDNI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private GroupBox groupBoxCliente;
        private NumericUpDown numericUpDownDNI;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private TextBox textBox3;
        private Button btnRegistrarCliente;
        private TextBox textBox2;
        private TextBox txtNomApe;
    }
}