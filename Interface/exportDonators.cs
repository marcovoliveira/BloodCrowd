using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Interface
{
    class exportDonators
    {
        public static bool  ExportDonatorXml(int[] id, String xPath, String sitio,String nomeFicheiro, XmlDocument doc)
        {

          
            XmlNode dadosDonator;
            XmlNode root = doc.DocumentElement;
            int idSize = id.Length;
            bool a = true;

            XmlDocument docExportar = new XmlDocument();
            XmlDeclaration decExportar = docExportar.CreateXmlDeclaration("1.0", null, null);
            docExportar.AppendChild(decExportar);
            XmlElement rootExportar = docExportar.CreateElement("DonatorsList"); // Criar um root onde os Elementos Donators irão ser introduzidos
            docExportar.AppendChild(rootExportar);

            for (int i = 0; i < idSize; i++)
            {
                rootExportar.AppendChild(root.SelectSingleNode("//Donator[@id='" + id[i] + "']")); //caso seja para o utilizador escolher so o id
               
              
               
            }
            docExportar.Save(@nomeFicheiro + ".xml");
             MessageBox.Show(docExportar.OuterXml);


            return a;

            

        }
    }
}
