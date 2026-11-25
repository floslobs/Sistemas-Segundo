using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gantt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            flowLayoutPanelChat.AutoScroll = true;
            flowLayoutPanelChat.WrapContents = false;
            flowLayoutPanelChat.FlowDirection = FlowDirection.TopDown;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mensaje = new ChatBubbleControl(txtMensaje.Text, rbYo.Checked);
            flowLayoutPanelChat.Controls.Add(mensaje);

            // Me muevo hasta abajo hasta el ultimo mensaje agregado 
            if (flowLayoutPanelChat.Controls.Count > 0)
            {
                var ultimo = flowLayoutPanelChat.Controls[flowLayoutPanelChat.Controls.Count - 1];
                flowLayoutPanelChat.ScrollControlIntoView(ultimo);
            }

        }
    }
}
