using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloMatricula

    {
        // metodo construtor que inicializa todas minhas variavel

        public ModeloMatricula()
        {
            this.COD_MATRICULA = 0;
            this.DATA_MATRICULA = "";
            this.DATA_VENC = "";
            this.COD_ALUNO = 0;
            this.COD_EVENTO = 0;
            
        }

        // Metodo construtor inicializa as propriedades com dados fornecidos pelo usuario
        public ModeloMatricula(int cod_matricula, String data_matricula, String data_venc, int cod_aluno)
        {
            this.COD_MATRICULA = cod_matricula;
            this.DATA_MATRICULA = data_matricula;
            this.DATA_VENC = data_venc;
            this.COD_ALUNO = cod_aluno;
        }

        public int COD_MATRICULA { get; set; }

        public String DATA_MATRICULA { get; set; }

        public String DATA_VENC { get; set; }

        public int COD_ALUNO { get; set; }
        public int COD_FREQ { get; set; }
        public int COD_EVENTO { get; set; }
        public int COD_PROFESSOR { get; set; }

    }
}
