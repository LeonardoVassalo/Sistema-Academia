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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AlterarBotoes(2);
            this.operacao = " alterar";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloProfessor professor = new ModeloProfessor();
                professor.NOME = txtNome.Text;
                professor.RG = txtRG.Text.Replace(",", String.Empty).Replace("-", String.Empty);
                professor.CPF = txtCPF.Text.Replace(",", String.Empty).Replace("-", String.Empty);
                professor.TELEFONE = txtTelefone.Text.Replace("(", String.Empty).Replace(")", String.Empty).Replace("-", String.Empty);
                professor.DATA_NASC = txtDataNascimento.Text.Replace("/", String.Empty);
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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {

        }
    }
    
}
