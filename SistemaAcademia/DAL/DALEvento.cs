using MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALEvento
    {
        private DALConexao conexao;
        public DALEvento(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloEvento evento)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;

            cmd.CommandText = "insert into EVENTO (NOME, VALOR) values (@NOME, @VALOR);select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@NOME", evento.NOME);
            cmd.Parameters.AddWithValue("@VALOR", evento.VALOR);
            conexao.Conectar();
            evento.COD_EVENTO = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloEvento evento)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update EVENTO set NOME = @NOME, VALOR = @VALOR where COD_EVENTO = @COD_EVENTO;";

            cmd.Parameters.AddWithValue("@NOME", evento.NOME);
            cmd.Parameters.AddWithValue("@VALOR", evento.VALOR);
            cmd.Parameters.AddWithValue("@COD_EVENTO", evento.COD_EVENTO);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from EVENTO where COD_EVENTO = @COD_EVENTO;";
            cmd.Parameters.AddWithValue("@COD_EVENTO", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from EVENTO where NOME like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloEvento CarregaModeloEvento(int codigo)
        {

            ModeloEvento evento = new ModeloEvento();

            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conexao.ObjetoConexao;
            cmd1.CommandText = "SELECT MATRICULA.COD_EVENTO FROM MATRICULA WHERE COD_MATRICULA = @fk_end";
            cmd1.Parameters.AddWithValue("@fk_end", codigo);
            conexao.Conectar();
            codigo = Convert.ToInt32(cmd1.ExecuteScalar());
            conexao.Desconectar();



            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select  *from EVENTO  where COD_EVENTO = @COD_EVENTO";
            cmd.Parameters.AddWithValue("@COD_EVENTO", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                evento.COD_EVENTO = Convert.ToInt32(registro["COD_EVENTO"]);
                evento.NOME = Convert.ToString(registro["NOME"]);
                evento.VALOR = Convert.ToDouble(registro["VALOR"]);

            }
            conexao.Desconectar();
            return evento;
        }
    }
}
