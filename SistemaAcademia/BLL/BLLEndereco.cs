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
    public class BLLEndereco
    {
        private DALConexao conexao;
        public BLLEndereco (DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloEndereco endereco)
        {
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
            if (endereco.CEP.Trim().Length == 0)
            {
                throw new Exception("O CEP do Aluno é Obrigatorio");
            }
            if (endereco.UF.Trim().Length == 0)
            {
                throw new Exception("UF do Aluno é Obrigatorio");
            }
            endereco.ENDERECO = endereco.ENDERECO.ToUpper();
            endereco.COMPLEMENTO = endereco.COMPLEMENTO.ToUpper();
            endereco.CIDADE = endereco.CIDADE.ToUpper();
            endereco.BAIRRO = endereco.BAIRRO.ToUpper();
            endereco.CEP = endereco.CEP.ToUpper();
            endereco.UF = endereco.UF.ToUpper();



            DALCadastroEndereço dalEndereco = new DALCadastroEndereço(conexao);
            dalEndereco.Incluir(endereco);
        }
        public void Alterar(ModeloEndereco endereco)
        {
            if (endereco.COD_ENDERECO <= 0)

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
            endereco.ENDERECO = endereco.ENDERECO.ToUpper();
            endereco.COMPLEMENTO = endereco.COMPLEMENTO.ToUpper();
            endereco.CIDADE = endereco.CIDADE.ToUpper();
            endereco.BAIRRO = endereco.BAIRRO.ToUpper();
            endereco.CEP = endereco.CEP.ToUpper();
            endereco.UF = endereco.UF.ToUpper();

            DALCadastroEndereço dalEndereco = new DALCadastroEndereço(conexao);
            dalEndereco.Alterar(endereco);

        }
        public void Excluir(int codigo)
        {
            DALCadastroEndereço dalEndereco = new DALCadastroEndereço(conexao);
            dalEndereco.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALCadastroEndereço dalEndereco = new DALCadastroEndereço(conexao);
            return dalEndereco.Localizar(valor);
        }
        public ModeloEndereco CarregaModeloEndereco(int codigo)
        {
            DALCadastroEndereço dalEndereco = new DALCadastroEndereço(conexao);
            return dalEndereco.CarregaModeloEndereco(codigo);
        }
        public ModeloEndereco CarregaModeloEnderecoProfessor(int codigo)
        {
            DALCadastroEndereço dalEndereco = new DALCadastroEndereço(conexao);
            return dalEndereco.CarregaModeloEnderecoProfessor(codigo);
        }




    }
}
