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
    public partial class PesquisaUsuario : Form
    {
        public int codigo = 0;
        public int cadastro = 0;
        public PesquisaUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLUsuario bll = new BLLUsuario(cx);

            dataGridView1.DataSource = bll.Localizar(textBox1.Text);
        }

        private void PesquisaUsuario_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (cadastro == 0)
            {
                if (e.RowIndex >= 0)
                {
                    CadastroUsuario cadUsu = new CadastroUsuario();
                    int cod = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    int codigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUsuario usu = new BLLUsuario(cx);
                    ModeloUsuario usuario = usu.CarregaModeloUsuario(cod);
                    cadUsu.txtCodigo.Text = usuario.COD_USUARIO.ToString();
                    cadUsu.txtNome.Text = usuario.NOME;
                    cadUsu.txtUsuario.Text = usuario.USUARIO;
                    cadUsu.txtSenha.Text = usuario.SENHA;
                    cadUsu.txtConfSenha.Text = usuario.CONF_SENHA;
                    cadUsu.AlterarBotoes(3);
                    cadUsu.localCad = 1;

                    cadUsu.ShowDialog();

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
