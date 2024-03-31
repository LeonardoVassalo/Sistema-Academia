using BLL;
using DAL;
using MODELO;
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
    public partial class ConsultaPlanos : Form
    {
        public int codigo = 0;
        public int cadastro = 0;
        public ConsultaPlanos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLEvento bll = new BLLEvento(cx);

            dataGridView1.DataSource = bll.Localizar(textBox1.Text);
        }

        private void ConsultaPlanos_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (cadastro == 0)
            {
                if (e.RowIndex >= 0)
                {
                    CadastroPlano cadPlano = new CadastroPlano();
                    int cod = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    int codigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLEvento evento = new BLLEvento(cx);
                    ModeloEvento modelo = evento.CarregaModeloEvento(cod);
                    cadPlano.txtCodigo.Text = modelo.COD_EVENTO.ToString();
                    cadPlano.txtPlano.Text = modelo.NOME;
                    cadPlano.txtValor.Text = modelo.VALOR.ToString();
                    cadPlano.AlterarBotoes(3);
                    cadPlano.localCad = 1;

                    cadPlano.ShowDialog();
                    this.Close();
                }

            }
            else
            {
                if (e.RowIndex >= 0)
                {
                    this.codigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    this.Close();
                }
            }
        }
    }
}
