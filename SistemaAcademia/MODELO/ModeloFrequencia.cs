using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
   public  class ModeloFrequencia
    {
        // metodo construtor que inicializa todas minhas variavel

        public ModeloFrequencia()
        {
            this.COD_FREQ = 0;
           
        }

        // Metodo construtor inicializa as propriedades com dados fornecidos pelo usuario
        public ModeloFrequencia(int cod_freq)
        {
            this.COD_FREQ = cod_freq;
       
        }
        public int COD_FREQ { get; set; }

        public String DATA_FREQ { get; set; }

        public String HORA_ENTRADA { get; set; }

        public String HORA_SAIDA { get; set; }

        public int COD_MATRICULA { get; set; }
    }
}
