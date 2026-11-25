namespace WS
{
    partial class FormWS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            bEnviarMsn = new Button();
            TexMens = new TextBox();
            DestinoMens = new ComboBox();
            UsuMens = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            NomUsu = new ComboBox();
            comboBox1 = new ComboBox();
            NumUsu = new NumericUpDown();
            bCrearUsu = new Button();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            DestinoMens2 = new ComboBox();
            UsuMens2 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            bBuscar = new Button();
            dataGrid1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumUsu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(bEnviarMsn);
            panel1.Controls.Add(TexMens);
            panel1.Controls.Add(DestinoMens);
            panel1.Controls.Add(UsuMens);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(20, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 312);
            panel1.TabIndex = 0;
            // 
            // bEnviarMsn
            // 
            bEnviarMsn.Location = new Point(182, 272);
            bEnviarMsn.Name = "bEnviarMsn";
            bEnviarMsn.Size = new Size(115, 26);
            bEnviarMsn.TabIndex = 9;
            bEnviarMsn.Text = "Enviar";
            bEnviarMsn.UseVisualStyleBackColor = true;
            bEnviarMsn.Click += bEnviarMsn_Click;
            // 
            // TexMens
            // 
            TexMens.Location = new Point(46, 174);
            TexMens.Multiline = true;
            TexMens.Name = "TexMens";
            TexMens.Size = new Size(222, 80);
            TexMens.TabIndex = 8;
            // 
            // DestinoMens
            // 
            DestinoMens.DropDownStyle = ComboBoxStyle.DropDownList;
            DestinoMens.FormattingEnabled = true;
            DestinoMens.Location = new Point(124, 86);
            DestinoMens.Name = "DestinoMens";
            DestinoMens.Size = new Size(159, 23);
            DestinoMens.TabIndex = 7;
            DestinoMens.Click += DestinoMens_Click;
            // 
            // UsuMens
            // 
            UsuMens.DropDownStyle = ComboBoxStyle.DropDownList;
            UsuMens.FormattingEnabled = true;
            UsuMens.Location = new Point(124, 37);
            UsuMens.Name = "UsuMens";
            UsuMens.Size = new Size(159, 23);
            UsuMens.TabIndex = 6;
            UsuMens.Click += UsuMens_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 149);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 5;
            label5.Text = "Texto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 94);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 4;
            label4.Text = "Destino";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 45);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 4;
            label3.Text = "Usuario";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(NomUsu);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(NumUsu);
            panel2.Controls.Add(bCrearUsu);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(443, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(291, 124);
            panel2.TabIndex = 1;
            // 
            // NomUsu
            // 
            NomUsu.FormattingEnabled = true;
            NomUsu.Location = new Point(107, 20);
            NomUsu.Name = "NomUsu";
            NomUsu.Size = new Size(159, 23);
            NomUsu.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(48, 502);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(159, 23);
            comboBox1.TabIndex = 12;
            // 
            // NumUsu
            // 
            NumUsu.Location = new Point(107, 49);
            NumUsu.Maximum = new decimal(new int[] { -1981284353, -1966660860, 0, 0 });
            NumUsu.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            NumUsu.Name = "NumUsu";
            NumUsu.Size = new Size(159, 23);
            NumUsu.TabIndex = 11;
            NumUsu.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // bCrearUsu
            // 
            bCrearUsu.Location = new Point(151, 95);
            bCrearUsu.Name = "bCrearUsu";
            bCrearUsu.Size = new Size(115, 26);
            bCrearUsu.TabIndex = 10;
            bCrearUsu.Text = "Crear";
            bCrearUsu.UseVisualStyleBackColor = true;
            bCrearUsu.Click += bCrearUsu_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 57);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 7;
            label7.Text = "Numero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 28);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 6;
            label6.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 35);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 2;
            label1.Text = "Enviar Mensaje";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(443, 9);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 3;
            label2.Text = "Crear Usuario";
            // 
            // DestinoMens2
            // 
            DestinoMens2.DropDownStyle = ComboBoxStyle.DropDownList;
            DestinoMens2.FormattingEnabled = true;
            DestinoMens2.Location = new Point(557, 244);
            DestinoMens2.Name = "DestinoMens2";
            DestinoMens2.Size = new Size(159, 23);
            DestinoMens2.TabIndex = 11;
            DestinoMens2.Click += DestinoMens2_Click;
            // 
            // UsuMens2
            // 
            UsuMens2.DropDownStyle = ComboBoxStyle.DropDownList;
            UsuMens2.FormattingEnabled = true;
            UsuMens2.Location = new Point(557, 215);
            UsuMens2.Name = "UsuMens2";
            UsuMens2.Size = new Size(159, 23);
            UsuMens2.TabIndex = 10;
            UsuMens2.Click += UsuMens2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(458, 253);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 8;
            label8.Text = "Destino";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(458, 223);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 9;
            label9.Text = "Usuario";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(423, 190);
            label10.Name = "label10";
            label10.Size = new Size(95, 15);
            label10.TabIndex = 12;
            label10.Text = "Mostrar Mensaje";
            // 
            // bBuscar
            // 
            bBuscar.Location = new Point(738, 228);
            bBuscar.Name = "bBuscar";
            bBuscar.Size = new Size(115, 26);
            bBuscar.TabIndex = 13;
            bBuscar.Text = "Buscar";
            bBuscar.UseVisualStyleBackColor = true;
            bBuscar.Click += bBuscar_Click;
            // 
            // dataGrid1
            // 
            dataGrid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid1.Location = new Point(423, 288);
            dataGrid1.Name = "dataGrid1";
            dataGrid1.Size = new Size(430, 150);
            dataGrid1.TabIndex = 14;
            // 
            // FormWS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 450);
            Controls.Add(dataGrid1);
            Controls.Add(bBuscar);
            Controls.Add(label10);
            Controls.Add(DestinoMens2);
            Controls.Add(UsuMens2);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormWS";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumUsu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label1;
        private Label label2;
        private TextBox TexMens;
        private ComboBox DestinoMens;
        private ComboBox UsuMens;
        private Button bEnviarMsn;
        private Button bCrearUsu;
        private NumericUpDown NumUsu;
        private ComboBox comboBox1;
        private ComboBox NomUsu;
        private ComboBox DestinoMens2;
        private ComboBox UsuMens2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button bBuscar;
        private DataGridView dataGrid1;
    }
}
