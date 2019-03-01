using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI_Fidelidade
{
    abstract class Voo
    {
        protected string destino;
        protected DateTime dataMarcada;
        protected string tipo;
        protected double pontos;
        protected int id_Voo;
        protected string companhiaVoo;
        protected string cid_origem_Voo;
        private static int contDias = 0;

        public static int ContDias
        {
            set { contDias = value; }
            get { return contDias; }
        }

        public string Tipo
        {
            set { tipo = value; }
            get { return tipo; }
        }

        public int Id_Voo
        {
            set { id_Voo = value; }
            get { return id_Voo; }
        }

        public string CompanhiaVoo
        {
            set { companhiaVoo = value; }
            get { return companhiaVoo; }
        }

        public string Cid_origem_Voo
        {
            set { cid_origem_Voo = value; }
            get { return cid_origem_Voo; }
        }

        public string Destino
        {
            set { destino = value; }
            get { return destino; }
        }


        public DateTime DataMarcada
        {
            set { dataMarcada = value; }
            get { return dataMarcada; }
        }

        public double Pontos
        {
            set { pontos = value; }
            get { return pontos; }
        }

        public abstract double PontosAcumulados(int i);

        public abstract double PontosAcumulados(string tipo_Voo);
    }
}
