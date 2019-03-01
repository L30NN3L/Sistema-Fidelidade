using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TI_Fidelidade
{
    class PontosAcc_12_ult_Meses
    {
        private double pontos;
        private int mes;
        private int ano;
        private DateTime mes_ano;

        private double[] pontos_Mes = new double[12];

        public DateTime Mes_Ano
        {
            set { mes_ano = value; }
            get { return mes_ano; }
        }

        public double[] Pontos_Mes
        {
            set { pontos_Mes = value; }
            get { return pontos_Mes; }
        }

        public double Pontos
        {
            set { pontos = value; }
            get { return pontos; }
        }

        public int Mes
        {
            set { mes = value; }
            get { return mes; }
        }

        public int Ano
        {
            set { ano = value; }
            get { return ano; }
        }

        public PontosAcc_12_ult_Meses(DateTime data)
        {

            this.Pontos = calculoPontos();
            for(int j=0;j<Pontos_Mes.Length; j++)
            {
                this.Pontos_Mes[j] = Calendario._Static_Pontos_Mes[j];
            }
            
            this.Mes = data.Month;
            this.Ano = data.Year;
            this.Mes_Ano = data;

        }

        public static double calculoPontos()
        {
            double pts = 0;

            for(int i = 0; i < Calendario._Static_Pontos_Mes.Length; i++)
            {
                pts += Calendario._Static_Pontos_Mes[i];
            }


            return pts;
        }

    }

    

}
