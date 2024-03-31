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
    public class DALCadastroEndereço
    {
        private DALConexao conexao;
        public DALCadastroEndereço(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloEndereco endereco)
           
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into ENDERECO(ENDERECO, NUMERO, COMPLEMENTO, CIDADE, UF, CEP, BAIRRO) values (@ENDERECO, @NUMERO, @COMPLEMENTO, @CIDADE, @UF, @CEP, @BAIRRO); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@ENDERECO", endereco.ENDERECO);
            cmd.Parameters.AddWithValue("@NUMERO", endereco.NUMERO);
            cmd.Parameters.AddWithValue("@COMPLEMENTO", endereco.COMPLEMENTO);
            cmd.Parameters.AddWithValue("@CIDADE", endereco.CIDADE);
            cmd.Parameters.AddWithValue("@UF", endereco.UF);
            cmd.Parameters.AddWithValue("@CEP", endereco.CEP);
            cmd.Parameters.AddWithValue("@BAIRRO", endereco.BAIRRO);
            conexao.Conectar();
            endereco.COD_ENDERECO = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();


        }
         
        public void Alterar(ModeloEndereco endereco)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update ENDERECO set ENDERECO = @ENDERECO, NUMERO = @NUMERO, COMPLEMENTO = @COMPLEMENTO, CIDADE = @CIDADE, UF = @UF, CEP = @CEP, BAIRRO = @BAIRRO where COD_ENDERECO = @COD_ENDERECO select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@ENDERECO", endereco.ENDERECO);
            cmd.Parameters.AddWithValue("@NUMERO", endereco.NUMERO);
            cmd.Parameters.AddWithValue("@COMPLEMENTO", endereco.COMPLEMENTO);
            cmd.Parameters.AddWithValue("@CIDADE", endereco.CIDADE);
            cmd.Parameters.AddWithValue("@UF", endereco.UF);
            cmd.Parameters.AddWithValue("@CEP", endereco.CEP);
            cmd.Parameters.AddWithValue("@BAIRRO", endereco.BAIRRO);
            cmd.Parameters.AddWithValue("@COD_ENDERECO", endereco.COD_ENDERECO);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from ENDERECO where COD_ENDERECO = @COD_ENDERECO;";
            cmd.Parameters.AddWithValue("@COD_ENDERECO", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select COD_MATRICULA, NOME, RG, CPF, TELEFONE, BAIRRO FROM CADASTRO_ALUNO INNER JOIN MATRICULA ON CADASTRO_ALUNO.COD_ALUNO = MATRICULA.COD_MATRICULA INNER JOIN ENDERECO ON CADASTRO_ALUNO.COD_ALUNO = ENDERECO.COD_ENDERECO where BAIRRO like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloEndereco CarregaModeloEndereco(int codigo)
        {
            ModeloEndereco endereco = new ModeloEndereco();
            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conexao.ObjetoConexao;
            cmd1.CommandText = "SELECT CADASTRO_ALUNO.COD_ENDERECO FROM CADASTRO_ALUNO WHERE COD_ALUNO = @fk_end";
            cmd1.Parameters.AddWithValue("@fk_end", codigo);
            conexao.Conectar();
            codigo = Convert.ToInt32(cmd1.ExecuteScalar());
            conexao.Desconectar();


            
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from ENDERECO where COD_ENDERECO = @COD_ENDERECO";
            cmd.Parameters.AddWithValue("@COD_ENDERECO", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                endereco.COD_ENDERECO = Convert.ToInt32(registro["COD_ENDERECO"]);
                endereco.ENDERECO = Convert.ToString(registro["ENDERECO"]);
                endereco.NUMERO = Convert.ToInt32(registro["NUMERO"]);
                endereco.COMPLEMENTO= Convert.ToString(registro["COMPLEMENTO"]);
                endereco.CEP = Convert.ToString(registro["CEP"]);
                endereco.CIDADE = Convert.ToString(registro["CIDADE"]);
                endereco.BAIRRO = Convert.ToString(registro["BAIRRO"]);
                endereco.UF = Convert.ToString(registro["UF"]);

            }
            conexao.Desconectar();
            return endereco;
        }
        public ModeloEndereco CarregaModeloEnderecoProfessor(int codigo)
        {
            ModeloEndereco endereco = new ModeloEndereco();
            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conexao.ObjetoConexao;
            cmd1.CommandText = "SELECT PROFESSOR.COD_ENDERECO FROM PROFESSOR WHERE COD_PROF = @fk_end";
            cmd1.Parameters.AddWithValue("@fk_end", codigo);
            conexao.Conectar();
            codigo = Convert.ToInt32(cmd1.ExecuteScalar());
            conexao.Desconectar();




            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from ENDERECO where COD_ENDERECO = @COD_ENDERECO";
            cmd.Parameters.AddWithValue("@COD_ENDERECO", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                endereco.COD_ENDERECO = Convert.ToInt32(registro["COD_ENDERECO"]);
                endereco.ENDERECO = Convert.ToString(registro["ENDERECO"]);
                endereco.NUMERO = Convert.ToInt32(registro["NUMERO"]);
                endereco.COMPLEMENTO = Convert.ToString(registro["COMPLEMENTO"]);
                endereco.CEP = Convert.ToString(registro["CEP"]);
                endereco.CIDADE = Convert.ToString(registro["CIDADE"]);
                endereco.BAIRRO = Convert.ToString(registro["BAIRRO"]);
                endereco.UF = Convert.ToString(registro["UF"]);

            }
            conexao.Desconectar();
            return endereco;
        }
    }
}

