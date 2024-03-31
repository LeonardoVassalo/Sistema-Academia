using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{

    public class ModeloUsuario
    {
        // metodo construtor que inicializa todas minhas variavel

        public ModeloUsuario()
        {
            this.COD_USUARIO = 0;
            this.NOME = "";
            this.USUARIO = "";
            this.SENHA = "";
            this.CONF_SENHA = "";
            
        }

        // Metodo construtor inicializa as propriedades com dados fornecidos pelo usuario
        public ModeloUsuario(int cod_usuario, String nome, String usuario, String senha, String conf_senha)
        {
            this.COD_USUARIO = cod_usuario;
            this.NOME = nome;
            this.USUARIO = usuario;
            this.SENHA = senha;
            this.CONF_SENHA = conf_senha;
      
        }
        public int COD_USUARIO { get; set; }

        public String NOME { get; set; }

        public String USUARIO { get; set; }

        public String SENHA { get; set; }

        public String CONF_SENHA { get; set; }



    }
}
