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
    public class DALUsuario
    {
        private DALConexao conexao;
        public DALUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUsuario usuario)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;

            cmd.CommandText = "insert into USUARIO (NOME, USUARIO, SENHA, CONF_SENHA) values (@NOME, @USUARIO, @SENHA, @CONF_SENHA);select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@NOME", usuario.NOME);
            cmd.Parameters.AddWithValue("@USUARIO", usuario.USUARIO);
            cmd.Parameters.AddWithValue("@SENHA", usuario.SENHA);
            cmd.Parameters.AddWithValue("@CONF_SENHA", usuario.CONF_SENHA);
         
            conexao.Conectar();
            usuario.COD_USUARIO = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloUsuario usuario)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update USUARIO set NOME = @NOME, USUARIO = @USUARIO, SENHA = @SENHA, CONF_SENHA = @CONF_SENHA where COD_USUARIO = @COD_USUARIO;";

            cmd.Parameters.AddWithValue("@NOME", usuario.NOME);
            cmd.Parameters.AddWithValue("@USUARIO", usuario.USUARIO);
            cmd.Parameters.AddWithValue("@SENHA", usuario.SENHA);
            cmd.Parameters.AddWithValue("@CONF_SENHA", usuario.CONF_SENHA);
            cmd.Parameters.AddWithValue("@COD_USUARIO", usuario.COD_USUARIO);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from USUARIO where COD_USUARIO = @COD_USUARIO;";
            cmd.Parameters.AddWithValue("@COD_USUARIO", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select COD_USUARIO, NOME, USUARIO FROM USUARIO where NOME like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarUsu(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select COD_USUARIO, NOME, USUARIO FROM USUARIO where USUARIO like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloUsuario CarregaModeloUsuario(int codigo)
        {

            ModeloUsuario usuario = new ModeloUsuario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select  *from USUARIO  where COD_USUARIO = @COD_USUARIO";
            cmd.Parameters.AddWithValue("@COD_USUARIO", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                usuario.COD_USUARIO = Convert.ToInt32(registro["COD_USUARIO"]);
                usuario.NOME = Convert.ToString(registro["NOME"]);
                usuario.USUARIO = Convert.ToString(registro["USUARIO"]);
                usuario.SENHA = Convert.ToString(registro["SENHA"]);
                usuario.CONF_SENHA = Convert.ToString(registro["CONF_SENHA"]);

            }
            conexao.Desconectar();
            return usuario;
        }      
    }
}    
