using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MODELO;
using System.Data;

namespace DAL
{

    public class DALCadastroAluno
    {
        private DALConexao conexao;
        public DALCadastroAluno(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCadastroAluno cadastro, ModeloEndereco endereco)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;

            cmd.CommandText = "insert into CADASTRO_ALUNO (NOME, RG, CPF, DATA_NASC, TELEFONE, COD_ENDERECO, PERIODO) values (@NOME, @RG, @CPF, @DATA_NASC, @TELEFONE, @COD_ENDERECO, @PERIODO);select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@NOME", cadastro.NOME);
            cmd.Parameters.AddWithValue("@RG", cadastro.RG);
            cmd.Parameters.AddWithValue("@CPF", cadastro.CPF);
            cmd.Parameters.AddWithValue("@DATA_NASC", cadastro.DATA_NASC);
            cmd.Parameters.AddWithValue("@TELEFONE", cadastro.TELEFONE);
            cmd.Parameters.AddWithValue("@COD_ENDERECO",endereco.COD_ENDERECO);
            cmd.Parameters.AddWithValue("@PERIODO", cadastro.PERIODO);

            conexao.Conectar();
            cadastro.COD_ALUNO = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloCadastroAluno cadastro)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update CADASTRO_ALUNO set NOME = @NOME, RG = @RG, CPF = @CPF, TELEFONE = @TELEFONE, DATA_NASC = @DATA_NASC, PERIODO = @PERIODO where COD_ALUNO = @COD_ALUNO;";
          
            cmd.Parameters.AddWithValue("@NOME", cadastro.NOME);
            cmd.Parameters.AddWithValue("@RG", cadastro.RG);
            cmd.Parameters.AddWithValue("@CPF", cadastro.CPF);
            cmd.Parameters.AddWithValue("@DATA_NASC", cadastro.DATA_NASC);
            cmd.Parameters.AddWithValue("@TELEFONE", cadastro.TELEFONE);
            cmd.Parameters.AddWithValue("@PERIODO", cadastro.PERIODO);
            cmd.Parameters.AddWithValue("@COD_ALUNO", cadastro.COD_ALUNO);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from CADASTRO_ALUNO where COD_ALUNO = @COD_ALUNO;";
            cmd.Parameters.AddWithValue("@COD_ALUNO", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select COD_MATRICULA, NOME, RG, CPF, TELEFONE, PERIODO FROM CADASTRO_ALUNO INNER JOIN MATRICULA ON CADASTRO_ALUNO.COD_ALUNO = MATRICULA.COD_MATRICULA where NOME like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarRg(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select COD_MATRICULA, NOME, RG, CPF, TELEFONE, PERIODO FROM CADASTRO_ALUNO INNER JOIN MATRICULA ON CADASTRO_ALUNO.COD_ALUNO = MATRICULA.COD_MATRICULA where RG like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
   
        public DataTable LocalizarPeriodo(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select COD_MATRICULA, NOME, RG, CPF, TELEFONE, PERIODO FROM CADASTRO_ALUNO INNER JOIN MATRICULA ON CADASTRO_ALUNO.COD_ALUNO = MATRICULA.COD_MATRICULA where PERIODO like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloCadastroAluno CarregaModeloCadastroAluno(int codigo)
        {
            
            ModeloCadastroAluno cadastro = new ModeloCadastroAluno();
            ModeloEndereco endereco = new ModeloEndereco();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select  *from CADASTRO_ALUNO  where COD_ALUNO = @COD_ALUNO";
            cmd.Parameters.AddWithValue("@COD_ALUNO", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                cadastro.COD_ALUNO = Convert.ToInt32(registro["COD_ALUNO"]);
                cadastro.NOME = Convert.ToString(registro["NOME"]);
                cadastro.RG = Convert.ToString(registro["RG"]);
                cadastro.TELEFONE = Convert.ToString(registro["TELEFONE"]);
                cadastro.CPF = Convert.ToString(registro["CPF"]);
                cadastro.DATA_NASC = Convert.ToString(registro["DATA_NASC"]);
                endereco.COD_ENDERECO = Convert.ToInt32(registro["COD_ENDERECO"]);
                cadastro.PERIODO= Convert.ToString(registro["PERIODO"]);
            }
            conexao.Desconectar();
            return cadastro;
        }
    }
}
    

   

