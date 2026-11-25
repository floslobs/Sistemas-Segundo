namespace EManzanilla.FE
{
    partial class HistorialInactivos
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
            dataGridViewHinactivos = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHinactivos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHinactivos
            // 
            dataGridViewHinactivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHinactivos.Location = new Point(28, 64);
            dataGridViewHinactivos.Name = "dataGridViewHinactivos";
            dataGridViewHinactivos.Size = new Size(582, 322);
            dataGridViewHinactivos.TabIndex = 0;
            dataGridViewHinactivos.CellValueChanged += dataGridViewHinactivos_CellValueChanged;
            dataGridViewHinactivos.CurrentCellDirtyStateChanged += dataGridViewHinactivos_CurrentCellDirtyStateChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(226, 28);
            label1.Name = "label1";
            label1.Size = new Size(159, 21);
            label1.TabIndex = 1;
            label1.Text = "Empleados Inactivos";
            // 
            // HistorialInactivos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Manzanilla;
            ClientSize = new Size(633, 450);
            Controls.Add(label1);
            Controls.Add(dataGridViewHinactivos);
            Name = "HistorialInactivos";
            Text = "HistorialInactivos";
            Load += HistorialInactivos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHinactivos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewHinactivos;
        private Label label1;
    }
}