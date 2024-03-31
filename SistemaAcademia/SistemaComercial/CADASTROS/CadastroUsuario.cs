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
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        public int localCad = 0;
        public string operacao = "";

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
            txtCodigo.Clear();
            txtNome.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            txtConfSenha.Clear();
          
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
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
            PesquisaUsuario c = new PesquisaUsuario();
            c.cadastro = 1;
            c.ShowDialog();

            if (c.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario usu = new BLLUsuario(cx);
                ModeloUsuario usuario = usu.CarregaModeloUsuario(c.codigo);
                txtCodigo.Text = usuario.COD_USUARIO.ToString();
                txtNome.Text = usuario.NOME;
                txtUsuario.Text = usuario.USUARIO;
                txtSenha.Text = usuario.SENHA;
                txtConfSenha.Text = usuario.CONF_SENHA;
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

        private void btnExcluir_Click(object sender, EventArgs e)
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
                ModeloUsuario usuario = new ModeloUsuario();
                usuario.NOME = txtNome.Text;
                usuario.USUARIO = txtUsuario.Text;
                usuario.SENHA = txtSenha.Text;
                usuario.CONF_SENHA = txtConfSenha.Text;


                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);



                if (this.operacao == "inserir")
                {
                    bll.Incluir(usuario);
                    MessageBox.Show("Registro feito com sucesso");

                }
                else
                {
                    usuario.COD_USUARIO = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(usuario);

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

