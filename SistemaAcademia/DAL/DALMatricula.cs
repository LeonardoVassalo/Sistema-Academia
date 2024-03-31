using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MODELO;

namespace DAL
{
    public class DALMatricula
    {
        private DALConexao conexao;
        public DALMatricula(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloMatricula matricula, ModeloCadastroAluno cadastro, ModeloEvento evento, ModeloProfessor professor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into MATRICULA(DATA_MATRICULA, DATA_VENC, COD_ALUNO, COD_EVENTO, COD_PROFESSOR) values (@DATA_MATRICULA, @DATA_VENC, @COD_ALUNO, @COD_EVENTO, @COD_PROFESSOR); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@DATA_MATRICULA", matricula.DATA_MATRICULA);
            cmd.Parameters.AddWithValue("@DATA_VENC", matricula.DATA_VENC);
            cmd.Parameters.AddWithValue("@COD_ALUNO", matricula.COD_ALUNO = Convert.ToInt32(cadastro.COD_ALUNO));
            cmd.Parameters.AddWithValue("@COD_EVENTO", evento.COD_EVENTO);
            cmd.Parameters.AddWithValue("@COD_PROFESSOR", professor.COD_PROF);
            conexao.Conectar();
            matricula.COD_MATRICULA = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloMatricula matricula)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update MATRICULA set DATA_MATRICULA = @DATA_MATRICULA, DATA_VENC = @DATA_VENC  where COD_MATRICULA = @COD_MATRICULA;";
            cmd.Parameters.AddWithValue("@DATA_MATRICULA", matricula.DATA_MATRICULA);
            cmd.Parameters.AddWithValue("@DATA_VENC", matricula.DATA_VENC);
            //cmd.Parameters.AddWithValue("@COD_ALUNO", matricula.COD_ALUNO = Convert.ToInt32(cadastro.COD_ALUNO));
           // cmd.Parameters.AddWithValue("@COD_EVENTO", evento.COD_EVENTO);
            cmd.Parameters.AddWithValue("@COD_MATRICULA", matricula.COD_MATRICULA );
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
         public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from MATRICULA where COD_MATRICULA = @COD_MATRICULA;";
            cmd.Parameters.AddWithValue("@COD_MATRICULA", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select COD_MATRICULA, DATA_MATRICULA, DATA_VENC, NOME, RG, TELEFONE, ENDERECO FROM MATRICULA INNER JOIN CADASTRO_ALUNO ON MATRICULA.COD_MATRICULA= CADASTRO_ALUNO.COD_ALUNO INNER JOIN ENDERECO ON CADASTRO_ALUNO.COD_ENDERECO = ENDERECO.COD_ENDERECO where COD_MATRICULA like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable Localizarpf(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select COD_MATRICULA, DATA_MATRICULA, DATA_VENC, NOME, RG, TELEFONE, ENDERECO FROM MATRICULA INNER JOIN CADASTRO_ALUNO ON MATRICULA.COD_MATRICULA= CADASTRO_ALUNO.COD_ALUNO INNER JOIN ENDERECO ON CADASTRO_ALUNO.COD_ENDERECO = ENDERECO.COD_ENDERECO where COD_PROFESSOR like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloMatricula CarregaModeloMatricula(int codigo)
        {
            ModeloMatricula matricula = new ModeloMatricula();
            ModeloCadastroAluno cadastro = new ModeloCadastroAluno();
            ModeloEvento evento = new ModeloEvento();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select *from MATRICULA where COD_MATRICULA = @COD_MATRICULA";
            cmd.Parameters.AddWithValue("@COD_MATRICULA", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                matricula.COD_MATRICULA = Convert.ToInt32(registro["COD_MATRICULA"]);
                matricula.DATA_MATRICULA = Convert.ToString(registro["DATA_MATRICULA"]);
                matricula.DATA_VENC= Convert.ToString(registro["DATA_VENC"]);

            


            }
            conexao.Desconectar();
            return matricula;
        }
    }
}
