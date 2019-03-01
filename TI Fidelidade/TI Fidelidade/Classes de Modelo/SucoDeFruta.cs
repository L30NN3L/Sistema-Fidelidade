using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI_Fidelidade
{
    class SucoDeFruta : Voo
    {

        public SucoDeFruta(int id_Voo, string tipoVoo, string companhiaVoo, DateTime data, string cidadeOrigem, string destin, double pontos)
        {
            this.Id_Voo = id_Voo;
            this.Tipo = tipoVoo;
            this.CompanhiaVoo = companhiaVoo;
            this.DataMarcada = data;
            this.Cid_origem_Voo = cidadeOrigem;
            this.Destino = destin;
            this.Pontos = pontos;

        }

        public SucoDeFruta(int id_Voo, string tipoVoo, string companhiaVoo, DateTime data, string cidadeOrigem)
        {
            this.Id_Voo = id_Voo;
            this.Tipo = tipoVoo;
            this.CompanhiaVoo = companhiaVoo;
            this.DataMarcada = data;
            this.Cid_origem_Voo = cidadeOrigem;
           
        }

        public override double PontosAcumulados(int i)
        {
            throw new NotImplementedException();
        }

        public override double PontosAcumulados(string tipo_Voo)
        {
            throw new NotImplementedException();
        }
    }
}
