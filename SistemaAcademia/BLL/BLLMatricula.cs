using DAL;
using MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLMatricula
    {
        private DALConexao conexao;
        public BLLMatricula(DALConexao cx)
        {
            this.conexao = cx;
        }
       public void Incluir(ModeloMatricula matricula, ModeloCadastroAluno cadastro, ModeloEvento evento, ModeloProfessor professor)
        {
          
            if (matricula.DATA_VENC.Trim().Length != 10)
            {
                throw new Exception("A data do Vencimento está incorreta");
            }

            DALMatricula dalMatricula = new DALMatricula(conexao);
            dalMatricula.Incluir(matricula, cadastro, evento, professor);
        }
        public void Alterar(ModeloMatricula matricula)
        {
            if (matricula.DATA_MATRICULA.Trim().Length == 0)
            {
                throw new Exception("a Data da Matricula Aluno é Obrigatorio");
            }
            if (matricula.DATA_VENC.Trim().Length == 0)
            {
                throw new Exception("A data do Vencimento é Obrigatorio");
            }

            

            DALMatricula dalMatricula = new DALMatricula(conexao);
            dalMatricula.Alterar(matricula);
        }
        public void Excluir(int codigo)
        {
            DALMatricula dalMatricula = new DALMatricula(conexao);
            dalMatricula.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALMatricula dalMatricula = new DALMatricula(conexao);
            return dalMatricula.Localizar(valor);
        }
        public DataTable Localizarpf(String valor)
        {
            DALMatricula dalMatricula = new DALMatricula(conexao);
            return dalMatricula.Localizarpf(valor);
        }
        public ModeloMatricula CarregaModeloMatricula(int codigo)
        {
            DALMatricula dalMatricula = new DALMatricula(conexao);
            return dalMatricula.CarregaModeloMatricula(codigo);
        }



    }
}
