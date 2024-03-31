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
    public class BLLUsuario
    {
        private DALConexao conexao;
        public BLLUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUsuario usuario)
        {
            if (usuario.NOME.Trim().Length == 0)
            {
                throw new Exception("O Nome é Obrigatorio");
            }
            if (usuario.USUARIO.Trim().Length == 0)
            {
                throw new Exception("O Usuario é Obrigatorio");
            }
            if (usuario.SENHA.Trim().Length == 0)
            {
                throw new Exception("A senha é Obrigatorio");
            }
            if (usuario.CONF_SENHA.Trim().Length == 0)
            {
                throw new Exception("A Confirmação da senha é obrigatoria");
            }
            if (usuario.SENHA != usuario.CONF_SENHA)
            {
                throw new Exception("A senhas são diferentes ");
            }


            usuario.NOME = usuario.NOME.ToUpper();
            usuario.USUARIO = usuario.USUARIO.ToUpper();
            usuario.SENHA = usuario.SENHA.ToUpper();
            usuario.CONF_SENHA = usuario.CONF_SENHA.ToUpper();

            DALUsuario dal = new DALUsuario(conexao);
            dal.Incluir(usuario);

        }

        public void Alterar(ModeloUsuario usuario)
        {

            if (usuario.NOME.Trim().Length == 0)
            {
                throw new Exception("O Nome é Obrigatorio");
            }
            if (usuario.USUARIO.Trim().Length == 0)
            {
                throw new Exception("O Usuario é Obrigatorio");
            }
            if (usuario.SENHA.Trim().Length == 0)
            {
                throw new Exception("A senha é Obrigatorio");
            }
            if (usuario.CONF_SENHA.Trim().Length == 0)
            {
                throw new Exception("A Confirmação da senha é obrigatoria");
            }

            if (usuario.SENHA != usuario.CONF_SENHA)
            {
                throw new Exception("A senhas são diferentes ");
            }

            usuario.NOME = usuario.NOME.ToUpper();
            usuario.USUARIO = usuario.USUARIO.ToUpper();
            usuario.SENHA = usuario.SENHA.ToUpper();
            usuario.CONF_SENHA = usuario.CONF_SENHA.ToUpper();

            DALUsuario dal = new DALUsuario(conexao);
            dal.Alterar(usuario);

        }

        public void Excluir(int codigo)
        {
            DALUsuario dal = new DALUsuario(conexao);
            dal.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALUsuario dal = new DALUsuario(conexao);
            return dal.Localizar(valor);
        }

        public DataTable LocalizarUsu(String valor)
        {
            DALUsuario dal = new DALUsuario(conexao);
            return dal.LocalizarUsu(valor);
        }
        public ModeloUsuario CarregaModeloUsuario(int codigo)
        {
            DALUsuario dal = new DALUsuario(conexao);
            return dal.CarregaModeloUsuario(codigo);
        }
    }
}
