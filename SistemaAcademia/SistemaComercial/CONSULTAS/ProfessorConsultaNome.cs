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
    public partial class ProfessorConsultaNome : Form
    {
        public int codigo = 0;
        public int cadastro = 0;
        public ProfessorConsultaNome()
        {
            InitializeComponent();
        }

        private void ProfessorConsultaNome_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProfessor bll = new BLLProfessor(cx);

            dataGridView1.DataSource = bll.LocalizarNome(textBox1.Text);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (cadastro == 0)
            {
                if (e.RowIndex >= 0)
                {
                    CadastroProfessor cadAluno = new CadastroProfessor();
                    int cod = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    int codigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLProfessor bll = new BLLProfessor(cx);
                    BLLEndereco bllE = new BLLEndereco(cx);
                    ModeloProfessor modeloa = bll.CarregaModeloProfessor(cod);
                    ModeloEndereco modeloe = bllE.CarregaModeloEnderecoProfessor(cod);

                    cadAluno.txtNumProfessor.Text = modeloa.COD_PROF.ToString();
                    cadAluno.txtNome.Text = modeloa.NOME;
                    cadAluno.txtRG.Text = modeloa.RG;
                    cadAluno.txtCPF.Text = modeloa.CPF;
                    cadAluno.txtTelefone.Text = modeloa.TELEFONE;
                    cadAluno.txtDataNascimento.Text = modeloa.DATA_NASC;
                    cadAluno.txtEndereco.Text = modeloe.ENDERECO;
                    cadAluno.txtNum.Text = modeloe.NUMERO.ToString();
                    cadAluno.txtComplemento.Text = modeloe.COMPLEMENTO;
                    cadAluno.txtCidade.Text = modeloe.CIDADE;
                    cadAluno.txtBairro.Text = modeloe.BAIRRO;
                    cadAluno.txtCEP.Text = modeloe.CEP;
                    cadAluno.txtUF.Text = modeloe.UF;
                    cadAluno.txtCodigoEndereco.Text = modeloe.COD_ENDERECO.ToString();
                    cadAluno.comboBox1.Text = modeloa.PERIODO;
                    cadAluno.AlterarBotoes(3);
                    cadAluno.localCad = 1;

                    cadAluno.ShowDialog();
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
