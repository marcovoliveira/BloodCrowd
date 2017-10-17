using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Interface
{
    class ExportDonators
    {
        public static bool  ExportDonatorXml(int[] id, String xPath, String sitio,String nomeFicheiro, XmlDocument doc)
        {

            XmlNode newDonator;
            XmlNode dadosDonator;
            XmlNode root = doc.DocumentElement;
            int idSize = id.Length;
            bool sucesso = true;

           // XmlNodeList ids = doc.GetElementsByTagName("id"); 

            XmlDocument docExportar = new XmlDocument();
            XmlDeclaration decExportar = docExportar.CreateXmlDeclaration("1.0", null, null);
            docExportar.AppendChild(decExportar);
            XmlElement rootExportar = docExportar.CreateElement("DonatorsList"); // Criar um root onde os Elementos Donators irão ser introduzidos
            docExportar.AppendChild(rootExportar);
            
            

            for (int i = 0; i < idSize; i++)
            {
                try
                {
                    dadosDonator = root.SelectSingleNode("//Donator[@id='" + id[i] + "']");  //Guarda em um Node os donators com um id igual ao recebido no metodo                                                                    //
                    newDonator = docExportar.ImportNode(dadosDonator, true); // Importa o node de um Documento XML diferente
                    rootExportar.AppendChild(newDonator); //Adiciona o node ao novo Documento XML 
                }
                catch (XmlException e)
                {
                    sucesso = false; 
                }
                    

            }

            try
            {
                docExportar.Save(@nomeFicheiro + ".xml");
            }
            catch (Exception ex)
            {
                sucesso = false; 
            }
           
            MessageBox.Show(docExportar.OuterXml);

            return sucesso;

        }
    }
}
