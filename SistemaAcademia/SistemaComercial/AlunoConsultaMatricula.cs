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
    public partial class AlunoConsultaMatricula : Form 
    {
        public int codigo = 0;
        public int cadastro = 0;
        public AlunoConsultaMatricula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLMatricula bll = new BLLMatricula(cx);
            
            dataGridView1.DataSource = bll.Localizar(textBox1.Text);
             
            
        }

        private void AlunoConsultaMatricula_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

       
        

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (cadastro == 0)
            {
                if (e.RowIndex >= 0)
                {
                    CadastroAluno cadAluno = new CadastroAluno();
                    int cod = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    int codigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLMatricula bll = new BLLMatricula(cx);
                    BLLCadastroAluno bllA = new BLLCadastroAluno(cx);
                    BLLEndereco bllE = new BLLEndereco(cx);
                    ModeloMatricula modelo = bll.CarregaModeloMatricula(cod);
                    ModeloCadastroAluno modeloa = bllA.CarregaModeloCadastroAluno(cod);
                    ModeloEndereco modeloe = bllE.CarregaModeloEndereco(cod);

                    cadAluno.txtNumMatricula.Text = modelo.COD_MATRICULA.ToString();
                    cadAluno.txtNome.Text = modeloa.NOME;
                    cadAluno.txtRG.Text = modeloa.RG;
                    cadAluno.txtCPF.Text = modeloa.CPF;
                    cadAluno.txtTelefone.Text = modeloa.TELEFONE;
                    cadAluno.txtDataNascimento.Text = modeloa.DATA_NASC;
                    cadAluno.txtEndereco.Text = modeloe.ENDERECO;
                    cadAluno.txtNº.Text = modeloe.NUMERO.ToString();
                    cadAluno.txtComplemento.Text = modeloe.COMPLEMENTO;
                    cadAluno.txtCidade.Text = modeloe.CIDADE;
                    cadAluno.txtBairro.Text = modeloe.BAIRRO;
                    cadAluno.txtCEP.Text = modeloe.CEP;
                    cadAluno.txtUF.Text = modeloe.UF;
                    cadAluno.txtDataMatricula.Text = modelo.DATA_MATRICULA;
                    cadAluno.txtDataVenc.Text = modelo.DATA_VENC;
                    cadAluno.txtCodAluno.Text = modeloa.COD_ALUNO.ToString();
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

