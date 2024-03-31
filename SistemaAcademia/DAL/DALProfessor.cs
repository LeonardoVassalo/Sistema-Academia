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
    public class DALProfessor
    {
        private DALConexao conexao;
        public DALProfessor(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloProfessor professor, ModeloEndereco endereco)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;

            cmd.CommandText = "insert into PROFESSOR (NOME, RG, CPF, DATA_NASC, TELEFONE, COD_ENDERECO, PERIODO) values (@NOME, @RG, @CPF, @DATA_NASC, @TELEFONE, @COD_ENDERECO, @PERIODO);select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@NOME", professor.NOME);
            cmd.Parameters.AddWithValue("@RG", professor.RG);
            cmd.Parameters.AddWithValue("@CPF", professor.CPF);
            cmd.Parameters.AddWithValue("@DATA_NASC", professor.DATA_NASC);
            cmd.Parameters.AddWithValue("@TELEFONE", professor.TELEFONE);
            cmd.Parameters.AddWithValue("@COD_ENDERECO", endereco.COD_ENDERECO);
            cmd.Parameters.AddWithValue("@PERIODO", professor.PERIODO);
            conexao.Conectar();
            professor.COD_PROF = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloProfessor professor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update PROFESSOR set NOME = @NOME, RG = @RG, CPF = @CPF, TELEFONE = @TELEFONE, DATA_NASC = @DATA_NASC, PERIODO = @PERIODO where COD_PROF = @COD_PROF;";

            cmd.Parameters.AddWithValue("@NOME", professor.NOME);
            cmd.Parameters.AddWithValue("@RG", professor.RG);
            cmd.Parameters.AddWithValue("@CPF", professor.CPF);
            cmd.Parameters.AddWithValue("@DATA_NASC", professor.DATA_NASC);
            cmd.Parameters.AddWithValue("@TELEFONE", professor.TELEFONE);
            cmd.Parameters.AddWithValue("@PERIODO", professor.PERIODO);
            cmd.Parameters.AddWithValue("@COD_PROF", professor.COD_PROF);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from PROFESSOR where COD_PROF = @COD_PROF;";
            cmd.Parameters.AddWithValue("@COD_PROF", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select COD_PROF, NOME, RG, CPF, TELEFONE, PERIODO, ENDERECO FROM PROFESSOR INNER JOIN ENDERECO ON PROFESSOR.COD_ENDERECO = ENDERECO.COD_ENDERECO where COD_PROF like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarNome(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select COD_PROF, NOME, RG, CPF, TELEFONE, PERIODO, ENDERECO FROM PROFESSOR INNER JOIN ENDERECO ON PROFESSOR.COD_ENDERECO = ENDERECO.COD_ENDERECO where NOME like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarPeriodo(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select COD_PROF, NOME, RG, CPF, TELEFONE, PERIODO, ENDERECO FROM PROFESSOR INNER JOIN ENDERECO ON PROFESSOR.COD_ENDERECO = ENDERECO.COD_ENDERECO where PERIODO like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloProfessor CarregaModeloProfessor(int codigo)
        {

            ModeloProfessor professor = new ModeloProfessor();
            ModeloEndereco endereco = new ModeloEndereco();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select  *from PROFESSOR  where COD_PROF = @COD_PROF";
            cmd.Parameters.AddWithValue("@COD_PROF", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                professor.COD_PROF = Convert.ToInt32(registro["COD_PROF"]);
                professor.NOME = Convert.ToString(registro["NOME"]);
                professor.RG = Convert.ToString(registro["RG"]);
                professor.TELEFONE = Convert.ToString(registro["TELEFONE"]);
                professor.CPF = Convert.ToString(registro["CPF"]);
                professor.DATA_NASC = Convert.ToString(registro["DATA_NASC"]);
                endereco.COD_ENDERECO = Convert.ToInt32(registro["COD_ENDERECO"]);
                professor.PERIODO = Convert.ToString(registro["PERIODO"]);
            }
            conexao.Desconectar();
            return professor;
        }
    }
}
