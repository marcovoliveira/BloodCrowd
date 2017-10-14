using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
            int dadosSize = dadosPorEnter.Length;
            String[] dado;
            int i;

            List<String> dados = new List<String>();
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);
            doc.AppendChild(dec);

            for (i = 1; i < dadosSize; i++)
            {
                dados.Add(dadosPorEnter[i]); //adicionar pessoa
               
            }

            int dadosSize2 = dados.Count;
            for (i = 0; i < dadosSize2; i++)
            {
                
                dado = dados[i].Split(f); //dividir pessoa por pipe
                AddNewDonator.AddDonator(dado[0], dado[1], dado[2], dado[3],
                       dado[4], dado[5], dado[6], dado[7], dado[8],
                       dado[9], dado[10], dado[11], dado[12], dado[13],
                        dado[14], dado[15], dado[16], dado[17], dado[18],
                       dado[19],dado[20], dado[21], dado[22],
                        dado[23], doc);
                

                
            }
            doc.AppendChild(doc);
            MessageBox.Show(doc.InnerXml);
           

            }
        }

        
    }
