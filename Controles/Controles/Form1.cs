using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhabilitar_Click(object sender, EventArgs e)
        {
            gpbcontroles.Enabled = true;
        }

        private void btndesabilitar_Click(object sender, EventArgs e)
        {
            gpbcontroles.Enabled = false;
        }

        private void btnvisivel_Click(object sender, EventArgs e)
        {
            gpbcontroles.Visible = true;
        }

        private void btninvisivel_Click(object sender, EventArgs e)
        {
            gpbcontroles.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbestado.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Valor é: "+numvalores.Value);
        }
    }
}
