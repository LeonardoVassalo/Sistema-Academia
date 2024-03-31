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
    public class BLLEvento
    {
        private DALConexao conexao;
        public BLLEvento(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloEvento evento)
        {
            if (evento.NOME.Trim().Length == 0)
            {
                throw new Exception("O Nome do Plano é Obrigatorio");
            }
            if (evento.VALOR <=0)
            {
                throw new Exception("O Valor é Obrigatorio");
            }
          
            evento.NOME = evento.NOME.ToUpper();

            DALEvento dal = new DALEvento(conexao);
            dal.Incluir(evento);

        }

        public void Alterar(ModeloEvento evento)
        {

            if (evento.NOME.Trim().Length == 0)
            {
                throw new Exception("O Evento é Obrigatorio");
            }
            if (evento.VALOR <= 0)
            {
                throw new Exception("O Valor é Obrigatorio");
            }
            evento.NOME = evento.NOME.ToUpper();

            DALEvento dal = new DALEvento(conexao);
            dal.Alterar(evento);
        }

        public void Excluir(int codigo)
        {
            DALEvento dal = new DALEvento(conexao);
            dal.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALEvento dal = new DALEvento(conexao);
            return dal.Localizar(valor);
        }

        public ModeloEvento CarregaModeloEvento(int codigo)
        {
            DALEvento dal = new DALEvento(conexao);
            return dal.CarregaModeloEvento(codigo);
        }
    }
}
