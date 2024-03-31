using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODELO;
using BLL;
using DAL;

namespace SistemaComercial
{
    public partial class CadastroProfessor : Form
    {
        public int localCad = 0;
        public string operacao = "";
        public CadastroProfessor()
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
            txtNumProfessor.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtDataNascimento.Clear();
            txtCPF.Clear();
            txtCEP.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtNum.Clear();
            txtRG.Clear();
            txtTelefone.Clear();
            txtUF.Clear();





        }

        private void CadastroProfessor_Load(object sender, EventArgs e)
        {
            if (localCad == 0)
            this.AlterarBotoes(1);
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

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            AlterarBotoes(2);
            this.operacao = " alterar";
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                ModeloProfessor professor = new ModeloProfessor();
                professor.NOME = txtNome.Text;
                professor.RG = txtRG.Text; 
                professor.CPF = txtCPF.Text; 
                professor.TELEFONE = txtTelefone.Text;  
                professor.DATA_NASC = txtDataNascimento.Text;  
                professor.PERIODO = comboBox1.Text;


                ModeloEndereco endereco = new ModeloEndereco();
                endereco.ENDERECO = txtEndereco.Text;
                endereco.NUMERO = int.Parse(txtNum.Text);
                endereco.COMPLEMENTO = txtComplemento.Text;
                endereco.CIDADE = txtCidade.Text;
                endereco.BAIRRO = txtBairro.Text;
                endereco.CEP = txtCEP.Text;
                endereco.UF = txtUF.Text;


             
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProfessor prof = new BLLProfessor(cx);
                BLLEndereco end = new BLLEndereco(cx);
               

                if (this.operacao == "inserir")
                {
                    prof.Incluir(professor, endereco);
                    MessageBox.Show("Numero do Professor é: " + professor.COD_PROF.ToString(), "Registro Feito com Sucesso");

                }
                else
                {
                    
                    professor.COD_PROF = Convert.ToInt32(txtNumProfessor.Text);
                    endereco.COD_ENDERECO = Convert.ToInt32(txtCodigoEndereco.Text);
                    prof.Alterar(professor);
                    end.Alterar(endereco);
                   
                    MessageBox.Show("Alteração feita com sucesso");
                }

                this.LimpaCampos();
                AlterarBotoes(1);


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void btnPesquisa_Click_1(object sender, EventArgs e)
        {
            ProfessorConsultaCodigo c = new ProfessorConsultaCodigo();
            c.cadastro = 1;
            c.ShowDialog();

            if (c.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProfessor bll = new BLLProfessor(cx);
                BLLEndereco bllE = new BLLEndereco(cx);
                ModeloProfessor modeloa = bll.CarregaModeloProfessor(c.codigo);
                ModeloEndereco modeloe = bllE.CarregaModeloEnderecoProfessor(c.codigo);
                txtNumProfessor.Text = modeloa.COD_PROF.ToString();
                txtNome.Text = modeloa.NOME;
                txtRG.Text = modeloa.RG;
                txtCPF.Text = modeloa.CPF;
                txtTelefone.Text = modeloa.TELEFONE;
                txtDataNascimento.Text = modeloa.DATA_NASC;
                txtEndereco.Text = modeloe.ENDERECO;
                txtNum.Text = modeloe.NUMERO.ToString();
                txtComplemento.Text = modeloe.COMPLEMENTO;
                txtCidade.Text = modeloe.CIDADE;
                txtBairro.Text = modeloe.BAIRRO;
                txtCEP.Text = modeloe.CEP;
                txtUF.Text = modeloe.UF;
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

        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlterarBotoes(2);
        }

      
    }
    
}
