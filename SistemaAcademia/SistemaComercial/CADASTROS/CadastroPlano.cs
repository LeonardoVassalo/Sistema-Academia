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
    public partial class CadastroPlano : Form
    {
        public int localCad = 0;
        public string operacao = "";
        public CadastroPlano()
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
            txtPlano.Clear();
            txtValor.Clear();


        }
        private void CadastroPlano_Load(object sender, EventArgs e)
        {
            if (localCad == 0)
                this.AlterarBotoes(1);
        }

      

        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlterarBotoes(2);
        }

        private void btnPesquisa_Click_1(object sender, EventArgs e)
        {
            ConsultaPlanos c = new ConsultaPlanos();
            c.cadastro = 1;
            c.ShowDialog();

            if (c.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLEvento evento = new BLLEvento(cx);
                ModeloEvento modelo = evento.CarregaModeloEvento(c.codigo);
                txtCodigo.Text = modelo.COD_EVENTO.ToString();
                txtPlano.Text = modelo.NOME;
                txtValor.Text = modelo.VALOR.ToString();

                AlterarBotoes(3);
            }
            else
            {
                this.LimpaCampos();
                this.AlterarBotoes(1);
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            AlterarBotoes(2);
            this.operacao = " alterar";
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.AlterarBotoes(1);
            this.LimpaCampos();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                ModeloEvento evento = new ModeloEvento();
                evento.NOME = txtPlano.Text;
                evento.VALOR = Convert.ToDouble(txtValor.Text.Replace("$", String.Empty).Replace("R", String.Empty).Replace(":", String.Empty));


                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLEvento bll = new BLLEvento(cx);


                if (this.operacao == "inserir")
                {
                    bll.Incluir(evento);

                    MessageBox.Show("Plano Registrado com Sucesso");

                }
                else
                {
                    evento.COD_EVENTO = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(evento);
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
    }
}
