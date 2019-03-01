namespace TI_Fidelidade
{
    partial class Home
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
            this.lNomeEmpresa = new System.Windows.Forms.Label();
            this.lNomeElisa = new System.Windows.Forms.Label();
            this.lNomeHugo = new System.Windows.Forms.Label();
            this.lNomeJuliana = new System.Windows.Forms.Label();
            this.lNomeLuiz = new System.Windows.Forms.Label();
            this.lNomePedro = new System.Windows.Forms.Label();
            this.lLogo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lNomeEmpresa
            // 
            this.lNomeEmpresa.AutoSize = true;
            this.lNomeEmpresa.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNomeEmpresa.Location = new System.Drawing.Point(14, 27);
            this.lNomeEmpresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNomeEmpresa.Name = "lNomeEmpresa";
            this.lNomeEmpresa.Size = new System.Drawing.Size(416, 27);
            this.lNomeEmpresa.TabIndex = 0;
            this.lNomeEmpresa.Text = "Programa de Fidelidade - Pombos Airlines";
            // 
            // lNomeElisa
            // 
            this.lNomeElisa.AutoSize = true;
            this.lNomeElisa.Location = new System.Drawing.Point(29, 89);
            this.lNomeElisa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNomeElisa.Name = "lNomeElisa";
            this.lNomeElisa.Size = new System.Drawing.Size(227, 13);
            this.lNomeElisa.TabIndex = 1;
            this.lNomeElisa.Text = "ELISA MARIA FERREIRA DA SILVA - 546466";
            // 
            // lNomeHugo
            // 
            this.lNomeHugo.AutoSize = true;
            this.lNomeHugo.Location = new System.Drawing.Point(30, 110);
            this.lNomeHugo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNomeHugo.Name = "lNomeHugo";
            this.lNomeHugo.Size = new System.Drawing.Size(208, 13);
            this.lNomeHugo.TabIndex = 2;
            this.lNomeHugo.Text = "HUGO LEONEL DE CARVALHO - 546508";
            // 
            // lNomeJuliana
            // 
            this.lNomeJuliana.AutoSize = true;
            this.lNomeJuliana.Location = new System.Drawing.Point(29, 132);
            this.lNomeJuliana.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNomeJuliana.Name = "lNomeJuliana";
            this.lNomeJuliana.Size = new System.Drawing.Size(203, 13);
            this.lNomeJuliana.TabIndex = 3;
            this.lNomeJuliana.Text = "JULIANA MOREIRA SALGADO - 543161";
            // 
            // lNomeLuiz
            // 
            this.lNomeLuiz.AutoSize = true;
            this.lNomeLuiz.Location = new System.Drawing.Point(29, 154);
            this.lNomeLuiz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNomeLuiz.Name = "lNomeLuiz";
            this.lNomeLuiz.Size = new System.Drawing.Size(276, 13);
            this.lNomeLuiz.TabIndex = 4;
            this.lNomeLuiz.Text = "LUIZ FERNANDO AGUIAR DO NASCIMENTO - 546573";
            // 
            // lNomePedro
            // 
            this.lNomePedro.AutoSize = true;
            this.lNomePedro.Location = new System.Drawing.Point(29, 176);
            this.lNomePedro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNomePedro.Name = "lNomePedro";
            this.lNomePedro.Size = new System.Drawing.Size(208, 13);
            this.lNomePedro.TabIndex = 5;
            this.lNomePedro.Text = "PEDRO HENRIQUE DE SOUZA - 550681";
            // 
            // lLogo
            // 
            this.lLogo.Image = global::TI_Fidelidade.Properties.Resources.pombo;
            this.lLogo.Location = new System.Drawing.Point(248, 184);
            this.lLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lLogo.Name = "lLogo";
            this.lLogo.Size = new System.Drawing.Size(336, 191);
            this.lLogo.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lLogo);
            this.Controls.Add(this.lNomePedro);
            this.Controls.Add(this.lNomeLuiz);
            this.Controls.Add(this.lNomeJuliana);
            this.Controls.Add(this.lNomeHugo);
            this.Controls.Add(this.lNomeElisa);
            this.Controls.Add(this.lNomeEmpresa);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(640, 375);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNomeEmpresa;
        private System.Windows.Forms.Label lNomeElisa;
        private System.Windows.Forms.Label lNomeHugo;
        private System.Windows.Forms.Label lNomeJuliana;
        private System.Windows.Forms.Label lNomeLuiz;
        private System.Windows.Forms.Label lNomePedro;
        private System.Windows.Forms.Label lLogo;
    }
}
