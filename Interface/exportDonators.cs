using Newtonsoft.Json;
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
    // Esta é a classe responsavel por exportar os dados tanto para XML como JSON
    class ExportDonators
    {
        // Este metodo 
        public static bool ExportDonator(List<BloodDonator> donators, int tipo, int[] posicao)
        {
            if(tipo == 0)
            {
                exportXML(donators, posicao);
            }
            if(tipo == 1)
            {
                exportJSON(donators, posicao);
            }

            return true;
        }

        public static bool exportXML(List<BloodDonator> donators, int[]posicao)
        {
            int ola;
            BloodDonator oi;
            /*XmlDocument docExportar = new XmlDocument();
            XmlDeclaration decExportar = docExportar.CreateXmlDeclaration("1.0", null, null);
            docExportar.AppendChild(decExportar);
            XmlElement rootExportar = docExportar.CreateElement("DonatorsList"); // Criar um root onde os Elementos Donators irão ser introduzidos
            docExportar.AppendChild(rootExportar); */
            for(int i=0;i<posicao.Count();i++)
            {
                ola = posicao[i];
                oi = donators[ola];
                MessageBox.Show(Convert.ToString(oi));
            }

            return true;
        }

        public static bool exportJSON(List<BloodDonator> donators, int[] posicao)
        {
            return true;
        }
    }
}
