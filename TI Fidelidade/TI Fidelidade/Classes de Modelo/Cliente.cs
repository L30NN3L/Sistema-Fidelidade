using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI_Fidelidade
{
    class Cliente
    {
        private string nome;
        private string cidadeOrigem;
        private double pontosAcc;
        private static int cont;
        private int identificador;
        private string categoria;
        private char genero;
        private string email;
        private DateTime dataNascimento;
        private List<PontosAcc_12_ult_Meses> pontos_12;
        private List<Voo> voo;

        public Cliente(string nome, string cid,string email,DateTime dataNascimento,char genero)
        {
            
            this.Nome = nome;
            this.CidadeOrigem = cid;
            this.Email = email;
            this.DataNascimento = dataNascimento;
            this.Genero = genero;
            Cont++;
            identificador = Cont;
            this.Voo = new List<Voo>();
            this.Pontos_12 = new List<PontosAcc_12_ult_Meses>();
        }

        public Cliente(int identificador, string nome, string cid)
        {
            this.Identificador = identificador;
            Cont = identificador;
            this.Nome = nome;
            this.CidadeOrigem = cid;
            this.PontosAcc = 0;
            this.Voo = new List<Voo>();
            this.Pontos_12 = new List<PontosAcc_12_ult_Meses>();
        }

        public Cliente(int identificador, string nome, string cid, string email, char genero, DateTime dataNascimento)
        {

            this.Identificador = identificador;
            this.Nome = nome;
            this.CidadeOrigem = cid;
            this.Email = email;
            this.Genero = genero;
            this.DataNascimento = dataNascimento;
            this.PontosAcc = 0;
            this.Voo = new List<Voo>();
            this.Pontos_12 = new List<PontosAcc_12_ult_Meses>();

            Cont++;
        }

        public DateTime DataNascimento
        {
            set { dataNascimento = value; }
            get { return dataNascimento; }
        }

        public List<PontosAcc_12_ult_Meses> Pontos_12
        {
            set { pontos_12 = value; }
            get { return pontos_12; }
        }

        public string Email
        {
            set { email = value; }
            get { return email; }
        }

        public char Genero
        {
            set { genero = value; }
            get { return genero; }
        }

        public int Identificador
        {
            set { identificador = value; }
            get { return identificador; }

        }

        public static int Cont
        {
            set { cont = value; }
            get { return cont; }
        }

        public List<Voo> Voo
        {
            get { return voo; }
            set { voo = value; }
        }


        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string CidadeOrigem
        {
            get { return cidadeOrigem; }
            set { cidadeOrigem = value; }
        }

        public double PontosAcc
        {
            get { return pontosAcc; }
            set { pontosAcc = value; }
        }
    }
}
