namespace TI_Fidelidade
{
    partial class Clientes
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
            this.bNovo = new System.Windows.Forms.Button();
            this.gvClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // bNovo
            // 
            this.bNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bNovo.ForeColor = System.Drawing.Color.White;
            this.bNovo.Location = new System.Drawing.Point(14, 26);
            this.bNovo.Margin = new System.Windows.Forms.Padding(2);
            this.bNovo.Name = "bNovo";
            this.bNovo.Size = new System.Drawing.Size(56, 23);
            this.bNovo.TabIndex = 0;
            this.bNovo.Text = "Novo";
            this.bNovo.UseVisualStyleBackColor = false;
            this.bNovo.Click += new System.EventHandler(this.bNovo_Click);
            // 
            // gvClientes
            // 
            this.gvClientes.AllowUserToAddRows = false;
            this.gvClientes.AllowUserToDeleteRows = false;
            this.gvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvClientes.Location = new System.Drawing.Point(14, 69);
            this.gvClientes.Margin = new System.Windows.Forms.Padding(2);
            this.gvClientes.Name = "gvClientes";
            this.gvClientes.ReadOnly = true;
            this.gvClientes.RowTemplate.Height = 24;
            this.gvClientes.Size = new System.Drawing.Size(616, 275);
            this.gvClientes.TabIndex = 1;

            this.gvClientes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvClientes_CellMouseDoubleClick);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gvClientes);
            this.Controls.Add(this.bNovo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Clientes";
            this.Size = new System.Drawing.Size(680, 461);
     
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bNovo;
        private System.Windows.Forms.DataGridView gvClientes;
    }
}
