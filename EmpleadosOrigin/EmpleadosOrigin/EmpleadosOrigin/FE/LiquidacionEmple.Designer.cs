namespace EmpleadosOrigin.FE
{
    partial class LiquidacionEmple
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
            dataGridEmpleLiqui = new DataGridView();
            btnVer = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridEmpleLiqui).BeginInit();
            SuspendLayout();
            // 
            // dataGridEmpleLiqui
            // 
            dataGridEmpleLiqui.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmpleLiqui.Location = new Point(12, 62);
            dataGridEmpleLiqui.Name = "dataGridEmpleLiqui";
            dataGridEmpleLiqui.Size = new Size(344, 330);
            dataGridEmpleLiqui.TabIndex = 0;
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.DarkKhaki;
            btnVer.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVer.Location = new Point(362, 165);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(55, 42);
            btnVer.TabIndex = 2;
            btnVer.Text = " Ver";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 42);
            label1.Name = "label1";
            label1.Size = new Size(83, 17);
            label1.TabIndex = 3;
            label1.Text = "EMPLEADOS";
            // 
            // LiquidacionEmple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(429, 404);
            Controls.Add(label1);
            Controls.Add(btnVer);
            Controls.Add(dataGridEmpleLiqui);
            Name = "LiquidacionEmple";
            Text = "LiquidacionEmple";
            Load += LiquidacionEmple_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridEmpleLiqui).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridEmpleLiqui;
        private Button btnVer;
        private Label label1;
    }
}