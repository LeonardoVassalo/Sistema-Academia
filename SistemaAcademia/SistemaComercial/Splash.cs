using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaComercial
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)

            {
                progressBar1.Increment(2);
                label1.Text = progressBar1.Value.ToString() + " % ";
            }
            else
            {
                timer1.Enabled = false;
                this.Hide();
              Login f = new Login();
                f.ShowDialog();
                this.Close();


            }
        }
    }
}
