namespace Gantt
{
    partial class Form2
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
            flowLayoutPanelChat = new FlowLayoutPanel();
            button1 = new Button();
            txtMensaje = new TextBox();
            rbYo = new RadioButton();
            rbVos = new RadioButton();
            SuspendLayout();
            // 
            // flowLayoutPanelChat
            // 
            flowLayoutPanelChat.Location = new Point(12, 2);
            flowLayoutPanelChat.Name = "flowLayoutPanelChat";
            flowLayoutPanelChat.Size = new Size(756, 715);
            flowLayoutPanelChat.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(851, 282);
            button1.Name = "button1";
            button1.Size = new Size(174, 99);
            button1.TabIndex = 1;
            button1.Text = "Agregar Mensaje";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(797, 24);
            txtMensaje.Multiline = true;
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(274, 170);
            txtMensaje.TabIndex = 2;
            // 
            // rbYo
            // 
            rbYo.AutoSize = true;
            rbYo.Location = new Point(802, 208);
            rbYo.Name = "rbYo";
            rbYo.Size = new Size(50, 24);
            rbYo.TabIndex = 3;
            rbYo.TabStop = true;
            rbYo.Text = "Yo ";
            rbYo.UseVisualStyleBackColor = true;
            // 
            // rbVos
            // 
            rbVos.AutoSize = true;
            rbVos.Location = new Point(1021, 208);
            rbVos.Name = "rbVos";
            rbVos.Size = new Size(53, 24);
            rbVos.TabIndex = 4;
            rbVos.TabStop = true;
            rbVos.Text = "Vos";
            rbVos.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 751);
            Controls.Add(rbVos);
            Controls.Add(rbYo);
            Controls.Add(txtMensaje);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanelChat);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelChat;
        private Button button1;
        private TextBox txtMensaje;
        private RadioButton rbYo;
        private RadioButton rbVos;
    }
}