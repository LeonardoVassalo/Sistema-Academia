using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloPeriodo
    {
        public ModeloPeriodo()
        {
            this.COD_PERIODO = 0;
            this.NOME = "";
        }   

        // Metodo construtor inicializa as propriedades com dados fornecidos pelo usuario
        public ModeloPeriodo(int cod_aluno, String nome)
        {
            this.COD_PERIODO = cod_aluno;
            this.NOME = nome;
            
        }
        public int COD_PERIODO { get; set; }

        public String NOME { get; set; }

    }
}
