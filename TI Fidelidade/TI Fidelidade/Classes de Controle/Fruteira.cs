using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace TI_Fidelidade
{
    class Fruteira
    {
        static public void organizarDatas_Bubble(List<Cliente> clientes)
        {

            foreach (Cliente cliente in clientes)
            {
                organizaDatas_Cliente(cliente);
            }
        }

        public static void organizaDatas_Cliente(Cliente cliente)
        {
            Voo aux_voo;

            for (int i = 0; i < cliente.Voo.Count; i++)
            {
                for (int j = 0; j < cliente.Voo.Count; j++)
                {
                    if (cliente.Voo[i].DataMarcada.CompareTo(cliente.Voo[j].DataMarcada) < 0)
                    {
                        aux_voo = cliente.Voo[i];
                        cliente.Voo[i] = cliente.Voo[j];
                        cliente.Voo[j] = aux_voo;
                    }
                }
            }
        }

        public static void pontuarVoosTodaLista(List<Cliente> clientes)
        {

            DateTime inicio;
            DateTime final;
            double anos;
            int primeiroAno;
            int l = 0;


            foreach (Cliente cliente in clientes)
            {

                if (cliente.Voo.Count != 0)
                {
                    Calendario._Static_Pontos_Mes = new double[12];
                    inicio = cliente.Voo.First().DataMarcada;
                    final = cliente.Voo.Last().DataMarcada;
                   
                    primeiroAno = cliente.Voo.First().DataMarcada.Year;

                    anos = (final.Year - inicio.Year) + 1;


                    l = 0;
                    //ESTE É O PODER DA LÓGICA!!!!!
                    for (int i = 0; i < anos; i++)                                     
                    {

                        int j = 0;

                        if (i == 0)
                        {
                            for (j = (cliente.Voo.First().DataMarcada.Month - 1); j < Calendario._Static_Pontos_Mes.Length; j++)
                            {

                                int check = Calendario._Static_Pontos_Mes.Length - (cliente.Voo.First().DataMarcada.Month - 1);

                                TURBILHAO(cliente, primeiroAno, ref i, ref j, ref l);

                            }
                        }
                        else if (i > 0 && i < (anos - 1))
                        {

                            for (j = 0; j < Calendario._Static_Pontos_Mes.Length; j++)
                            {

                                TURBILHAO(cliente, primeiroAno, ref i, ref j, ref l);

                            }


                        }
                        else if (i == anos - 1)
                        {
                            for (j = 0; j < cliente.Voo.Last().DataMarcada.Month; j++)
                            {

                                TURBILHAO(cliente, primeiroAno, ref i, ref j, ref l);

                            }
                        }


                    }
                }

                

            }





        }

        public static void TURBILHAO(Cliente cliente, int primeiroAno, ref int i, ref int j, ref int l)
        {
            Calendario._Static_Pontos_Mes[j] = 0;
            Calendar c = new GregorianCalendar();

            for (int k = 1; k <= c.GetDaysInMonth(primeiroAno + i, j + 1); k++) //OLHO DO FURACAUM!!111!!!1!!!(FÚRIA DE CÓDIGOS!!11!!11!)
            {

                DateTime data = new DateTime(primeiroAno + i, j + 1, k); //VRRRRRAAAAAAAAAAAUU!

                for (int m = 0; m < cliente.Voo.Count; m++)
                {
                    if (l < cliente.Voo.Count)
                    {



                        if (cliente.Voo[l].DataMarcada.Equals(data) && PontosAcc_12_ult_Meses.calculoPontos() < 10000 && cliente.Voo[l].DataMarcada.Equals(cliente.Voo[m].DataMarcada))
                        {

                            cliente.Voo[l] = new Laranja(cliente.Voo[l].Id_Voo, cliente.Voo[l].Tipo, cliente.Voo[l].CompanhiaVoo, cliente.Voo[l].DataMarcada, cliente.Voo[l].Cid_origem_Voo);
                            Calendario._Static_Pontos_Mes[j] += cliente.Voo[l].Pontos;
                            cliente.PontosAcc += cliente.Voo[l].Pontos;
                            cliente.Categoria = "LARANJA";
                            l++;

                        }

                        else if (cliente.Voo[l].DataMarcada.Equals(data) && PontosAcc_12_ult_Meses.calculoPontos() >= 10000 && PontosAcc_12_ult_Meses.calculoPontos() < 15000 && cliente.Voo[l].DataMarcada.Equals(cliente.Voo[m].DataMarcada))
                        {

                            cliente.Voo[l] = new Abacate(cliente.Voo[l].Id_Voo, cliente.Voo[l].Tipo, cliente.Voo[l].CompanhiaVoo, cliente.Voo[l].DataMarcada, cliente.Voo[l].Cid_origem_Voo);
                            Calendario._Static_Pontos_Mes[j] += cliente.Voo[l].Pontos;
                            cliente.PontosAcc += cliente.Voo[l].Pontos;
                            cliente.Categoria = "ABACATE";
                            l++;

                        }

                        else if (cliente.Voo[l].DataMarcada.Equals(data) && PontosAcc_12_ult_Meses.calculoPontos() >= 15000 && cliente.Voo[l].DataMarcada.Equals(cliente.Voo[m].DataMarcada))
                        {

                            cliente.Voo[l] = new Manga(cliente.Voo[l].Id_Voo, cliente.Voo[l].Tipo, cliente.Voo[l].CompanhiaVoo, cliente.Voo[l].DataMarcada, cliente.Voo[l].Cid_origem_Voo);
                            Calendario._Static_Pontos_Mes[j] += cliente.Voo[l].Pontos;
                            cliente.PontosAcc += cliente.Voo[l].Pontos;
                            cliente.Categoria = "MANGA";
                            l++;

                        }

                    }
                    else
                    {
                        break;
                    }


                }



            }


            DateTime data0 = new DateTime(primeiroAno + i, j + 1, 1);
            PontosAcc_12_ult_Meses pontos = new PontosAcc_12_ult_Meses(data0);
            cliente.Pontos_12.Add(pontos);

        }

        public static void pontuarCliente(Cliente cliente, int opcao, string origem, DateTime data, string companhia)
        {
            if (cliente.Pontos_12.Count != 0)
            {
                double pontos_ult_12_meses = cliente.Pontos_12.Last().Pontos;
                Voo voo;

                if (data.Month == cliente.Pontos_12.Last().Mes)
                {

                    if (pontos_ult_12_meses < 10000)
                    {
                        voo = new Laranja(opcao, origem, data, companhia);
                        cliente.PontosAcc += voo.Pontos;
                        cliente.Pontos_12.Last().Pontos += voo.Pontos;
                        cliente.Pontos_12.Last().Pontos_Mes[cliente.Pontos_12.Last().Mes - 1] += voo.Pontos;
                        cliente.Categoria = "LARANJA";
                        cliente.Voo.Add(voo);
                        if (cliente.Pontos_12.Last().Pontos >= 10000 && cliente.Pontos_12.Last().Pontos < 15000)
                        {
                            cliente.Categoria = "ABACATE";
                        }
                    }
                    else if (pontos_ult_12_meses >= 10000 && pontos_ult_12_meses < 15000)
                    {
                        voo = new Abacate(opcao, origem, data, companhia);
                        cliente.PontosAcc += voo.Pontos;
                        cliente.Pontos_12.Last().Pontos += voo.Pontos;
                        cliente.Pontos_12.Last().Pontos_Mes[cliente.Pontos_12.Last().Mes - 1] += voo.Pontos;
                        cliente.Categoria = "ABACATE";
                        cliente.Voo.Add(voo);
                        if (cliente.Pontos_12.Last().Pontos >= 15000)
                        {
                            cliente.Categoria = "MANGA";
                        }

                    }
                    else if (pontos_ult_12_meses >= 15000)
                    {
                        voo = new Manga(opcao, origem, data, companhia);
                        cliente.PontosAcc += voo.Pontos;
                        cliente.Pontos_12.Last().Pontos += voo.Pontos;
                        cliente.Pontos_12.Last().Pontos_Mes[cliente.Pontos_12.Last().Mes - 1] += voo.Pontos;
                        cliente.Categoria = "MANGA";
                        cliente.Voo.Add(voo);
                    }

                }
                else
                {
                    pontuarMes_anterior(data, cliente, opcao, origem, companhia);
                }


            }
            else
            {

                Voo voo;
                voo = new Laranja(opcao, origem, data, companhia);
                cliente.PontosAcc += voo.Pontos;
                Calendario._Static_Pontos_Mes = new double[12];
                Calendario._Static_Pontos_Mes[data.Month - 1] = voo.Pontos;
                PontosAcc_12_ult_Meses pontos = new PontosAcc_12_ult_Meses( new DateTime(data.Year,data.Month,data.Day));
                cliente.Pontos_12.Add(pontos);
                cliente.Voo.Add(voo);
            }





        }

        //
        public static void calcularPontos_ult_12_meses_Cliente(DateTime data, Cliente cliente)
        {

            if (cliente.Pontos_12.Count != 0)
            {

                int ultimoMes = cliente.Pontos_12.Last().Mes;
                int ultimoAno = cliente.Pontos_12.Last().Ano;

                if (ultimoMes != data.Month && ultimoAno == data.Year)
                {
                    cronometro_Mensal_Dinamico_mesmoAno(data, cliente, ultimoMes, ultimoAno);
                }
                else if (ultimoMes != data.Month && ultimoAno != data.Year)
                {
                    cronometro_Mensal_Dinamico_anosDiff(data, cliente, ultimoMes, ultimoAno);
                }else if(ultimoMes == data.Month && ultimoAno != data.Year)
                {
                    cronometro_Mensal_Dinamico_anosDiff(data, cliente, ultimoMes, ultimoAno);
                }

            }



        }

        public static void cronometro_Mensal_Dinamico_mesmoAno(DateTime data, Cliente cliente, int ultMes, int ultimoAno)
        {
            Calendario._Static_Pontos_Mes = new double[12];
            for (int i = 0; i < Calendario._Static_Pontos_Mes.Length; i++)
            {
                Calendario._Static_Pontos_Mes[i] = cliente.Pontos_12.Last().Pontos_Mes[i];
            }

            for (int j = ultMes ; j < data.Month; j++)
            {
                Calendario._Static_Pontos_Mes[j] = 0;
                PontosAcc_12_ult_Meses pontos = new PontosAcc_12_ult_Meses(new DateTime(ultimoAno, j + 1, 1));
                cliente.Pontos_12.Add(pontos);
            }

        }

        public static void cronometro_Mensal_Dinamico_anosDiff(DateTime data, Cliente cliente, int ultMes, int ultimoAno)
        {
            Calendario._Static_Pontos_Mes = new double[12];
            for (int i = 0; i < Calendario._Static_Pontos_Mes.Length; i++)
            {
                Calendario._Static_Pontos_Mes[i] = cliente.Pontos_12.Last().Pontos_Mes[i];
            }

            int anos = (data.Year - ultimoAno) + 1;

            for (int i = 0; i < anos; i++)
            {
                int j = 0;

                if (i == 0)
                {
                    for (j = ultMes; j < Calendario._Static_Pontos_Mes.Length; j++)
                    {
                        Calendario._Static_Pontos_Mes[j] = 0;
                        PontosAcc_12_ult_Meses pontos = new PontosAcc_12_ult_Meses(new DateTime(ultimoAno + i, j + 1, 1));
                        cliente.Pontos_12.Add(pontos);
                    }

                }
                else if (i < (anos - 1))
                {

                    for (j = 0; j < Calendario._Static_Pontos_Mes.Length; j++)
                    {
                        Calendario._Static_Pontos_Mes[j] = 0;
                        PontosAcc_12_ult_Meses pontos = new PontosAcc_12_ult_Meses(new DateTime(ultimoAno + i, j + 1, 1));
                        cliente.Pontos_12.Add(pontos);
                    }

                }
                else if (i == (anos - 1))
                {
                    for (j = 0; j < data.Month; j++)
                    {
                        Calendario._Static_Pontos_Mes[j] = 0;
                        PontosAcc_12_ult_Meses pontos = new PontosAcc_12_ult_Meses(new DateTime(ultimoAno + i, j + 1, 1));
                        cliente.Pontos_12.Add(pontos);
                    }
                }
            }

        }

        public static void pontuarMes_anterior(DateTime data, Cliente cliente, int opcao, string origem, string companhia)
        {
            int index = 0;
            double pontosMesExato = 0;
            Voo voo;

            for (int i = 0; i < cliente.Pontos_12.Count; i++)
            {
                if (cliente.Pontos_12[i].Mes == data.Month && cliente.Pontos_12[i].Ano == data.Year)
                {
                    index = i;
                    pontosMesExato = cliente.Pontos_12[i].Pontos;
                }
            }

            if (pontosMesExato < 10000)
            {
                voo = new Laranja(opcao, origem, data, companhia);
                cliente.PontosAcc += voo.Pontos;
                cliente.Pontos_12[index].Pontos += voo.Pontos;
                cliente.Pontos_12[index].Pontos_Mes[cliente.Pontos_12[index].Mes - 1] += voo.Pontos;
                cliente.Categoria = "LARANJA";
                cliente.Voo.Add(voo);
                if (cliente.Pontos_12[index].Pontos >= 10000 && cliente.Pontos_12.Last().Pontos < 15000)
                {
                    cliente.Categoria = "ABACATE";
                }
            }
            else if (pontosMesExato >= 10000 && pontosMesExato < 1500)
            {
                voo = new Abacate(opcao, origem, data, companhia);
                cliente.PontosAcc += voo.Pontos;
                cliente.Pontos_12[index].Pontos += voo.Pontos;
                cliente.Pontos_12[index].Pontos_Mes[cliente.Pontos_12[index].Mes - 1] += voo.Pontos;
                cliente.Categoria = "ABACATE";
                cliente.Voo.Add(voo);
                if (cliente.Pontos_12[index].Pontos >= 15000)
                {
                    cliente.Categoria = "MANGA";
                }

            }
            else if (pontosMesExato >= 15000)
            {
                voo = new Manga(opcao, origem, data, companhia);
                cliente.PontosAcc += voo.Pontos;
                cliente.Pontos_12[index].Pontos += voo.Pontos;
                cliente.Pontos_12[index].Pontos_Mes[cliente.Pontos_12[index].Mes - 1] += voo.Pontos;
                cliente.Categoria = "MANGA";
                cliente.Voo.Add(voo);

            }

            organizaDatas_Cliente(cliente);

            Calendario._Static_Pontos_Mes = new double[12];
            for (int i = 0; i < Calendario._Static_Pontos_Mes.Length; i++)
            {
                Calendario._Static_Pontos_Mes[i] = cliente.Pontos_12[index].Pontos_Mes[i];
            }

            if ((cliente.Pontos_12.Count - (index + 1)) >= 12)
            {

                for (int i = index + 1; i < cliente.Pontos_12.Count; i++)
                {

                    if (!(cliente.Pontos_12[index].Mes == cliente.Pontos_12[i].Mes))
                    {
                        Calendario._Static_Pontos_Mes[cliente.Pontos_12[i].Mes - 1] = cliente.Pontos_12[i].Pontos_Mes[cliente.Pontos_12[i].Mes - 1];

                    }
                    else
                    {
                        Calendario._Static_Pontos_Mes[cliente.Pontos_12[index].Mes - 1] += cliente.Pontos_12[i].Pontos_Mes[cliente.Pontos_12[i].Mes - 1];
                    }

                    PontosAcc_12_ult_Meses pontos = new PontosAcc_12_ult_Meses(new DateTime(cliente.Pontos_12[i].Ano, cliente.Pontos_12[i].Mes, 1));
                    cliente.Pontos_12.RemoveAt(i);
                    cliente.Pontos_12.Insert(i, pontos);


                }


            }
            else
            {
                for (int i = index + 1; i < cliente.Pontos_12.Count; i++)
                {



                    Calendario._Static_Pontos_Mes[cliente.Pontos_12[i].Mes - 1] = cliente.Pontos_12[i].Pontos_Mes[cliente.Pontos_12[i].Mes - 1];

                    PontosAcc_12_ult_Meses pontos = new PontosAcc_12_ult_Meses(new DateTime(cliente.Pontos_12[i].Ano, cliente.Pontos_12[i].Mes, 1));
                    cliente.Pontos_12.RemoveAt(i);
                    cliente.Pontos_12.Insert(i, pontos);


                }

            }

        }
    }
}
