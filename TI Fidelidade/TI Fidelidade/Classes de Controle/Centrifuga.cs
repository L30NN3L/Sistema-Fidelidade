using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TI_Fidelidade
{
    class Centrifuga
    {

        public static void escreverArquivo(List<Cliente> clientes)
        {

            string arquivo = "ArquivoCliente.csv";
            string arquivo2 = "Arquivo Voo.csv";

            StreamWriter earquivo = new StreamWriter(arquivo);
            earquivo.WriteLine("CodCliente,NomeCliente,CidadeOrigem,email,Genero,DataNascimento");
            for (int i = 0; i < clientes.Count; i++)
            {
                earquivo.WriteLine(clientes.ElementAt(i).Identificador + ","
                    + clientes.ElementAt(i).Nome.Replace(",", "&Semicolon") + ","
                    + clientes.ElementAt(i).CidadeOrigem.Replace(",", "&Semicolon") + ","
                    + clientes.ElementAt(i).Email.Replace(",", "&Semicolon") + ","
                    + clientes.ElementAt(i).Genero + ","
                    + clientes.ElementAt(i).DataNascimento);
            }

            earquivo.Close();

            StreamWriter earquivo2 = new StreamWriter(arquivo2);
            earquivo2.WriteLine("idVoo, CodCliente, TipoVoo, CompanhiaVoo, DataVoo, CidadeOrigem");

            for (int j = 0; j < clientes.Count; j++)
            {
                Cliente cliente = clientes.ElementAt(j);

                for (int k = 0; k < cliente.Voo.Count; k++)
                {
                    earquivo2.WriteLine(
                          cliente.Voo.ElementAt(k).Id_Voo + ","
                        + clientes.ElementAt(j).Identificador + "," 
                        + cliente.Voo.ElementAt(k).Tipo + ","
                        + cliente.Voo.ElementAt(k).CompanhiaVoo.Replace(",", "&Semicolon") + ","
                        + cliente.Voo.ElementAt(k).DataMarcada.ToString("d") + ","
                        + cliente.Voo.ElementAt(k).Cid_origem_Voo.Replace(",", "&Semicolon"));
                }

            }

            earquivo2.Close();

        }


        public static void lerArquivo(List<Cliente> clientes)
        {
            string arquivo = "ArquivoCliente.csv";
            string arquivo2 = "Arquivo Voo.csv";
            string[] linha;

            clientes.Clear();
            if (File.Exists(arquivo) && File.Exists(arquivo2))
            {
                StreamReader larquivo = new StreamReader(arquivo);
                larquivo.ReadLine();
                while (!larquivo.EndOfStream)
                {

                    linha = larquivo.ReadLine().Split(',');
                    Cliente cliente = new Cliente(
                        int.Parse(linha[0]), //Identificador 
                        linha[1].Replace("&Semicolon", ";"),  //Nome 
                        linha[2].Replace("&Semicolon", ";"),  //Cidade de Origem   
                        linha[3], //Email
                        char.Parse(linha[4]),  //Gênero   
                        DateTime.Parse(linha[5]));  //Data de Nascimento


                    clientes.Add(cliente);

                }
                larquivo.Close();


                for (int i = 0; i < clientes.Count; i++)
                {
                    StreamReader larquivo2 = new StreamReader(arquivo2);

                    Cliente client = clientes.ElementAt(i);
                    larquivo2.ReadLine();
                    while (!larquivo2.EndOfStream)
                    {
                        
                        linha = larquivo2.ReadLine().Split(',');
                        if (client.Identificador.Equals(int.Parse(linha[1])))
                        {
                            Voo voo = new SucoDeFruta(int.Parse(linha[0]), //Id_Voo
                                linha[2].Replace("&Semicolon", ";"), //Tipo_Voo 
                               linha[3], //CompanhiaVoo
                               DateTime.Parse(linha[4]), //DataMarcada
                               linha[5]); //Cidade_Origem_Voo
                            client.Voo.Add(voo);
                            //client.PontosAcc += voo.Pontos;
                        }

                    }
                    Voo.ContDias = 0; 
                  
                    larquivo2.Close();
                }
            }
            else
            {
                StreamWriter earquivo = new StreamWriter(arquivo);
                earquivo.Close();

                StreamWriter earquivo2 = new StreamWriter(arquivo2);
                earquivo2.Close();

            }


        }
    }
}
