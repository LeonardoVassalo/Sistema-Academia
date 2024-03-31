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
    public class DALFrequencia
    {
        private DALConexao conexao;
        public DALFrequencia(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFrequencia frequencia, ModeloMatricula matricula)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;

            cmd.CommandText = "insert into FREQUENCIA (DATA_FREQ, HORA_ENTRADA, COD_MATRICULA, HORA_SAIDA) values (@DATA_FREQ, @HORA_ENTRADA, @COD_MATRICULA, @HORA_SAIDA);select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@DATA_FREQ", frequencia.DATA_FREQ);
            cmd.Parameters.AddWithValue("@HORA_ENTRADA", frequencia.HORA_ENTRADA);
            cmd.Parameters.AddWithValue("@COD_MATRICULA", matricula.COD_MATRICULA);
            cmd.Parameters.AddWithValue("@HORA_SAIDA", frequencia.HORA_SAIDA);

            conexao.Conectar();
            frequencia.COD_FREQ = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloFrequencia frequencia)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update FREQUENCIA set DATA_FREQ = @DATA_FREQ, HORA_ENTRADA = @HORA_ENTRADA, HORA_SAIDA = @HORA_SAIDA where COD_FREQ = @COD_FREQ;";

            cmd.Parameters.AddWithValue("@DATA_FREQ", frequencia.DATA_FREQ);
            cmd.Parameters.AddWithValue("@HORA_ENTRADA", frequencia.HORA_ENTRADA);
            cmd.Parameters.AddWithValue("@HORA_SAIDA", frequencia.HORA_SAIDA);
            cmd.Parameters.AddWithValue("@COD_FREQ", frequencia.COD_FREQ);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from FREQUENCIA where COD_FREQ = @COD_FREQ;";
            cmd.Parameters.AddWithValue("@COD_FREQ", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public ModeloFrequencia CarregaModeloFrequencia(int codigo, int cod)
        {
            
            
            ModeloFrequencia frequencia = new ModeloFrequencia();
            ModeloMatricula matricula = new ModeloMatricula();

            SqlCommand cmd2 = new SqlCommand();
            
            cmd2.Connection = conexao.ObjetoConexao;
            cmd2.CommandText = "SELECT FREQUENCIA.COD_FREQ FROM FREQUENCIA WHERE COD_MATRICULA = @fk";
            cmd2.Parameters.AddWithValue("@fk", codigo);
            conexao.Conectar();
            cod = Convert.ToInt32(cmd2.ExecuteScalar());
            conexao.Desconectar();


            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conexao.ObjetoConexao;
            cmd1.CommandText = "SELECT FREQUENCIA.COD_FREQ FROM FREQUENCIA WHERE COD_FREQ = @fk_end";
            cmd1.Parameters.AddWithValue("@fk_end", codigo);
            conexao.Conectar();
            codigo = Convert.ToInt32(cmd1.ExecuteScalar());
            conexao.Desconectar();
            
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select  *from FREQUENCIA  where COD_FREQ = @COD_FREQ";
            cmd.Parameters.AddWithValue("@COD_FREQ", codigo);
         

            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                frequencia.COD_FREQ = Convert.ToInt32(registro["COD_FREQ"]);
                frequencia.DATA_FREQ = Convert.ToString(registro["DATA_FREQ"]);
                frequencia.HORA_ENTRADA = Convert.ToString(registro["HORA_ENTRADA"]);
                frequencia.HORA_SAIDA = Convert.ToString(registro["HORA_SAIDA"]);
                frequencia.COD_MATRICULA = Convert.ToInt32(registro["COD_MATRICULA"]);

            }
            conexao.Desconectar();
            return frequencia;

        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select COD_FREQ, MATRICULA.COD_MATRICULA, NOME, DATA_FREQ, HORA_ENTRADA, HORA_SAIDA, DATA_VENC FROM MATRICULA INNER JOIN FREQUENCIA ON FREQUENCIA.COD_MATRICULA = MATRICULA.COD_MATRICULA INNER JOIN CADASTRO_ALUNO ON CADASTRO_ALUNO.COD_ALUNO = MATRICULA.COD_MATRICULA where DATA_FREQ like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarIm(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select MATRICULA.COD_MATRICULA, CADASTRO_ALUNO.NOME, EVENTO.NOME FROM MATRICULA INNER JOIN CADASTRO_ALUNO ON CADASTRO_ALUNO.COD_ALUNO = MATRICULA.COD_MATRICULA INNER JOIN EVENTO ON MATRICULA.COD_EVENTO = EVENTO.COD_EVENTO where MATRICULA.COD_MATRICULA like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }





    }
}
