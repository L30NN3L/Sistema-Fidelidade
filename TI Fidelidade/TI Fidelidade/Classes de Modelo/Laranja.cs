using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI_Fidelidade
{
    class Laranja : Voo
    {
        public override double PontosAcumulados(int i)
        {
            if (i == 1) //promocional
            {
                return 500;
            }
            else  //normal
            {
                return 1000;
            }
        }

        public override double PontosAcumulados(string tipo_Voo)
        {
            if (tipo_Voo == "Promocional") //promocional
            {
                return 500;
            }
            else  //normal
            {
                return 1000;
            }
        }

        public Laranja(int i, string origem, DateTime data, string companhia)
        {
            Voo.ContDias++;
            this.Id_Voo = Voo.ContDias;
            this.Pontos = PontosAcumulados(i);
            this.DataMarcada = data;
            this.Cid_origem_Voo = origem;
            this.CompanhiaVoo = companhia;
            if(i == 1)
            {
                this.Tipo = "Promocional";
            }
            else
            {
                this.Tipo = "Normal";
            }

        }

        public Laranja(int id_Voo, string tipoVoo, string companhiaVoo, DateTime data, string cidadeOrigem)
        {
            Voo.ContDias++;
            this.Id_Voo = id_Voo;
            this.Tipo = tipoVoo;
            this.CompanhiaVoo = companhiaVoo;
            this.DataMarcada = data;
            this.Cid_origem_Voo = cidadeOrigem;
            this.Pontos = PontosAcumulados(tipoVoo);

        }
    }
}
