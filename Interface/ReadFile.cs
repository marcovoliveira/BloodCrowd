using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Interface
{
    class ReadFile
    {
        public static void Devolver()
        {
            OpenFileDialog o = new OpenFileDialog();
            o.ShowDialog();
            o.DefaultExt = "*.txt";

            String receber = File.ReadAllText(o.FileName);

            char d = '\n';
            char f = '|';

            String[] dadosPorEnter = receber.Split(d);
            int dadosPorEnterSize = dadosPorEnter.Length;

            String[] dado;
            

            List<String> dados = new List<String>();
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);
            doc.AppendChild(dec);
            XmlElement root = doc.CreateElement("DonatorsList"); // Criar um root onde os Elementos Donators irão ser introduzidos
            doc.AppendChild(root);

            for (int i = 1; i < dadosPorEnterSize; i++)
            {
                dados.Add(dadosPorEnter[i]); //adicionar pessoa          
            }


            for (int j = 0; j < dados.Count-1; j++) //dados -1 para não contar o ultimo elemento da lista dados que esta em branco 
            {
                
                dado = dados[j].Split(f); //dividir pessoa por pipe

                for (int k = 0; k < dado.Length; k++)   //remove os espaços e o caracter especial no 1
                {
                   dado[k] = Regex.Replace(dado[k], @"\s+", ""); //remove espaços
                   dado[0] = Regex.Replace(dado[0], @"§", "");   //remove caracter especial que apenas aparece no primeiro elemento
                }

                //chamada do Metodo AddDonator a cada iteração que ira introduzir um Elemento Donator na DonatorsList
                root.AppendChild(AddNewDonator.AddDonator(dado[0], dado[1], dado[2], dado[3],
                    dado[4], dado[5], dado[6], dado[7], dado[8],
                    dado[9], dado[10], dado[11], dado[12], dado[13],
                    dado[14], dado[15], dado[16], dado[17], dado[18],
                    dado[19], dado[20], dado[21], dado[22],
                    dado[23], doc));





            }
            
           // MessageBox.Show(doc.OuterXml);

            doc.Save(@"teste2.xml"); //guardar o documento XML
            int[] a = { 1,2,3 };
 
            exportDonators.ExportDonatorXml(a,"ola","ola","ficheiroXML",doc); //para testar um export
            
        }
        }      
    }
