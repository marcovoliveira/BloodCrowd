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
    class ExportDonators
    {
        public static bool  ExportDonator(int[] id, int type, String caminho,String nomeFicheiro, XmlDocument doc)
        {

            XmlNode newDonator;
            XmlNode dadosDonator;
            XmlNode root = doc.DocumentElement;
            int idSize = id.Length;
            bool sucesso = true;
            string jsonText ="";

           // XmlNodeList ids = doc.GetElementsByTagName("id"); 

            XmlDocument docExportar = new XmlDocument();
            XmlDeclaration decExportar = docExportar.CreateXmlDeclaration("1.0", null, null);
            docExportar.AppendChild(decExportar);
            XmlElement rootExportar = docExportar.CreateElement("DonatorsList"); // Criar um root onde os Elementos Donators irão ser introduzidos
            docExportar.AppendChild(rootExportar);
            
            

            for (int i = 0; i < idSize; i++)
            {
                //0 for XML
                //1 for JSON
                
                try
                {
                    dadosDonator = root.SelectSingleNode("//Donator[@id='" + id[i] + "']");  //Guarda em um Node os donators com um id igual ao recebido no metodo     
                    if (type == 0)
                    {
                                                                                       //
                        newDonator = docExportar.ImportNode(dadosDonator, true); // Importa o node de um Documento XML diferente
                        rootExportar.AppendChild(newDonator); //Adiciona o node ao novo Documento XML 
                    }
                    if (type == 1)
                    {
                        jsonText += JsonConvert.SerializeXmlNode(dadosDonator);
                        
                        MessageBox.Show(jsonText);
                    }
                    
                }
                catch (XmlException e)
                {
                    sucesso = false; 
                }
                    

            }

            try
            {
                if (type == 0)
                {
                    docExportar.Save(@caminho + "/" + nomeFicheiro + ".xml");
                }
                if (type == 1)
                {
                    
                    File.WriteAllText(@caminho + "/" + nomeFicheiro + ".json",jsonText);

                }
            }
            catch (Exception ex)
            {
                sucesso = false; 
            }
           
           // MessageBox.Show(docExportar.OuterXml);

            return sucesso;

        }
    }
}
