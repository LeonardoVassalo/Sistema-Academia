using BLL;
using DAL;
using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaComercial
{
    public partial class TelaMenu : Form
    {
        public int localCad = 0;
        public string operacao = "";
        public int codigo = 0;
        public int cod = 0;
        public TelaMenu()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            
        }

        public void LimpaCampos1()
        {
            txtDataFreq.Clear();
            txtHoraEntrada.Clear();
            txtCodigo.Clear();
            txtHoraSaida.Clear();
            txtNome.Clear();
            txtmatricula.Clear();

        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroAluno aluno = new CadastroAluno();
            aluno.ShowDialog();
            
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProfessor professor = new CadastroProfessor();
            professor.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuario usuario = new CadastroUsuario();
            usuario.ShowDialog();
        }

        private void alunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void matriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlunoConsultaMatricula matricula = new AlunoConsultaMatricula();
            matricula.ShowDialog();

                  
        }
        private void nomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlunoConsultaNome nome = new AlunoConsultaNome();
            nome.ShowDialog();
        }

        private void rGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlunoConsultaRG RG = new AlunoConsultaRG();
            RG.ShowDialog();
        }

        private void bairroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlunoConsultaBairro bairro = new AlunoConsultaBairro();
            bairro.ShowDialog();
        }

        private void codigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfessorConsultaCodigo codigo = new ProfessorConsultaCodigo();
            codigo.ShowDialog();
        }

        private void nomeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProfessorConsultaNome Pnome = new ProfessorConsultaNome();
            Pnome.ShowDialog();
        }

        private void periodoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProfessorConsultaPeriodo Pperiodo = new ProfessorConsultaPeriodo();
            Pperiodo.ShowDialog();
        }

        private void periodoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AlunoConsultaPeriodo periodo = new AlunoConsultaPeriodo();
            periodo.ShowDialog();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrequenciaAluno frequencia = new FrequenciaAluno();
            frequencia.ShowDialog();
        }

        private void porDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrequenciaTotalDia dia = new FrequenciaTotalDia();
            dia.ShowDialog();
        }

        private void porMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrequenciaTotalMes mes = new FrequenciaTotalMes();
            mes.ShowDialog();
        }

        private void anoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrequenciaTotalAno ano = new FrequenciaTotalAno();
            ano.ShowDialog();

        }

        private void imprimirCarteiraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImprimirCarteira imprimir = new ImprimirCarteira();
            imprimir.ShowDialog();
        }

        private void nomeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PesquisaUsuario p = new PesquisaUsuario();
            p.ShowDialog();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PesquisaUsuarioUsu u = new PesquisaUsuarioUsu();
            u.ShowDialog();
        }

        private void TelaMenu_Load(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToShortDateString();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFrequencia bll = new BLLFrequencia(cx);

            dataGridView1.DataSource = bll.Localizar(txtDataFreq.Text);
            
        }

        private void cadastrarPlanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroPlano p = new CadastroPlano();
            p.ShowDialog();
        }

        private void verPlanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPlanos p = new ConsultaPlanos();
            p.ShowDialog();
        }
        

      
             
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)

        {
                 
            if (e.RowIndex >= 0)
            {
                string text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                if (text.Equals(""))
                {


                    int codigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLFrequencia bll = new BLLFrequencia(cx);
                    BLLMatricula bllA = new BLLMatricula(cx);
                    ModeloMatricula modelo = bllA.CarregaModeloMatricula(codigo);
                    ModeloFrequencia modeloe = bll.CarregaModeloFrequencia(codigo, cod);


                    txtmatricula.Text = modeloe.COD_MATRICULA.ToString();
                    txtDataFreq.Text = modeloe.DATA_FREQ;
                    txtHoraEntrada.Text = modeloe.HORA_ENTRADA;
                    txtHoraSaida.Text = modeloe.HORA_SAIDA;
                    txtCodigo.Text = modeloe.COD_FREQ.ToString();

                    SqlConnection cn = new SqlConnection(DadosDaConexao.StringDeConexao);
                    string pv = "Select NOME FROM CADASTRO_ALUNO INNER JOIN MATRICULA ON CADASTRO_ALUNO.COD_ALUNO = MATRICULA.COD_MATRICULA where MATRICULA.COD_MATRICULA = '" + txtmatricula.Text + "'";
                    SqlCommand cmd = new SqlCommand(pv, cn);
                    cn.Open();
                    SqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read() == true)
                    {
                        
                        txtNome.Text = leer["NOME"].ToString();

                    }
                    radioButton1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Esse registro não pode ser alterado");
                }
            }


        }
                    

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ModeloFrequencia frequencia = new ModeloFrequencia();
            ModeloMatricula matricula = new ModeloMatricula();

            matricula.COD_MATRICULA = Convert.ToInt32(txtmatricula.Text);
            frequencia.DATA_FREQ = txtDataFreq.Text;
            frequencia.HORA_ENTRADA = txtHoraEntrada.Text;
            frequencia.HORA_SAIDA = txtHoraSaida.Text;

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFrequencia bll = new BLLFrequencia(cx);
            this.operacao = "inserir";


            if (this.operacao == "inserir")
            {
                bll.Incluir(frequencia, matricula);

                MessageBox.Show("Entrada registada com sucesso");
                
            }

            radioButton2.Checked = false;
            radioButton1.Checked = false;
            dataGridView1.DataSource = bll.Localizar(txtDataFreq.Text);
            radioButton2.Enabled = true;
            this.LimpaCampos1();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ModeloFrequencia frequencia = new ModeloFrequencia();
            ModeloMatricula matricula = new ModeloMatricula();

            matricula.COD_MATRICULA = Convert.ToInt32(txtmatricula.Text);
            frequencia.DATA_FREQ = txtDataFreq.Text;
            frequencia.HORA_ENTRADA = txtHoraEntrada.Text;
            frequencia.HORA_SAIDA = txtHoraSaida.Text;

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFrequencia bll = new BLLFrequencia(cx);
            this.operacao = "alterar";

            if (this.operacao == "alterar")
            {
                frequencia.COD_FREQ = Convert.ToInt32(txtCodigo.Text);
                bll.Alterar(frequencia);
                MessageBox.Show("Saida Registrada com sucesso");

            }
           
            radioButton2.Checked = false;
            dataGridView1.DataSource = bll.Localizar(txtDataFreq.Text);
            radioButton1.Enabled = true;
             this.LimpaCampos1();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            txtDataFreq.Text = DateTime.Now.ToShortDateString();
            txtHoraEntrada.Text = DateTime.Now.ToShortTimeString();
            radioButton2.Enabled = false;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            txtHoraSaida.Text = DateTime.Now.ToShortTimeString();
            radioButton1.Enabled = false;
        }

        private void txtmatricula_TextChanged_1(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(DadosDaConexao.StringDeConexao);
            string pv = "Select NOME FROM CADASTRO_ALUNO INNER JOIN MATRICULA ON CADASTRO_ALUNO.COD_ALUNO = MATRICULA.COD_MATRICULA where MATRICULA.COD_MATRICULA = '" + txtmatricula.Text + "'";
            SqlCommand cmd = new SqlCommand(pv, cn);
            cn.Open();
            SqlDataReader leer = cmd.ExecuteReader();

            if (leer.Read() == true)
            {
                txtNome.Text = leer["NOME"].ToString();

            }
            else
            {
                txtNome.Text = "";

            }
            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();      
            Login l = new Login();
            l.ShowDialog();
            this.Close();
           
        }
    }
}
