using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaComercial
{
    public partial class Login : Form
    {
      
        private string _Sql = string.Empty;
        public Login()
        {
           
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            logar();
            
        }

       public void logar()
        {
            
            string usu, pwd;
            usu = textBox1.Text;
            pwd = textBox2.Text;
            
            SqlConnection sqlConn = null;

            sqlConn = new SqlConnection(DadosDaConexao.StringDeConexao);
            

            _Sql = "SELECT COUNT(COD_USUARIO) FROM USUARIO WHERE USUARIO = @usuario AND SENHA = @senha";
            SqlCommand cmd = new SqlCommand(_Sql, sqlConn);
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usu;
            cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = pwd;

            sqlConn.Open();

            int v = (int)cmd.ExecuteScalar();
            if (v>0)
            {
                this.Hide();
                TelaMenu menu = new TelaMenu();
                menu.ShowDialog();
                this.Close();
                



            }
            else
            {
                MessageBox.Show("Usuario e senha invalidos");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
