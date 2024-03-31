using BLL;
using DAL;
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
    public partial class AlunoConsultaBairro : Form
    {
        public AlunoConsultaBairro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLEndereco bll = new BLLEndereco(cx);
            dataGridView1.DataSource = bll.Localizar(textBox1.Text);
        }

        private void AlunoConsultaBairro_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
