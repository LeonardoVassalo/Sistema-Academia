using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloEndereco
    {
        // metodo construtor que inicializa todas minhas variavel

        public ModeloEndereco()
        {
            this.COD_ENDERECO = 0;
            this.ENDERECO = "";
            this.NUMERO = 0;
            this.COMPLEMENTO = "";
            this.CIDADE = "";
            this.UF = "";
            this.CEP = "";
            this.BAIRRO = "";

        }

        // Metodo construtor inicializa as propriedades com dados fornecidos pelo usuario
        public ModeloEndereco(int cod_endereco, String endereco, int numero, String complemento, String cidade, String uf, String cep, String bairro)
        {
            this.COD_ENDERECO = cod_endereco;
            this.ENDERECO = endereco;
            this.NUMERO = numero;
            this.COMPLEMENTO = complemento;
            this.CIDADE = cidade;
            this.UF = uf;
            this.CEP = cep;
            this.BAIRRO = bairro;
        }
        public int COD_ENDERECO { get; set; }

        public String ENDERECO { get; set; }

        public int NUMERO { get; set; }

        public String COMPLEMENTO { get; set; }

        public String CIDADE { get; set; }

        public String UF { get; set; }

        public String CEP { get; set; }

        public String BAIRRO { get; set; }

    }
}
