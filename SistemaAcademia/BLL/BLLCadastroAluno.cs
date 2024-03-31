using DAL;
using MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCadastroAluno
    {
         private DALConexao conexao;
         public BLLCadastroAluno(DALConexao cx)
         {
             this.conexao = cx;
         }

         public void Incluir(ModeloCadastroAluno cadastro, ModeloEndereco endereco)
         {
             if (cadastro.NOME.Trim().Length == 0)
             {
                 throw new Exception("O Nome do Aluno é Obrigatorio");
             }
             if (cadastro.RG.Trim().Length != 12)
             {
                 throw new Exception("Numero do RG invalido");
             }
             if (cadastro.CPF.Trim().Length != 14)
             {
                 throw new Exception("Numero do CPF invalido");
             }
             if (cadastro.TELEFONE.Trim().Length != 14)
             {
                 throw new Exception("Telefone Invalido");
             }
             if (cadastro.DATA_NASC.Trim().Length != 10)
             {
                 throw new Exception("A Data de Nascimento é  invalida");
             }
            if (cadastro.PERIODO.Trim().Length == 0)
            {
                throw new Exception("O Periodo do Aluno é Obrigatorio");
            }
            if (endereco.ENDERECO.Trim().Length == 0)
            {
                throw new Exception("O Endereço do Aluno é Obrigatorio");
            }
            if (endereco.NUMERO <= 0)
            {
                throw new Exception("O Numero do Endereço é Obrigatorio");
            }
            if (endereco.CIDADE.Trim().Length == 0)
            {
                throw new Exception("A cidade do Aluno é Obrigatorio");
            }
            if (endereco.BAIRRO.Trim().Length == 0)
            {
                throw new Exception("O Bairro do Aluno é Obrigatorio");
            }
            if (endereco.CEP.Trim().Length != 9)
            {
                throw new Exception("O CEP é invalido");
            }
            if (endereco.UF.Trim().Length != 2)
            {
                throw new Exception("UF Invalido");
            }

            cadastro.NOME = cadastro.NOME.ToUpper();
             cadastro.RG = cadastro.RG.ToUpper();
             cadastro.CPF = cadastro.CPF.ToUpper();
             cadastro.TELEFONE = cadastro.TELEFONE.ToUpper();
             cadastro.DATA_NASC = cadastro.DATA_NASC.ToUpper();

            endereco.ENDERECO = endereco.ENDERECO.ToUpper();
            endereco.COMPLEMENTO = endereco.COMPLEMENTO.ToUpper();
            endereco.CIDADE = endereco.CIDADE.ToUpper();
            endereco.BAIRRO = endereco.BAIRRO.ToUpper();
            endereco.CEP = endereco.CEP.ToUpper();
            endereco.UF = endereco.UF.ToUpper();

            DALCadastroEndereço dalEndereco = new DALCadastroEndereço(conexao);
            dalEndereco.Incluir(endereco);

            DALCadastroAluno dalAluno = new DALCadastroAluno(conexao);
            dalAluno.Incluir(cadastro, endereco);


         }

         public void Alterar(ModeloCadastroAluno cadastro)
         {

            if (cadastro.NOME.Trim().Length == 0)
            {
                throw new Exception("O Nome do Aluno é Obrigatorio");
            }
            if (cadastro.RG.Trim().Length != 12)
            {
                throw new Exception("Numero do RG invalido");
            }
            if (cadastro.CPF.Trim().Length != 14)
            {
                throw new Exception("Numero do CPF invalido");
            }
            if (cadastro.TELEFONE.Trim().Length != 14)
            {
                throw new Exception("Telefone Invalido");
            }
            if (cadastro.DATA_NASC.Trim().Length != 10)
            {
                throw new Exception("A Data de Nascimento é  invalida");
            }
            if (cadastro.PERIODO.Trim().Length == 0)
            {
                throw new Exception("O Periodo do Aluno é Obrigatorio");
            }
            cadastro.NOME = cadastro.NOME.ToUpper();
             cadastro.RG = cadastro.RG.ToUpper();
             cadastro.CPF = cadastro.CPF.ToUpper();
             cadastro.TELEFONE = cadastro.TELEFONE.ToUpper();
             cadastro.DATA_NASC = cadastro.DATA_NASC.ToUpper();

             DALCadastroAluno dalAluno = new DALCadastroAluno(conexao);
             dalAluno.Alterar(cadastro);
         }

         public void Excluir(int codigo)
         {
             DALMatricula dalM = new DALMatricula(conexao);
             dalM.Excluir(codigo);
             DALCadastroAluno dalAluno = new DALCadastroAluno(conexao);
             dalAluno.Excluir(codigo);
         

         }
         public DataTable Localizar(String valor)
         {
             DALCadastroAluno dalAluno = new DALCadastroAluno(conexao);
            return dalAluno.Localizar(valor);
         }
        public DataTable LocalizarRg(String valor)
        {
            DALCadastroAluno dalAluno = new DALCadastroAluno(conexao);
            return dalAluno.LocalizarRg(valor);
        }
        public DataTable LocalizarPeriodo(String valor)
        {
            DALCadastroAluno dalAluno = new DALCadastroAluno(conexao);
            return dalAluno.LocalizarPeriodo(valor);
        }
        public ModeloCadastroAluno CarregaModeloCadastroAluno(int codigo)
         {
             DALCadastroAluno dalAluno = new DALCadastroAluno(conexao);
             return dalAluno.CarregaModeloCadastroAluno(codigo);
         }

     }
 }
    

