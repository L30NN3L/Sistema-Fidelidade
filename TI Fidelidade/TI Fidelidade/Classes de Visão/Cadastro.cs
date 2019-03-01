using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TI_Fidelidade
{
    public partial class Cadastro : UserControl
    {
        Cliente cliente;
        List<Cliente> clientes;
        private static int ind = 0;

        public Cadastro()
        {
            InitializeComponent();
            bExcluir.Visible = false;
            gbVoos.Visible = false;
            lCategoria.Visible = false;
            gbPontos.Visible = false;
            
            clientes = Principal.janela.Clientes;
            cbProNor.SelectedIndex = 0;
        }
        public Cadastro(int index)
        {

            clientes = Principal.janela.Clientes;
            this.cliente = clientes.ElementAt(index);
            InitializeComponent();
            tbCodigo.Text = cliente.Identificador.ToString();
            tbNome.Text = cliente.Nome;
            tbCidade.Text = cliente.CidadeOrigem;
            tbEmail.Text = cliente.Email;
            tbNascimento.Text = cliente.DataNascimento.ToString("d");

            if (cliente.Genero.Equals('F'))
            {
                rb_F.Checked = true;
                rb_M.Checked = false;
            }
            else
            {
                rb_F.Checked = false;
                rb_M.Checked = true;
            }

            lCategoria.Text = cliente.Categoria;
            bExcluir.Visible = true;
            gbVoos.Visible = true;
            atualizaVoos();
            cbProNor.SelectedIndex = 0;
            gbPontos.Visible = true;
            
            if(cliente.Pontos_12.Count != 0)
            {
                lScoreTotal.Text = cliente.PontosAcc.ToString();
                lScore12.Text = cliente.Pontos_12.Last().Pontos.ToString();
            }
            else
            {
                lScoreTotal.Text = 0.ToString();
                lScore12.Text = 0.ToString();
            }
            
        }

        private void bSalvar_Click(object sender, EventArgs e)
        {
            if (tbNome.Text == "")
            {
                MessageBox.Show("Informe o nome.");
                tbNome.Focus();
                return;
            }
            else if (tbCidade.Text == "")
            {
                MessageBox.Show("Informe a cidade.");
                tbCidade.Focus();
                return;
            }
            else if (tbEmail.Text == "")
            {
                MessageBox.Show("Informe o email.");
                tbCidade.Focus();
                return;
            }
            else if (tbNascimento.Text == "")
            {
                MessageBox.Show("Informe a data de nascimento.");
                tbCidade.Focus();
                return;
            }else if(!(rb_F.Checked || rb_M.Checked))
            {
                MessageBox.Show("Informe o gênero.");
                rb_F.Focus();
                rb_M.Focus();
                return;
            }

            try
            {
                string nome = tbNome.Text,
                cidade = tbCidade.Text,
                email = tbEmail.Text;
                DateTime dataNasc = DateTime.Parse(tbNascimento.Text);

                char gen;

                if (rb_F.Checked)
                {
                    gen = 'F';
                }
                else
                {
                    gen = 'M';
                }


                if (string.IsNullOrEmpty(tbCodigo.Text)) //Incluir Cliente
                {
                    cliente = new Cliente(nome, cidade, email, dataNasc, gen);
                    clientes.Add(cliente);
                    tbCodigo.Text = cliente.Identificador.ToString();
                    bExcluir.Visible = true;
                    gbVoos.Visible = true;
                }
                else //Alterar Cliente
                {
                    foreach (Cliente client in clientes)
                        if (client.Identificador.ToString() == tbCodigo.Text)
                        {
                            client.Nome = nome;
                            client.CidadeOrigem = cidade;
                            client.Email = email;
                            client.DataNascimento = dataNasc;
                            client.Genero = gen;
                        }
                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Deixou algum campo sem valor");
                return;
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato errado de dado");
                return;
            }
            
            
            Centrifuga.escreverArquivo(clientes);
            atualizaVoos();
        }
        
        private void bNovo_Click(object sender, EventArgs e)
        {
            tbCodigo.Text = "";
            tbNome.Text = "";
            tbCidade.Text = "";
            tbEmail.Text = "";
            lCategoria.Text = "";
            tbNascimento.Clear();
            


            lCat.Visible = false;
            bExcluir.Visible = false;
            gbVoos.Visible = false;
            gbPontos.Visible = false;

            resetVoo();
        }
        private void resetVoo()
        {
            tbData.Text = "";
            cbProNor.SelectedIndex = 0;
            tbOrigem.Text = "";
            tcVoo.SelectedIndex = 0;
            tbComapanhia.Text = "";

            bIncluir.Enabled = true;
            bExluirVoo.Enabled = false;
            tbData.Enabled = true;
            cbProNor.Enabled = true;
            tbOrigem.Enabled = true;
        }
        private void bVoltar_Click(object sender, EventArgs e)
        {
            Principal.janela.clientesToolStripMenuItem_Click(null, null);
        }

        private void bExcluir_Click(object sender, EventArgs e)
        {
            int i = 0, index = -1;
            foreach (Cliente client in clientes)
            {
                if (client.Identificador.ToString() == tbCodigo.Text)
                    index = i;
                i++;
            }
            if (index != -1)
            {
                clientes.RemoveAt(index);
                Centrifuga.escreverArquivo(clientes);
            }
            bVoltar_Click(null, null);
        }

        private void bIncluir_Click(object sender, EventArgs e)
        {
            DateTime data;
            try
            {
                data = DateTime.Parse(tbData.Text);
            }
            catch
            {
                MessageBox.Show("Informe uma data/hora válida.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbData.Focus();
                return;
            }

            if (tbOrigem.Text == "")
            {
                MessageBox.Show("Informe a cidade de origem.");
                tbOrigem.Focus();
                return;
            }
            else if(tbComapanhia.Text == "")
            {
                MessageBox.Show("Informe a companhia.");
                tbOrigem.Focus();
                return;
            }

            int opcao2 = cbProNor.SelectedIndex+1;
            string origem = tbOrigem.Text, companhia = tbComapanhia.Text;

           
            Fruteira.calcularPontos_ult_12_meses_Cliente(data, cliente);
            Fruteira.pontuarCliente(cliente, opcao2, origem, data, companhia);

            

            try
            {
                ind = cliente.Identificador - 1;

                if (Principal.janela.pPrincipal.Controls.Count > 1)
                {
                    Grafico g = (Grafico)Principal.janela.pPrincipal.Controls[1];

                    g.carregaDados(ind);


                }
                else
                {

                    Principal.janela.addPainel(new Cadastro(ind));
                    Principal.janela.incrPainel(new Grafico(ind));
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Exceção de referência nula");
                return;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Índice fora do alcance");
                return;
            }
            
            Centrifuga.escreverArquivo(clientes);


            atualizaVoos();
            MessageBox.Show("Voo cadastrado.", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            lScoreTotal.Text = cliente.PontosAcc.ToString();
            lScore12.Text = cliente.Pontos_12.Last().Pontos.ToString();
        }
        private void atualizaVoos()
        {
            resetVoo();

            DataTable dt = new DataTable("Voos");
            dt.Columns.Add("Data", typeof(string));
            dt.Columns.Add("Origem", typeof(string));
            dt.Columns.Add("Companhia", typeof(string));
            dt.Columns.Add("Pontos", typeof(string));
            foreach (Voo voo in cliente.Voo)
                dt.Rows.Add(voo.DataMarcada, voo.Cid_origem_Voo, voo.CompanhiaVoo, voo.Pontos);
            gvVoos.DataSource = dt;
            gvVoos.Columns[0].Width = 100;
            gvVoos.Columns[1].Width = 150;
            gvVoos.Columns[2].Width = 150;
            gvVoos.Columns[3].Width = 150;
        }

        private void gvVoos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = gvVoos.CurrentRow.Index;
            cbProNor.SelectedIndex = cliente.Voo[index].Pontos >= 1000 ? 1 : 0;
            tbOrigem.Text = cliente.Voo[index].Cid_origem_Voo;
            tbData.Text = cliente.Voo[index].DataMarcada.ToString();
            tbComapanhia.Text = cliente.Voo[index].CompanhiaVoo;
            tcVoo.SelectedIndex = 1;

            bIncluir.Enabled = false;
            bExluirVoo.Enabled = true;
            tbData.Enabled = false;
            cbProNor.Enabled = false;
            tbOrigem.Enabled = false;
        }

        private void bExluirVoo_Click(object sender, EventArgs e)
        {
            foreach (Voo voo in cliente.Voo)
                if (voo.DataMarcada == DateTime.Parse(tbData.Text))
                {
                    cliente.Voo.Remove(voo);
                    break;
                }
            atualizaVoos();

        }
        private void tcVoo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tp = (TabControl)sender;
            if (tp.SelectedTab == tpVoos)
                resetVoo();
        }

        private void bNovoVoo_Click(object sender, EventArgs e)
        {
            tbData.Text = "";
            cbProNor.SelectedIndex = 0;
            tbOrigem.Text = "";
            tbComapanhia.Text = "";

            bIncluir.Enabled = true;
            bExluirVoo.Enabled = false;
            tbData.Enabled = true;
            cbProNor.Enabled = true;
            tbOrigem.Enabled = true;
        }

       
    }
}
