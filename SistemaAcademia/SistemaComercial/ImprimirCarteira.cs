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
    public partial class ImprimirCarteira : Form
    {
        public int codigo = 0;
        public int cadastro = 0;
        public ImprimirCarteira()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFrequencia bll = new BLLFrequencia(cx);

            dataGridView1.DataSource = bll.LocalizarIm(textBox1.Text);
        }

        private void ImprimirCarteira_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (cadastro == 0)
            {
                if (e.RowIndex >= 0)
                {
                    Imprimir i = new Imprimir();
                
                    int codigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLMatricula bll = new BLLMatricula(cx);
                    BLLCadastroAluno bllA = new BLLCadastroAluno(cx);
                    BLLEvento bllP = new BLLEvento(cx);
                    ModeloMatricula modelo = bll.CarregaModeloMatricula(codigo);
                    ModeloCadastroAluno modeloa = bllA.CarregaModeloCadastroAluno(codigo);
                    ModeloEvento modeloe = bllP.CarregaModeloEvento(codigo);

                    i.labeMatricula.Text = modelo.COD_MATRICULA.ToString();
                    i.labelNome.Text = modeloa.NOME;
                    i.labelPlano.Text = modeloe.NOME;
                    i.labelValor.Text = modeloe.VALOR.ToString();
                    i.labelPeriodo.Text = modeloa.PERIODO;
                    i.labelVenc.Text = modelo.DATA_VENC;
                    i.labelAno.Text = DateTime.Now.Year.ToString();

                    i.ShowDialog();
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
