using MODELO;
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
using System.Data.SqlClient;
using BLL;

namespace SistemaComercial

{
    
    public partial class CadastroAluno : Form
    {

        
        public int localCad = 0;
        public string operacao = "";
        public CadastroAluno()
        {
            InitializeComponent();
        }

        public void AlterarBotoes(int op)
        {
            pictureBox1.Enabled = false;
            panel1.Enabled = false;
            btnInserir.Enabled = false;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;

            if (op == 1)
            {
                btnInserir.Enabled = true;
                btnPesquisa.Enabled = true;

            }
            if (op == 2)
            {
                pictureBox1.Enabled = true;
                panel1.Enabled = true;
                btnCancelar.Enabled = true;
                btnSalvar.Enabled = true;

            }
            if (op == 3)
            {
                btnExcluir.Enabled = true;
                btnEditar.Enabled = true;

            }
        }

        public void LimpaCampos()
        {
            txtNumMatricula.Clear();
            txtDataMatricula.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtDataNascimento.Clear();
            txtCPF.Clear();
            txtCEP.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtDataVenc.Clear();
            txtNº.Clear();
            txtRG.Clear();
            txtTelefone.Clear();
            txtUF.Clear();
        }

        private void CadastroAluno_Load(object sender, EventArgs e)
        {
            if(localCad ==0)
            this.AlterarBotoes(1);

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
           
            DALEvento evento = new DALEvento(cx);
            comboBox2.DataSource = evento.Localizar("");
            comboBox2.DisplayMember = "NOME";
            comboBox2.ValueMember = "COD_EVENTO";

            DALProfessor professor = new DALProfessor(cx);
            comboBox3.DataSource = professor.Localizar("");
            comboBox3.DisplayMember = "NOME";
            comboBox3.ValueMember = "COD_PROF";

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlterarBotoes(2);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.AlterarBotoes(1);
            this.LimpaCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloCadastroAluno cadastro = new ModeloCadastroAluno();
                cadastro.NOME = txtNome.Text;
                cadastro.RG = txtRG.Text;
                cadastro.CPF = txtCPF.Text;
                cadastro.TELEFONE = txtTelefone.Text;
                cadastro.DATA_NASC = txtDataNascimento.Text;
                cadastro.PERIODO = comboBox1.Text;
                

                ModeloEndereco endereco = new ModeloEndereco();
                endereco.ENDERECO = txtEndereco.Text;
                endereco.NUMERO = int.Parse(txtNº.Text);
                endereco.COMPLEMENTO = txtComplemento.Text;
                endereco.CIDADE = txtCidade.Text;
                endereco.BAIRRO = txtBairro.Text;
                endereco.CEP = txtCEP.Text;
                endereco.UF = txtUF.Text;


                ModeloEvento evento = new ModeloEvento();
                evento.COD_EVENTO = Convert.ToInt32(comboBox2.SelectedValue);

                ModeloProfessor professor = new ModeloProfessor();
                professor.COD_PROF = Convert.ToInt32(comboBox3.SelectedValue);


                ModeloMatricula matricula = new ModeloMatricula();
                matricula.DATA_MATRICULA = txtDataMatricula.Text = DateTime.Now.ToShortDateString();
                matricula.DATA_VENC = txtDataVenc.Text;
                

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCadastroAluno aluno = new BLLCadastroAluno(cx);
                BLLEndereco end = new BLLEndereco(cx);
                BLLMatricula mat = new BLLMatricula(cx);



                if (this.operacao == "inserir")
                {

                   
                    aluno.Incluir(cadastro, endereco);
                    mat.Incluir(matricula, cadastro, evento, professor);


                    MessageBox.Show("Numero da Matricula do Aluno é: " + matricula.COD_MATRICULA.ToString(), "Registro Feito com Sucesso");

                }
                else
                {
                    matricula.COD_MATRICULA = Convert.ToInt32(txtNumMatricula.Text);
                    cadastro.COD_ALUNO = Convert.ToInt32(txtCodAluno.Text);
                    endereco.COD_ENDERECO = Convert.ToInt32(txtCodigoEndereco.Text);
                    aluno.Alterar(cadastro);
                    end.Alterar(endereco);
                    mat.Alterar(matricula);
                  
                   
                    MessageBox.Show("Alteração feita com sucesso");
                }
                this.LimpaCampos();
                AlterarBotoes(1);


            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {


                DialogResult d = MessageBox.Show("Deseja mesmo excluir esse registro ?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCadastroAluno c = new BLLCadastroAluno(cx);
                    BLLEndereco en = new BLLEndereco(cx);
                    BLLMatricula m = new BLLMatricula(cx);
                    
                   
                    c.Excluir(Convert.ToInt32(txtCodAluno.Text));
                    en.Excluir(Convert.ToInt32(txtCodigoEndereco.Text));
                    MessageBox.Show("Registro excluido com sucesso");
                    this.LimpaCampos();
                    
                }
            }
            catch 
            {
                MessageBox.Show("Impossivel excluir o registro. \n O registro está sendo ultilizado em outro local.");
                
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            AlunoConsultaMatricula c = new AlunoConsultaMatricula();
            c.cadastro = 1;
            c.ShowDialog();

            if(c.codigo !=0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMatricula bll = new BLLMatricula(cx);
                BLLCadastroAluno bllA = new BLLCadastroAluno(cx);
                BLLEndereco bllE = new BLLEndereco(cx);
                ModeloMatricula modelo = bll.CarregaModeloMatricula(c.codigo);
                ModeloCadastroAluno modeloa = bllA.CarregaModeloCadastroAluno(c.codigo);
                ModeloEndereco modeloe = bllE.CarregaModeloEndereco(c.codigo);
                txtNumMatricula.Text = modelo.COD_MATRICULA.ToString();                     
                txtNome.Text = modeloa.NOME;
                txtRG.Text = modeloa.RG;
                txtCPF.Text = modeloa.CPF;
                txtTelefone.Text = modeloa.TELEFONE;
                txtDataNascimento.Text = modeloa.DATA_NASC;
                txtEndereco.Text = modeloe.ENDERECO;
                txtNº.Text = modeloe.NUMERO.ToString();
                txtComplemento.Text = modeloe.COMPLEMENTO;
                txtCidade.Text = modeloe.CIDADE;
                txtBairro.Text = modeloe.BAIRRO;
                txtCEP.Text = modeloe.CEP;
                txtUF.Text = modeloe.UF;
                txtDataMatricula.Text = modelo.DATA_MATRICULA;
                txtDataVenc.Text = modelo.DATA_VENC;
                txtCodAluno.Text = modeloa.COD_ALUNO.ToString();
                txtCodigoEndereco.Text = modeloe.COD_ENDERECO.ToString();
                comboBox1.Text = modeloa.PERIODO;
                AlterarBotoes(3);
            } 
            else
            {
                this.LimpaCampos();
                this.AlterarBotoes(1);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AlterarBotoes(2);
            this.operacao = " alterar";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(DadosDaConexao.StringDeConexao);
            string pv = "SELECT *FROM PROFESSOR WHERE NOME = '"+comboBox3.Text+"' ";
            SqlCommand cmd = new SqlCommand(pv, cn);
            cn.Open();
            SqlDataReader leer = cmd.ExecuteReader();

            if(leer.Read() == true)
            {
                label15.Text = leer["TELEFONE"].ToString();
                label16.Text = leer["PERIODO"].ToString();
            }
            else
            {
                label15.Text = "";
                label16.Text = "";
            }
            cn.Close();
        }
    }
}
    

