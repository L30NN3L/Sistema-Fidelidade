using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TI_Fidelidade
{

    public partial class Principal : Form
    {
        private List<Cliente> clientes = new List<Cliente>();
        internal List<Cliente> Clientes
        {
            get { return clientes; }
            set { clientes = value; }
        }
        public static Principal janela { get; set; }
        public Principal()
        {
            InitializeComponent();
            addPainel(new Home());
            Centrifuga.lerArquivo(Clientes);
            Fruteira.organizarDatas_Bubble(Clientes);
            Fruteira.organizarDatas_Bubble(Clientes);
            Fruteira.pontuarVoosTodaLista(Clientes);
           
        }
        public void addPainel(UserControl p)
        {
            p.Dock = DockStyle.Left;
            pPrincipal.Controls.Clear();
            pPrincipal.Controls.Add(p);
        }

        public void incrPainel(UserControl u)
        {
            u.Dock = DockStyle.Right;
            pPrincipal.Controls.Add(u);
            
        }


        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPainel(new Home());
        }

        public void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPainel(new Clientes());
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            janela = this;
        }

     
    }
}
