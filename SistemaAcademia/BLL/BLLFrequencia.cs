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
    public class BLLFrequencia
    {
        private DALConexao conexao;
        public BLLFrequencia(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFrequencia frequencia, ModeloMatricula matricula)
        {
                    
            DALFrequencia dalFrequencia = new DALFrequencia(conexao);
            dalFrequencia.Incluir(frequencia, matricula);
         
        }

        public void Alterar(ModeloFrequencia frequencia)
        {

           
            DALFrequencia dalFrequencia = new DALFrequencia(conexao);
            dalFrequencia.Alterar(frequencia);
        }

        public void Excluir(int codigo)
        {
            DALFrequencia dalFrequencia = new DALFrequencia(conexao);
            dalFrequencia.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALFrequencia dalFrequencia = new DALFrequencia(conexao);
            return dalFrequencia.Localizar(valor);
        }

        public DataTable LocalizarIm(String valor)
        {
            DALFrequencia dalFrequencia = new DALFrequencia(conexao);
            return dalFrequencia.LocalizarIm(valor);
        }
        public ModeloFrequencia CarregaModeloFrequencia(int codigo, int cod)
        {
            DALFrequencia dalFrequencia = new DALFrequencia(conexao);
            return dalFrequencia.CarregaModeloFrequencia(codigo, cod);
        }

      
    }
}
