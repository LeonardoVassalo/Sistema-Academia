using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloEvento
    {
        public ModeloEvento()
        {
            this.COD_EVENTO = 0;
            this.NOME = "";
        }

        // Metodo construtor inicializa as propriedades com dados fornecidos pelo usuario
        public ModeloEvento(int cod_evento, String nome)
        {
            this.COD_EVENTO = cod_evento;
            this.NOME = nome;

        }
        public int COD_EVENTO { get; set; }
    
        public String NOME { get; set; }

        public Double VALOR { get; set; }
        

    }
}
