using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TI_Fidelidade
{
    public partial class Clientes : UserControl
    {
        public Clientes()
        {
            InitializeComponent();
            carregaClientes();
        }

        private void bNovo_Click(object sender, EventArgs e)
        {
            Principal.janela.addPainel(new Cadastro());
        }

        public void carregaClientes()
        {
            DataTable dt = new DataTable("Clientes");
            dt.Columns.Add("Codigo", typeof(int));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Cidade", typeof(string));
            foreach (Cliente client in Principal.janela.Clientes)
                dt.Rows.Add(client.Identificador, client.Nome, client.CidadeOrigem);
            gvClientes.DataSource = dt;
            gvClientes.Columns[1].Width = 235;
            gvClientes.Columns[2].Width = 235;
        }
        private void gvClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = gvClientes.CurrentRow.Index;
            Principal.janela.addPainel(new Cadastro(index));
            Principal.janela.incrPainel(new Grafico(index));

        }

      
    }
}
