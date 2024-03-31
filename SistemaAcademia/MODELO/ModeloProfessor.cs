using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloProfessor
    {
        // metodo construtor que inicializa todas minhas variavel

        public ModeloProfessor()
        {
            this.COD_PROF = 0;
            this.NOME = "";
            this.RG = "";
            this.TELEFONE = "";
            this.CPF = "";
            this.DATA_NASC = "";
            this.COD_ENDERECO = 0;
            this.PERIODO = "";
        }

        // Metodo construtor inicializa as propriedades com dados fornecidos pelo usuario
        public ModeloProfessor(int cod_prof, String nome, String rg, String telefone, String cpf, String data_nasc, int cod_endereco, String periodo)
        {
            this.COD_PROF = cod_prof;
            this.NOME = nome;
            this.RG = rg;
            this.TELEFONE = telefone;
            this.CPF = cpf;
            this.DATA_NASC = data_nasc;
            this.PERIODO = periodo;
            this.COD_ENDERECO = cod_endereco;
        }
        public int COD_PROF { get; set; }
        public String NOME { get; set; }
        public String RG { get; set; }
        public String CPF { get; set; }
        public String DATA_NASC { get; set; }
        public String TELEFONE { get; set; }
        public String PERIODO { get; set; }
        public int COD_ENDERECO { get; set; }



    }
}
