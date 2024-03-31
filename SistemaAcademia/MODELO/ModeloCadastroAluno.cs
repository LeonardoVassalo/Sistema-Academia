using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    
   
    public class ModeloCadastroAluno
    {
        // metodo construtor que inicializa todas minhas variavel

        public ModeloCadastroAluno()
        {
            this.COD_ALUNO = 0;
            this.NOME = "";
            this.RG = "";
            this.TELEFONE = "";
            this.CPF = "";
            this.DATA_NASC = "";
            this.COD_ENDEREÇO = 0;
            this.PERIODO = "";
        }

        // Metodo construtor inicializa as propriedades com dados fornecidos pelo usuario
        public ModeloCadastroAluno(int cod_aluno, String nome, String rg, String telefone, String cpf, String data_nasc, int cod_endereco, String periodo)
        {
            this.COD_ALUNO = cod_aluno;
            this.NOME = nome;
            this.RG = rg;
            this.TELEFONE = telefone;
            this.CPF = cpf;
            this.DATA_NASC = data_nasc;
            this.PERIODO = periodo;
            this.COD_ENDEREÇO = cod_endereco;
        }
        public int COD_ALUNO { get; set; }
        public String NOME { get; set; }
        public String RG { get; set; }
        public String CPF { get; set; }
        public String DATA_NASC{ get; set; }
        public String TELEFONE { get; set; }
        public int COD_ENDEREÇO { get; set; }
        public String PERIODO { get; set; }


    }
}
