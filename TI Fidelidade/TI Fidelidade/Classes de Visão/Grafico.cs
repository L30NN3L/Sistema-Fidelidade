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
    public partial class Grafico : UserControl
    {
        public Grafico()
        {
            InitializeComponent();
            
        }

        public Grafico(int index)
        {
            InitializeComponent();
            carregaDados(index);
        }

        private void Grafico_Load(object sender, EventArgs e)
        {
 

        }

        public void carregaDados(int index)
        {

          List<Cliente>  clientes = Principal.janela.Clientes;
          Cliente cliente = clientes.ElementAt(index);

            Analise.Series[0].Points.Clear();
            Analise.ChartAreas[0].AxisX.MinorGrid.Interval = 1;
            Analise.ChartAreas[0].AxisX.MinorGrid.Enabled = true;
            Analise.ChartAreas[0].AxisX.Interval = 1;
           
            Analise.ChartAreas[0].AxisX.IntervalOffset = 1;




            for (int i =0; i < cliente.Pontos_12.Count; i++)
                {
                    Analise.Series[0].Points.Add(cliente.Pontos_12[i].Pontos);
               // Analise.Series[0].Points[i].AxisLabel = cliente.Pontos_12[i].Mes_Ano.ToString("MMM");


            }
            
            Analise.ChartAreas[0].AxisX.Title = "Meses";
            Analise.ChartAreas[0].AxisY.Title = "Pontos";
            
            //Analise.Series[0].IsValueShownAsLabel = true;
            Analise.Series[0].IsVisibleInLegend = true;
            
        }

  
    }

    
}
