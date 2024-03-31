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
                cadastro.RG = txtRG.Text.Replace(",", String.Empty).Replace("-", String.Empty);
                cadastro.CPF = txtCPF.Text.Replace(",", String.Empty).Replace("-", String.Empty); 
                cadastro.TELEFONE = txtTelefone.Text.Replace("(", String.Empty).Replace(")", String.Empty).Replace("-", String.Empty);
                cadastro.DATA_NASC = txtDataNascimento.Text.Replace("/", String.Empty);
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


                ModeloMatricula matricula = new ModeloMatricula();
                matricula.DATA_MATRICULA = txtDataMatricula.Text.Replace("/", String.Empty);
                matricula.DATA_VENC = txtDataVenc.Text.Replace("/", String.Empty);
                

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCadastroAluno aluno = new BLLCadastroAluno(cx);
                BLLEndereco end = new BLLEndereco(cx);
                BLLMatricula mat = new BLLMatricula(cx);



                if (this.operacao == "inserir")
                {

                   
                    aluno.Incluir(cadastro, endereco);
                    mat.Incluir(matricula, cadastro, evento);


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
    }
}
    

