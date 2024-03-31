using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using System.Data;

namespace BLL
{
    public  class BLLProfessor
    {
        private DALConexao conexao;
        public BLLProfessor(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloProfessor professor, ModeloEndereco endereco)
        {
            if (professor.NOME.Trim().Length == 0)
            {
                throw new Exception("O Nome do Professor é Obrigatorio");
            }
            if (professor.RG.Trim().Length != 12)
            {
                throw new Exception("Numero do RG invalido");
            }
            if (professor.CPF.Trim().Length != 14)
            {
                throw new Exception("Numero do CPF invalido");
            }
            if (professor.TELEFONE.Trim().Length != 14)
            {
                throw new Exception("Telefone Invalido");
            }
            if (professor.DATA_NASC.Trim().Length != 10)
            {
                throw new Exception("A Data de Nascimento é  invalida");
            }
            if (professor.PERIODO.Trim().Length == 0)
            {
                throw new Exception("O Periodo do Professor é Obrigatorio");
            }
            if (endereco.ENDERECO.Trim().Length == 0)
            {
                throw new Exception("O Endereço do Professor é Obrigatorio");
            }
            if (endereco.NUMERO <= 0)
            {
                throw new Exception("O Numero do Endereço é Obrigatorio");
            }
            if (endereco.CIDADE.Trim().Length == 0)
            {
                throw new Exception("A cidade do Professor é Obrigatorio");
            }
            if (endereco.BAIRRO.Trim().Length == 0)
            {
                throw new Exception("O Bairro do Professor é Obrigatorio");
            }
            if (endereco.CEP.Trim().Length != 9)
            {
                throw new Exception("O CEP é invalido");
            }
            if (endereco.UF.Trim().Length != 2)
            {
                throw new Exception("UF Invalido");
            }

            professor.NOME = professor.NOME.ToUpper();
            professor.RG = professor.RG.ToUpper();
            professor.CPF = professor.CPF.ToUpper();
            professor.TELEFONE = professor.TELEFONE.ToUpper();
            professor.DATA_NASC = professor.DATA_NASC.ToUpper();

            endereco.ENDERECO = endereco.ENDERECO.ToUpper();
            endereco.COMPLEMENTO = endereco.COMPLEMENTO.ToUpper();
            endereco.CIDADE = endereco.CIDADE.ToUpper();
            endereco.BAIRRO = endereco.BAIRRO.ToUpper();
            endereco.CEP = endereco.CEP.ToUpper();
            endereco.UF = endereco.UF.ToUpper();

            DALCadastroEndereço dalEndereco = new DALCadastroEndereço(conexao);
            dalEndereco.Incluir(endereco);

            DALProfessor dalProfessor = new DALProfessor(conexao);
            dalProfessor.Incluir(professor, endereco);
         }
        public void Alterar(ModeloProfessor professor)
        {

            if (professor.NOME.Trim().Length == 0)
            {
                throw new Exception("O Nome do Professor é Obrigatorio");
            }
            if (professor.RG.Trim().Length != 12)
            {
                throw new Exception("Numero do RG invalido");
            }
            if (professor.CPF.Trim().Length != 14)
            {
                throw new Exception("Numero do CPF invalido");
            }
            if (professor.TELEFONE.Trim().Length != 14)
            {
                throw new Exception("Telefone Invalido");
            }
            if (professor.DATA_NASC.Trim().Length != 10)
            {
                throw new Exception("A Data de Nascimento é  invalida");
            }
            if (professor.PERIODO.Trim().Length == 0)
            {
                throw new Exception("O Periodo do Professor é Obrigatorio");
            }
            professor.NOME = professor.NOME.ToUpper();
            professor.RG = professor.RG.ToUpper();
            professor.CPF = professor.CPF.ToUpper();
            professor.TELEFONE = professor.TELEFONE.ToUpper();
            professor.DATA_NASC = professor.DATA_NASC.ToUpper();
            

            DALProfessor dalProfessor = new DALProfessor(conexao);
            dalProfessor.Alterar(professor);

        }
        public void Excluir(int codigo)
        {
            DALProfessor dalProfessor = new DALProfessor(conexao);
            dalProfessor.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALProfessor dalProfessor = new DALProfessor(conexao);
            return dalProfessor.Localizar(valor);
        }
        public DataTable LocalizarNome(String valor)
        {
            DALProfessor dalProfessor = new DALProfessor(conexao);
            return dalProfessor.LocalizarNome(valor);
        }
        public DataTable LocalizarPeriodo(String valor)
        {
            DALProfessor dalProfessor = new DALProfessor(conexao);
            return dalProfessor.LocalizarPeriodo(valor);
        }
        public ModeloProfessor CarregaModeloProfessor(int codigo)
        {
            DALProfessor dalProfessor = new DALProfessor(conexao);
            return dalProfessor.CarregaModeloProfessor(codigo);
        }
    }
}
