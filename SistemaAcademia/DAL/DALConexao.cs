using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DALConexao
    {
        private String _stringConexao;
        private SqlConnection _conexao;
        // public String StringConexao;
        public DALConexao(String dadosConexao) // metodo construtor
        {
            // Instanciando os dados privados da conexao
            this._conexao = new SqlConnection();
            // Definicao da conexao 
            this.StringConexao = dadosConexao;
            // Definicao dos tipo de conexao
            this._conexao.ConnectionString = dadosConexao;
        }
        public String StringConexao
        {
            get
            {
                return this._stringConexao;
            }
            set
            {
                this._stringConexao = value;
            }
        }
        public SqlConnection ObjetoConexao
        {
            get
            {
                return this._conexao;
            }
            set
            {

                this._conexao = value;
            }
        }
        public void Conectar()
        {
            this._conexao.Open();
        }
        public void Desconectar()
        {

            this._conexao.Close();

        }

    }


}
