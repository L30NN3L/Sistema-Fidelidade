namespace TI_Fidelidade
{
    partial class Cadastro
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Component Designer

        /// <summary> 
        /// Método necessário para o suporte do Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.lCidade = new System.Windows.Forms.Label();
            this.bSalvar = new System.Windows.Forms.Button();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lCodigo = new System.Windows.Forms.Label();
            this.bNovo = new System.Windows.Forms.Button();
            this.bVoltar = new System.Windows.Forms.Button();
            this.bExcluir = new System.Windows.Forms.Button();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.rb_M = new System.Windows.Forms.RadioButton();
            this.rb_F = new System.Windows.Forms.RadioButton();
            this.lGenero = new System.Windows.Forms.Label();
            this.lDataNasc = new System.Windows.Forms.Label();
            this.tbNascimento = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.lCategoria = new System.Windows.Forms.Label();
            this.lCat = new System.Windows.Forms.Label();
            this.gbVoos = new System.Windows.Forms.GroupBox();
            this.tcVoo = new System.Windows.Forms.TabControl();
            this.tpVoos = new System.Windows.Forms.TabPage();
            this.gvVoos = new System.Windows.Forms.DataGridView();
            this.tpNovoVoo = new System.Windows.Forms.TabPage();
            this.lCompanhia = new System.Windows.Forms.Label();
            this.tbComapanhia = new System.Windows.Forms.TextBox();
            this.bNovoVoo = new System.Windows.Forms.Button();
            this.bExluirVoo = new System.Windows.Forms.Button();
            this.tbData = new System.Windows.Forms.MaskedTextBox();
            this.lDataH = new System.Windows.Forms.Label();
            this.lOrigem = new System.Windows.Forms.Label();
            this.lTipo = new System.Windows.Forms.Label();
            this.tbOrigem = new System.Windows.Forms.TextBox();
            this.bIncluir = new System.Windows.Forms.Button();
            this.cbProNor = new System.Windows.Forms.ComboBox();
            this.gbPontos = new System.Windows.Forms.GroupBox();
            this.lScoreTotal = new System.Windows.Forms.Label();
            this.lScore12 = new System.Windows.Forms.Label();
            this.lPontosAcc12 = new System.Windows.Forms.Label();
            this.lPontosAcc = new System.Windows.Forms.Label();
            this.gbDados.SuspendLayout();
            this.gbVoos.SuspendLayout();
            this.tcVoo.SuspendLayout();
            this.tpVoos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvVoos)).BeginInit();
            this.tpNovoVoo.SuspendLayout();
            this.gbPontos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lNome
            // 
            this.lNome.AutoSize = true;
            this.lNome.Location = new System.Drawing.Point(10, 50);
            this.lNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNome.Name = "lNome";
            this.lNome.Size = new System.Drawing.Size(38, 13);
            this.lNome.TabIndex = 0;
            this.lNome.Text = "Nome:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(57, 48);
            this.tbNome.Margin = new System.Windows.Forms.Padding(2);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(312, 20);
            this.tbNome.TabIndex = 1;
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(57, 71);
            this.tbCidade.Margin = new System.Windows.Forms.Padding(2);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(312, 20);
            this.tbCidade.TabIndex = 3;
            // 
            // lCidade
            // 
            this.lCidade.AutoSize = true;
            this.lCidade.Location = new System.Drawing.Point(10, 73);
            this.lCidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCidade.Name = "lCidade";
            this.lCidade.Size = new System.Drawing.Size(43, 13);
            this.lCidade.TabIndex = 2;
            this.lCidade.Text = "Cidade:";
            // 
            // bSalvar
            // 
            this.bSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bSalvar.ForeColor = System.Drawing.Color.White;
            this.bSalvar.Location = new System.Drawing.Point(17, 22);
            this.bSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.bSalvar.Name = "bSalvar";
            this.bSalvar.Size = new System.Drawing.Size(56, 23);
            this.bSalvar.TabIndex = 4;
            this.bSalvar.Text = "Salvar";
            this.bSalvar.UseVisualStyleBackColor = false;
            this.bSalvar.Click += new System.EventHandler(this.bSalvar_Click);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Location = new System.Drawing.Point(57, 25);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(54, 20);
            this.tbCodigo.TabIndex = 6;
            // 
            // lCodigo
            // 
            this.lCodigo.AutoSize = true;
            this.lCodigo.Location = new System.Drawing.Point(10, 28);
            this.lCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCodigo.Name = "lCodigo";
            this.lCodigo.Size = new System.Drawing.Size(43, 13);
            this.lCodigo.TabIndex = 5;
            this.lCodigo.Text = "Código:";
            // 
            // bNovo
            // 
            this.bNovo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bNovo.ForeColor = System.Drawing.Color.White;
            this.bNovo.Location = new System.Drawing.Point(78, 22);
            this.bNovo.Margin = new System.Windows.Forms.Padding(2);
            this.bNovo.Name = "bNovo";
            this.bNovo.Size = new System.Drawing.Size(56, 23);
            this.bNovo.TabIndex = 7;
            this.bNovo.Text = "Novo";
            this.bNovo.UseVisualStyleBackColor = false;
            this.bNovo.Click += new System.EventHandler(this.bNovo_Click);
            // 
            // bVoltar
            // 
            this.bVoltar.BackColor = System.Drawing.Color.DimGray;
            this.bVoltar.ForeColor = System.Drawing.Color.White;
            this.bVoltar.Location = new System.Drawing.Point(139, 22);
            this.bVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(56, 23);
            this.bVoltar.TabIndex = 8;
            this.bVoltar.Text = "Voltar";
            this.bVoltar.UseVisualStyleBackColor = false;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // bExcluir
            // 
            this.bExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bExcluir.ForeColor = System.Drawing.Color.White;
            this.bExcluir.Location = new System.Drawing.Point(200, 22);
            this.bExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.bExcluir.Name = "bExcluir";
            this.bExcluir.Size = new System.Drawing.Size(56, 23);
            this.bExcluir.TabIndex = 9;
            this.bExcluir.Text = "Excluir";
            this.bExcluir.UseVisualStyleBackColor = false;
            this.bExcluir.Click += new System.EventHandler(this.bExcluir_Click);
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.rb_M);
            this.gbDados.Controls.Add(this.rb_F);
            this.gbDados.Controls.Add(this.lGenero);
            this.gbDados.Controls.Add(this.lDataNasc);
            this.gbDados.Controls.Add(this.tbNascimento);
            this.gbDados.Controls.Add(this.tbEmail);
            this.gbDados.Controls.Add(this.lEmail);
            this.gbDados.Controls.Add(this.lCategoria);
            this.gbDados.Controls.Add(this.lCat);
            this.gbDados.Controls.Add(this.lCodigo);
            this.gbDados.Controls.Add(this.lNome);
            this.gbDados.Controls.Add(this.tbNome);
            this.gbDados.Controls.Add(this.lCidade);
            this.gbDados.Controls.Add(this.tbCidade);
            this.gbDados.Controls.Add(this.tbCodigo);
            this.gbDados.Location = new System.Drawing.Point(17, 50);
            this.gbDados.Margin = new System.Windows.Forms.Padding(2);
            this.gbDados.Name = "gbDados";
            this.gbDados.Padding = new System.Windows.Forms.Padding(2);
            this.gbDados.Size = new System.Drawing.Size(578, 199);
            this.gbDados.TabIndex = 10;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados do Cliente";
            // 
            // rb_M
            // 
            this.rb_M.AutoSize = true;
            this.rb_M.Location = new System.Drawing.Point(99, 149);
            this.rb_M.Name = "rb_M";
            this.rb_M.Size = new System.Drawing.Size(34, 17);
            this.rb_M.TabIndex = 15;
            this.rb_M.TabStop = true;
            this.rb_M.Text = "M";
            this.rb_M.UseVisualStyleBackColor = true;
            // 
            // rb_F
            // 
            this.rb_F.AutoSize = true;
            this.rb_F.Location = new System.Drawing.Point(62, 149);
            this.rb_F.Name = "rb_F";
            this.rb_F.Size = new System.Drawing.Size(31, 17);
            this.rb_F.TabIndex = 14;
            this.rb_F.TabStop = true;
            this.rb_F.Text = "F";
            this.rb_F.UseVisualStyleBackColor = true;
            // 
            // lGenero
            // 
            this.lGenero.AutoSize = true;
            this.lGenero.Location = new System.Drawing.Point(10, 149);
            this.lGenero.Name = "lGenero";
            this.lGenero.Size = new System.Drawing.Size(45, 13);
            this.lGenero.TabIndex = 13;
            this.lGenero.Text = "Gênero:";
            // 
            // lDataNasc
            // 
            this.lDataNasc.AutoSize = true;
            this.lDataNasc.Location = new System.Drawing.Point(10, 121);
            this.lDataNasc.Name = "lDataNasc";
            this.lDataNasc.Size = new System.Drawing.Size(61, 13);
            this.lDataNasc.TabIndex = 12;
            this.lDataNasc.Text = "Data Nasc:";
            // 
            // tbNascimento
            // 
            this.tbNascimento.Location = new System.Drawing.Point(76, 118);
            this.tbNascimento.Margin = new System.Windows.Forms.Padding(2);
            this.tbNascimento.Name = "tbNascimento";
            this.tbNascimento.Size = new System.Drawing.Size(102, 20);
            this.tbNascimento.TabIndex = 11;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(57, 94);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(312, 20);
            this.tbEmail.TabIndex = 10;
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(10, 97);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(35, 13);
            this.lEmail.TabIndex = 9;
            this.lEmail.Text = "Email:";
            // 
            // lCategoria
            // 
            this.lCategoria.AutoSize = true;
            this.lCategoria.Location = new System.Drawing.Point(75, 175);
            this.lCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCategoria.Name = "lCategoria";
            this.lCategoria.Size = new System.Drawing.Size(0, 13);
            this.lCategoria.TabIndex = 8;
            // 
            // lCat
            // 
            this.lCat.AutoSize = true;
            this.lCat.Location = new System.Drawing.Point(10, 175);
            this.lCat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCat.Name = "lCat";
            this.lCat.Size = new System.Drawing.Size(55, 13);
            this.lCat.TabIndex = 7;
            this.lCat.Text = "Categoria:";
            // 
            // gbVoos
            // 
            this.gbVoos.Controls.Add(this.tcVoo);
            this.gbVoos.Location = new System.Drawing.Point(17, 253);
            this.gbVoos.Margin = new System.Windows.Forms.Padding(2);
            this.gbVoos.Name = "gbVoos";
            this.gbVoos.Padding = new System.Windows.Forms.Padding(2);
            this.gbVoos.Size = new System.Drawing.Size(578, 228);
            this.gbVoos.TabIndex = 11;
            this.gbVoos.TabStop = false;
            this.gbVoos.Text = "Dados do Voo";
            // 
            // tcVoo
            // 
            this.tcVoo.Controls.Add(this.tpVoos);
            this.tcVoo.Controls.Add(this.tpNovoVoo);
            this.tcVoo.Location = new System.Drawing.Point(4, 17);
            this.tcVoo.Margin = new System.Windows.Forms.Padding(2);
            this.tcVoo.Name = "tcVoo";
            this.tcVoo.SelectedIndex = 0;
            this.tcVoo.Size = new System.Drawing.Size(568, 207);
            this.tcVoo.TabIndex = 0;
            this.tcVoo.SelectedIndexChanged += new System.EventHandler(this.tcVoo_SelectedIndexChanged);
            // 
            // tpVoos
            // 
            this.tpVoos.Controls.Add(this.gvVoos);
            this.tpVoos.Location = new System.Drawing.Point(4, 22);
            this.tpVoos.Margin = new System.Windows.Forms.Padding(2);
            this.tpVoos.Name = "tpVoos";
            this.tpVoos.Padding = new System.Windows.Forms.Padding(2);
            this.tpVoos.Size = new System.Drawing.Size(560, 181);
            this.tpVoos.TabIndex = 0;
            this.tpVoos.Text = "Voos";
            this.tpVoos.UseVisualStyleBackColor = true;
            // 
            // gvVoos
            // 
            this.gvVoos.AllowUserToAddRows = false;
            this.gvVoos.AllowUserToDeleteRows = false;
            this.gvVoos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvVoos.Location = new System.Drawing.Point(5, 6);
            this.gvVoos.Margin = new System.Windows.Forms.Padding(2);
            this.gvVoos.Name = "gvVoos";
            this.gvVoos.ReadOnly = true;
            this.gvVoos.RowTemplate.Height = 24;
            this.gvVoos.Size = new System.Drawing.Size(553, 171);
            this.gvVoos.TabIndex = 0;
            this.gvVoos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvVoos_CellMouseDoubleClick);
            // 
            // tpNovoVoo
            // 
            this.tpNovoVoo.Controls.Add(this.lCompanhia);
            this.tpNovoVoo.Controls.Add(this.tbComapanhia);
            this.tpNovoVoo.Controls.Add(this.bNovoVoo);
            this.tpNovoVoo.Controls.Add(this.bExluirVoo);
            this.tpNovoVoo.Controls.Add(this.tbData);
            this.tpNovoVoo.Controls.Add(this.lDataH);
            this.tpNovoVoo.Controls.Add(this.lOrigem);
            this.tpNovoVoo.Controls.Add(this.lTipo);
            this.tpNovoVoo.Controls.Add(this.tbOrigem);
            this.tpNovoVoo.Controls.Add(this.bIncluir);
            this.tpNovoVoo.Controls.Add(this.cbProNor);
            this.tpNovoVoo.Location = new System.Drawing.Point(4, 22);
            this.tpNovoVoo.Margin = new System.Windows.Forms.Padding(2);
            this.tpNovoVoo.Name = "tpNovoVoo";
            this.tpNovoVoo.Padding = new System.Windows.Forms.Padding(2);
            this.tpNovoVoo.Size = new System.Drawing.Size(560, 181);
            this.tpNovoVoo.TabIndex = 1;
            this.tpNovoVoo.Text = "Novo";
            this.tpNovoVoo.UseVisualStyleBackColor = true;
            // 
            // lCompanhia
            // 
            this.lCompanhia.AutoSize = true;
            this.lCompanhia.Location = new System.Drawing.Point(4, 104);
            this.lCompanhia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCompanhia.Name = "lCompanhia";
            this.lCompanhia.Size = new System.Drawing.Size(63, 13);
            this.lCompanhia.TabIndex = 22;
            this.lCompanhia.Text = "Companhia:";
            // 
            // tbComapanhia
            // 
            this.tbComapanhia.Location = new System.Drawing.Point(71, 101);
            this.tbComapanhia.Margin = new System.Windows.Forms.Padding(2);
            this.tbComapanhia.Name = "tbComapanhia";
            this.tbComapanhia.Size = new System.Drawing.Size(312, 20);
            this.tbComapanhia.TabIndex = 21;
            // 
            // bNovoVoo
            // 
            this.bNovoVoo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bNovoVoo.ForeColor = System.Drawing.Color.White;
            this.bNovoVoo.Location = new System.Drawing.Point(64, 14);
            this.bNovoVoo.Margin = new System.Windows.Forms.Padding(2);
            this.bNovoVoo.Name = "bNovoVoo";
            this.bNovoVoo.Size = new System.Drawing.Size(56, 23);
            this.bNovoVoo.TabIndex = 20;
            this.bNovoVoo.Text = "Novo";
            this.bNovoVoo.UseVisualStyleBackColor = false;
            this.bNovoVoo.Click += new System.EventHandler(this.bNovoVoo_Click);
            // 
            // bExluirVoo
            // 
            this.bExluirVoo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bExluirVoo.ForeColor = System.Drawing.Color.White;
            this.bExluirVoo.Location = new System.Drawing.Point(124, 14);
            this.bExluirVoo.Margin = new System.Windows.Forms.Padding(2);
            this.bExluirVoo.Name = "bExluirVoo";
            this.bExluirVoo.Size = new System.Drawing.Size(56, 23);
            this.bExluirVoo.TabIndex = 12;
            this.bExluirVoo.Text = "Excluir";
            this.bExluirVoo.UseVisualStyleBackColor = false;
            this.bExluirVoo.Click += new System.EventHandler(this.bExluirVoo_Click);
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(70, 47);
            this.tbData.Mask = "99/99/9999 99:99";
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(100, 20);
            this.tbData.TabIndex = 19;
            // 
            // lDataH
            // 
            this.lDataH.AutoSize = true;
            this.lDataH.Location = new System.Drawing.Point(4, 54);
            this.lDataH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lDataH.Name = "lDataH";
            this.lDataH.Size = new System.Drawing.Size(61, 13);
            this.lDataH.TabIndex = 18;
            this.lDataH.Text = "Data/Hora:";
            // 
            // lOrigem
            // 
            this.lOrigem.AutoSize = true;
            this.lOrigem.Location = new System.Drawing.Point(4, 129);
            this.lOrigem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lOrigem.Name = "lOrigem";
            this.lOrigem.Size = new System.Drawing.Size(43, 13);
            this.lOrigem.TabIndex = 15;
            this.lOrigem.Text = "Origem:";
            // 
            // lTipo
            // 
            this.lTipo.AutoSize = true;
            this.lTipo.Location = new System.Drawing.Point(4, 76);
            this.lTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTipo.Name = "lTipo";
            this.lTipo.Size = new System.Drawing.Size(31, 13);
            this.lTipo.TabIndex = 14;
            this.lTipo.Text = "Tipo:";
            // 
            // tbOrigem
            // 
            this.tbOrigem.Location = new System.Drawing.Point(70, 126);
            this.tbOrigem.Margin = new System.Windows.Forms.Padding(2);
            this.tbOrigem.Name = "tbOrigem";
            this.tbOrigem.Size = new System.Drawing.Size(312, 20);
            this.tbOrigem.TabIndex = 13;
            // 
            // bIncluir
            // 
            this.bIncluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bIncluir.ForeColor = System.Drawing.Color.White;
            this.bIncluir.Location = new System.Drawing.Point(4, 14);
            this.bIncluir.Margin = new System.Windows.Forms.Padding(2);
            this.bIncluir.Name = "bIncluir";
            this.bIncluir.Size = new System.Drawing.Size(56, 23);
            this.bIncluir.TabIndex = 12;
            this.bIncluir.Text = "Incluir";
            this.bIncluir.UseVisualStyleBackColor = false;
            this.bIncluir.Click += new System.EventHandler(this.bIncluir_Click);
            // 
            // cbProNor
            // 
            this.cbProNor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProNor.Items.AddRange(new object[] {
            "Promocional",
            "Normal"});
            this.cbProNor.Location = new System.Drawing.Point(70, 72);
            this.cbProNor.Margin = new System.Windows.Forms.Padding(2);
            this.cbProNor.Name = "cbProNor";
            this.cbProNor.Size = new System.Drawing.Size(92, 21);
            this.cbProNor.TabIndex = 16;
            // 
            // gbPontos
            // 
            this.gbPontos.Controls.Add(this.lScoreTotal);
            this.gbPontos.Controls.Add(this.lScore12);
            this.gbPontos.Controls.Add(this.lPontosAcc12);
            this.gbPontos.Controls.Add(this.lPontosAcc);
            this.gbPontos.Location = new System.Drawing.Point(17, 486);
            this.gbPontos.Name = "gbPontos";
            this.gbPontos.Size = new System.Drawing.Size(578, 118);
            this.gbPontos.TabIndex = 13;
            this.gbPontos.TabStop = false;
            this.gbPontos.Text = "Pontos do Cliente";
            // 
            // lScoreTotal
            // 
            this.lScoreTotal.AutoSize = true;
            this.lScoreTotal.Location = new System.Drawing.Point(176, 33);
            this.lScoreTotal.Name = "lScoreTotal";
            this.lScoreTotal.Size = new System.Drawing.Size(0, 13);
            this.lScoreTotal.TabIndex = 3;
            // 
            // lScore12
            // 
            this.lScore12.AutoSize = true;
            this.lScore12.Location = new System.Drawing.Point(176, 67);
            this.lScore12.Name = "lScore12";
            this.lScore12.Size = new System.Drawing.Size(0, 13);
            this.lScore12.TabIndex = 2;
            // 
            // lPontosAcc12
            // 
            this.lPontosAcc12.AutoSize = true;
            this.lPontosAcc12.Location = new System.Drawing.Point(18, 67);
            this.lPontosAcc12.Name = "lPontosAcc12";
            this.lPontosAcc12.Size = new System.Drawing.Size(152, 13);
            this.lPontosAcc12.TabIndex = 1;
            this.lPontosAcc12.Text = "Pontos dos Últimos 12 Meses: ";
            // 
            // lPontosAcc
            // 
            this.lPontosAcc.AutoSize = true;
            this.lPontosAcc.Location = new System.Drawing.Point(20, 33);
            this.lPontosAcc.Name = "lPontosAcc";
            this.lPontosAcc.Size = new System.Drawing.Size(104, 13);
            this.lPontosAcc.TabIndex = 0;
            this.lPontosAcc.Text = "Pontos Acumulados:";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbPontos);
            this.Controls.Add(this.gbVoos);
            this.Controls.Add(this.gbDados);
            this.Controls.Add(this.bExcluir);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.bNovo);
            this.Controls.Add(this.bSalvar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Cadastro";
            this.Size = new System.Drawing.Size(651, 627);
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.gbVoos.ResumeLayout(false);
            this.tcVoo.ResumeLayout(false);
            this.tpVoos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvVoos)).EndInit();
            this.tpNovoVoo.ResumeLayout(false);
            this.tpNovoVoo.PerformLayout();
            this.gbPontos.ResumeLayout(false);
            this.gbPontos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label lCidade;
        private System.Windows.Forms.Button bSalvar;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lCodigo;
        private System.Windows.Forms.Button bNovo;
        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.Button bExcluir;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.GroupBox gbVoos;
        private System.Windows.Forms.TabControl tcVoo;
        private System.Windows.Forms.TabPage tpVoos;
        private System.Windows.Forms.TabPage tpNovoVoo;
        private System.Windows.Forms.Label lOrigem;
        private System.Windows.Forms.Label lTipo;
        private System.Windows.Forms.TextBox tbOrigem;
        private System.Windows.Forms.Button bIncluir;
        private System.Windows.Forms.ComboBox cbProNor;
        private System.Windows.Forms.Label lCategoria;
        private System.Windows.Forms.Label lCat;
        private System.Windows.Forms.DataGridView gvVoos;
        private System.Windows.Forms.Label lDataH;
        private System.Windows.Forms.MaskedTextBox tbData;
        private System.Windows.Forms.Button bExluirVoo;
        private System.Windows.Forms.Button bNovoVoo;
        private System.Windows.Forms.Label lDataNasc;
        private System.Windows.Forms.TextBox tbNascimento;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lGenero;
        private System.Windows.Forms.RadioButton rb_M;
        private System.Windows.Forms.RadioButton rb_F;
        private System.Windows.Forms.Label lCompanhia;
        private System.Windows.Forms.TextBox tbComapanhia;
        private System.Windows.Forms.GroupBox gbPontos;
        private System.Windows.Forms.Label lScoreTotal;
        private System.Windows.Forms.Label lScore12;
        private System.Windows.Forms.Label lPontosAcc12;
        private System.Windows.Forms.Label lPontosAcc;
    }
}
