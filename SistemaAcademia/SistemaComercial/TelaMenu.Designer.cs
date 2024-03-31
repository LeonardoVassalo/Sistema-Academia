namespace SistemaComercial
{
    partial class TelaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Planos = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.matriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bairroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.codigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.planosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarPlanosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPlanosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frequenciaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.totalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carteiraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirCarteiraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.innnnnnnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDataFreq = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoraSaida = new System.Windows.Forms.TextBox();
            this.txtHoraEntrada = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.COD_FREQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_MATRICULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_FREQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA_ENTRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA_SAIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_VENC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(490, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "01/01/2018";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_FREQ,
            this.COD_MATRICULA,
            this.NOME,
            this.DATA_FREQ,
            this.HORA_ENTRADA,
            this.HORA_SAIDA,
            this.DATA_VENC});
            this.dataGridView1.Location = new System.Drawing.Point(12, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 257);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Planos,
            this.consultasToolStripMenuItem,
            this.planosToolStripMenuItem,
            this.frequenciaToolStripMenuItem1,
            this.carteiraToolStripMenuItem,
            this.inToolStripMenuItem,
            this.innnnnnnToolStripMenuItem,
            this.logoffToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Planos
            // 
            this.Planos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.professorToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.Planos.Image = global::SistemaComercial.Properties.Resources.family_of_heterosexual_couple;
            this.Planos.Name = "Planos";
            this.Planos.Size = new System.Drawing.Size(82, 20);
            this.Planos.Text = "Cadastro";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.alunoToolStripMenuItem.Text = "Aluno";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
            // 
            // professorToolStripMenuItem
            // 
            this.professorToolStripMenuItem.Name = "professorToolStripMenuItem";
            this.professorToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.professorToolStripMenuItem.Text = "Professor";
            this.professorToolStripMenuItem.Click += new System.EventHandler(this.professorToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem1,
            this.professorToolStripMenuItem1,
            this.usuariosToolStripMenuItem});
            this.consultasToolStripMenuItem.Image = global::SistemaComercial.Properties.Resources.search_magnifier_interface_symbol;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // alunoToolStripMenuItem1
            // 
            this.alunoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matriculaToolStripMenuItem,
            this.nomeToolStripMenuItem,
            this.rGToolStripMenuItem,
            this.bairroToolStripMenuItem,
            this.periodoToolStripMenuItem2});
            this.alunoToolStripMenuItem1.Name = "alunoToolStripMenuItem1";
            this.alunoToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.alunoToolStripMenuItem1.Text = "Aluno";
            this.alunoToolStripMenuItem1.Click += new System.EventHandler(this.alunoToolStripMenuItem1_Click);
            // 
            // matriculaToolStripMenuItem
            // 
            this.matriculaToolStripMenuItem.Name = "matriculaToolStripMenuItem";
            this.matriculaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.matriculaToolStripMenuItem.Text = "Matricula";
            this.matriculaToolStripMenuItem.Click += new System.EventHandler(this.matriculaToolStripMenuItem_Click);
            // 
            // nomeToolStripMenuItem
            // 
            this.nomeToolStripMenuItem.Name = "nomeToolStripMenuItem";
            this.nomeToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.nomeToolStripMenuItem.Text = "Nome";
            this.nomeToolStripMenuItem.Click += new System.EventHandler(this.nomeToolStripMenuItem_Click);
            // 
            // rGToolStripMenuItem
            // 
            this.rGToolStripMenuItem.Name = "rGToolStripMenuItem";
            this.rGToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.rGToolStripMenuItem.Text = "RG";
            this.rGToolStripMenuItem.Click += new System.EventHandler(this.rGToolStripMenuItem_Click);
            // 
            // bairroToolStripMenuItem
            // 
            this.bairroToolStripMenuItem.Name = "bairroToolStripMenuItem";
            this.bairroToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.bairroToolStripMenuItem.Text = "Professor";
            this.bairroToolStripMenuItem.Click += new System.EventHandler(this.bairroToolStripMenuItem_Click);
            // 
            // periodoToolStripMenuItem2
            // 
            this.periodoToolStripMenuItem2.Name = "periodoToolStripMenuItem2";
            this.periodoToolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.periodoToolStripMenuItem2.Text = "Periodo";
            this.periodoToolStripMenuItem2.Click += new System.EventHandler(this.periodoToolStripMenuItem2_Click);
            // 
            // professorToolStripMenuItem1
            // 
            this.professorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codigoToolStripMenuItem,
            this.periodoToolStripMenuItem1,
            this.nomeToolStripMenuItem1});
            this.professorToolStripMenuItem1.Name = "professorToolStripMenuItem1";
            this.professorToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.professorToolStripMenuItem1.Text = "Professor";
            // 
            // codigoToolStripMenuItem
            // 
            this.codigoToolStripMenuItem.Name = "codigoToolStripMenuItem";
            this.codigoToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.codigoToolStripMenuItem.Text = "Código";
            this.codigoToolStripMenuItem.Click += new System.EventHandler(this.codigoToolStripMenuItem_Click);
            // 
            // periodoToolStripMenuItem1
            // 
            this.periodoToolStripMenuItem1.Name = "periodoToolStripMenuItem1";
            this.periodoToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.periodoToolStripMenuItem1.Text = "Periodo";
            this.periodoToolStripMenuItem1.Click += new System.EventHandler(this.periodoToolStripMenuItem1_Click);
            // 
            // nomeToolStripMenuItem1
            // 
            this.nomeToolStripMenuItem1.Name = "nomeToolStripMenuItem1";
            this.nomeToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.nomeToolStripMenuItem1.Text = "Nome";
            this.nomeToolStripMenuItem1.Click += new System.EventHandler(this.nomeToolStripMenuItem1_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomeToolStripMenuItem2,
            this.usuarioToolStripMenuItem1});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // nomeToolStripMenuItem2
            // 
            this.nomeToolStripMenuItem2.Name = "nomeToolStripMenuItem2";
            this.nomeToolStripMenuItem2.Size = new System.Drawing.Size(114, 22);
            this.nomeToolStripMenuItem2.Text = "Nome";
            this.nomeToolStripMenuItem2.Click += new System.EventHandler(this.nomeToolStripMenuItem2_Click);
            // 
            // usuarioToolStripMenuItem1
            // 
            this.usuarioToolStripMenuItem1.Name = "usuarioToolStripMenuItem1";
            this.usuarioToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.usuarioToolStripMenuItem1.Text = "Usuario";
            this.usuarioToolStripMenuItem1.Click += new System.EventHandler(this.usuarioToolStripMenuItem1_Click);
            // 
            // planosToolStripMenuItem
            // 
            this.planosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarPlanosToolStripMenuItem,
            this.verPlanosToolStripMenuItem});
            this.planosToolStripMenuItem.Image = global::SistemaComercial.Properties.Resources.add_business_card_symbol;
            this.planosToolStripMenuItem.Name = "planosToolStripMenuItem";
            this.planosToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.planosToolStripMenuItem.Text = "Planos";
            // 
            // cadastrarPlanosToolStripMenuItem
            // 
            this.cadastrarPlanosToolStripMenuItem.Name = "cadastrarPlanosToolStripMenuItem";
            this.cadastrarPlanosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.cadastrarPlanosToolStripMenuItem.Text = "Cadastrar Planos";
            this.cadastrarPlanosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarPlanosToolStripMenuItem_Click);
            // 
            // verPlanosToolStripMenuItem
            // 
            this.verPlanosToolStripMenuItem.Name = "verPlanosToolStripMenuItem";
            this.verPlanosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.verPlanosToolStripMenuItem.Text = "Ver Planos";
            this.verPlanosToolStripMenuItem.Click += new System.EventHandler(this.verPlanosToolStripMenuItem_Click);
            // 
            // frequenciaToolStripMenuItem1
            // 
            this.frequenciaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalToolStripMenuItem});
            this.frequenciaToolStripMenuItem1.Image = global::SistemaComercial.Properties.Resources.team;
            this.frequenciaToolStripMenuItem1.Name = "frequenciaToolStripMenuItem1";
            this.frequenciaToolStripMenuItem1.Size = new System.Drawing.Size(93, 20);
            this.frequenciaToolStripMenuItem1.Text = "Frequencia";
            // 
            // totalToolStripMenuItem
            // 
            this.totalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porDiaToolStripMenuItem,
            this.porMesToolStripMenuItem,
            this.anoToolStripMenuItem});
            this.totalToolStripMenuItem.Name = "totalToolStripMenuItem";
            this.totalToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.totalToolStripMenuItem.Text = "Aluno";
            // 
            // porDiaToolStripMenuItem
            // 
            this.porDiaToolStripMenuItem.Name = "porDiaToolStripMenuItem";
            this.porDiaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.porDiaToolStripMenuItem.Text = "Por Dia";
            this.porDiaToolStripMenuItem.Click += new System.EventHandler(this.porDiaToolStripMenuItem_Click);
            // 
            // porMesToolStripMenuItem
            // 
            this.porMesToolStripMenuItem.Name = "porMesToolStripMenuItem";
            this.porMesToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.porMesToolStripMenuItem.Text = "Por Mes";
            this.porMesToolStripMenuItem.Click += new System.EventHandler(this.porMesToolStripMenuItem_Click);
            // 
            // anoToolStripMenuItem
            // 
            this.anoToolStripMenuItem.Name = "anoToolStripMenuItem";
            this.anoToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.anoToolStripMenuItem.Text = "Ano";
            this.anoToolStripMenuItem.Click += new System.EventHandler(this.anoToolStripMenuItem_Click);
            // 
            // carteiraToolStripMenuItem
            // 
            this.carteiraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirCarteiraToolStripMenuItem});
            this.carteiraToolStripMenuItem.Image = global::SistemaComercial.Properties.Resources.print_black_printer_tool_symbol;
            this.carteiraToolStripMenuItem.Name = "carteiraToolStripMenuItem";
            this.carteiraToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.carteiraToolStripMenuItem.Text = "Carteira";
            // 
            // imprimirCarteiraToolStripMenuItem
            // 
            this.imprimirCarteiraToolStripMenuItem.Name = "imprimirCarteiraToolStripMenuItem";
            this.imprimirCarteiraToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.imprimirCarteiraToolStripMenuItem.Text = "Imprimir Carteira ";
            this.imprimirCarteiraToolStripMenuItem.Click += new System.EventHandler(this.imprimirCarteiraToolStripMenuItem_Click);
            // 
            // inToolStripMenuItem
            // 
            this.inToolStripMenuItem.Name = "inToolStripMenuItem";
            this.inToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // innnnnnnToolStripMenuItem
            // 
            this.innnnnnnToolStripMenuItem.Name = "innnnnnnToolStripMenuItem";
            this.innnnnnnToolStripMenuItem.Size = new System.Drawing.Size(205, 20);
            this.innnnnnnToolStripMenuItem.Text = "                                                              ";
            // 
            // logoffToolStripMenuItem
            // 
            this.logoffToolStripMenuItem.Image = global::SistemaComercial.Properties.Resources.key_silhouette_security_tool_interface_symbol_of_password;
            this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            this.logoffToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.logoffToolStripMenuItem.Text = "Logoff";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::SistemaComercial.Properties.Resources.logout;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(17, 166);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(45, 20);
            this.txtCodigo.TabIndex = 64;
            this.txtCodigo.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Dia";
            // 
            // txtDataFreq
            // 
            this.txtDataFreq.Enabled = false;
            this.txtDataFreq.Location = new System.Drawing.Point(412, 43);
            this.txtDataFreq.Name = "txtDataFreq";
            this.txtDataFreq.Size = new System.Drawing.Size(100, 20);
            this.txtDataFreq.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Saída";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Entrada";
            // 
            // txtHoraSaida
            // 
            this.txtHoraSaida.Enabled = false;
            this.txtHoraSaida.Location = new System.Drawing.Point(412, 98);
            this.txtHoraSaida.Name = "txtHoraSaida";
            this.txtHoraSaida.Size = new System.Drawing.Size(100, 20);
            this.txtHoraSaida.TabIndex = 55;
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.Enabled = false;
            this.txtHoraEntrada.Location = new System.Drawing.Point(412, 69);
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtHoraEntrada.TabIndex = 54;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(68, 73);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(208, 20);
            this.txtNome.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Matricula";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(263, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 17);
            this.radioButton2.TabIndex = 51;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Saida";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(185, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 50;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Entrada";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(92, 35);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(65, 20);
            this.txtmatricula.TabIndex = 49;
            this.txtmatricula.TextChanged += new System.EventHandler(this.txtmatricula_TextChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SistemaComercial.Properties.Resources._15577b62a782ff0__2_;
            this.pictureBox1.Location = new System.Drawing.Point(599, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 151);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::SistemaComercial.Properties.Resources.exit_door_sign;
            this.button4.Location = new System.Drawing.Point(187, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 58);
            this.button4.TabIndex = 65;
            this.button4.Text = "Saida";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::SistemaComercial.Properties.Resources.exit_door_symbol;
            this.button5.Location = new System.Drawing.Point(47, 102);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 58);
            this.button5.TabIndex = 59;
            this.button5.Text = " Entrada";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // COD_FREQ
            // 
            this.COD_FREQ.DataPropertyName = "COD_FREQ";
            this.COD_FREQ.HeaderText = "Código Frequencia";
            this.COD_FREQ.Name = "COD_FREQ";
            this.COD_FREQ.Visible = false;
            // 
            // COD_MATRICULA
            // 
            this.COD_MATRICULA.DataPropertyName = "COD_MATRICULA";
            this.COD_MATRICULA.HeaderText = "Matricula";
            this.COD_MATRICULA.Name = "COD_MATRICULA";
            this.COD_MATRICULA.Width = 75;
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "NOME";
            this.NOME.HeaderText = "Nome Aluno";
            this.NOME.Name = "NOME";
            this.NOME.Width = 355;
            // 
            // DATA_FREQ
            // 
            this.DATA_FREQ.DataPropertyName = "DATA_FREQ";
            this.DATA_FREQ.HeaderText = "Dia";
            this.DATA_FREQ.Name = "DATA_FREQ";
            this.DATA_FREQ.Width = 75;
            // 
            // HORA_ENTRADA
            // 
            this.HORA_ENTRADA.DataPropertyName = "HORA_ENTRADA";
            this.HORA_ENTRADA.HeaderText = "Entrada";
            this.HORA_ENTRADA.Name = "HORA_ENTRADA";
            this.HORA_ENTRADA.Width = 75;
            // 
            // HORA_SAIDA
            // 
            this.HORA_SAIDA.DataPropertyName = "HORA_SAIDA";
            this.HORA_SAIDA.HeaderText = "Saida";
            this.HORA_SAIDA.Name = "HORA_SAIDA";
            this.HORA_SAIDA.Width = 75;
            // 
            // DATA_VENC
            // 
            this.DATA_VENC.DataPropertyName = "DATA_VENC";
            this.DATA_VENC.HeaderText = "Vencimento MAT";
            this.DATA_VENC.Name = "DATA_VENC";
            this.DATA_VENC.Width = 75;
            // 
            // TelaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDataFreq);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoraSaida);
            this.Controls.Add(this.txtHoraEntrada);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TelaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.TelaMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Planos;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem professorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frequenciaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem totalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarPlanosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPlanosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carteiraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirCarteiraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bairroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nomeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem periodoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem porDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nomeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDataFreq;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoraSaida;
        public System.Windows.Forms.TextBox txtHoraEntrada;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem inToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem innnnnnnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_FREQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_MATRICULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_FREQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA_ENTRADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA_SAIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_VENC;
    }
}