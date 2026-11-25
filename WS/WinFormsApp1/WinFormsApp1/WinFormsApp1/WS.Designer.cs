namespace WinFormsApp1
{
    partial class WS
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
            groupBox1 = new GroupBox();
            GuardarUsuario = new Button();
            txtNombre = new TextBox();
            spNumero = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            GuardarMensaje = new Button();
            txtTextoMensaje = new TextBox();
            label4 = new Label();
            label3 = new Label();
            cmbUsuarioDestino = new ComboBox();
            cmbUsuarioOrigen = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spNumero).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(GuardarUsuario);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(spNumero);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(734, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(490, 309);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuarios";
            // 
            // GuardarUsuario
            // 
            GuardarUsuario.Location = new Point(170, 147);
            GuardarUsuario.Name = "GuardarUsuario";
            GuardarUsuario.Size = new Size(200, 89);
            GuardarUsuario.TabIndex = 4;
            GuardarUsuario.Text = "GUARDAR";
            GuardarUsuario.UseVisualStyleBackColor = true;
            GuardarUsuario.Click += GuardarUsuario_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(181, 83);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(278, 27);
            txtNombre.TabIndex = 3;
            // 
            // spNumero
            // 
            spNumero.Location = new Point(181, 34);
            spNumero.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            spNumero.Name = "spNumero";
            spNumero.Size = new Size(150, 27);
            spNumero.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 90);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 41);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(GuardarMensaje);
            groupBox2.Controls.Add(txtTextoMensaje);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cmbUsuarioDestino);
            groupBox2.Controls.Add(cmbUsuarioOrigen);
            groupBox2.Location = new Point(66, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(489, 388);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mensajes";
            // 
            // GuardarMensaje
            // 
            GuardarMensaje.Location = new Point(138, 280);
            GuardarMensaje.Name = "GuardarMensaje";
            GuardarMensaje.Size = new Size(200, 89);
            GuardarMensaje.TabIndex = 5;
            GuardarMensaje.Text = "GUARDAR";
            GuardarMensaje.UseVisualStyleBackColor = true;
            GuardarMensaje.Click += GuardarMensaje_Click;
            // 
            // txtTextoMensaje
            // 
            txtTextoMensaje.Location = new Point(29, 137);
            txtTextoMensaje.Multiline = true;
            txtTextoMensaje.Name = "txtTextoMensaje";
            txtTextoMensaje.Size = new Size(427, 131);
            txtTextoMensaje.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 92);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 3;
            label4.Text = "Usuario Destino";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 39);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "Usuario Origen";
            // 
            // cmbUsuarioDestino
            // 
            cmbUsuarioDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuarioDestino.FormattingEnabled = true;
            cmbUsuarioDestino.Location = new Point(177, 88);
            cmbUsuarioDestino.Name = "cmbUsuarioDestino";
            cmbUsuarioDestino.Size = new Size(259, 28);
            cmbUsuarioDestino.TabIndex = 1;
            cmbUsuarioDestino.Click += cmbUsuarioDestino_Click;
            // 
            // cmbUsuarioOrigen
            // 
            cmbUsuarioOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuarioOrigen.FormattingEnabled = true;
            cmbUsuarioOrigen.Location = new Point(177, 35);
            cmbUsuarioOrigen.Name = "cmbUsuarioOrigen";
            cmbUsuarioOrigen.Size = new Size(259, 28);
            cmbUsuarioOrigen.TabIndex = 0;
            cmbUsuarioOrigen.Click += cmbUsuarioOrigen_Click;
            // 
            // WS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 555);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "WS";
            Text = "ws";
            Load += WS_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spNumero).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button GuardarUsuario;
        private TextBox txtNombre;
        private NumericUpDown spNumero;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtTextoMensaje;
        private Label label4;
        private Label label3;
        private ComboBox cmbUsuarioDestino;
        private ComboBox cmbUsuarioOrigen;
        private Button GuardarMensaje;
    }
}