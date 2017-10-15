using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Interface
{
    class exportDonators
    {
        public static  XmlNodeList ExportDonatorXml(int id, String xPath, String sitio, XmlDocument doc)
        {
           
            XmlNodeList dadosDonator;
            XmlNode root = doc.DocumentElement;

            dadosDonator = root.SelectNodes("//Donator[@id='"+id+"']"); //caso seja para o utilizador escolher so o id
          //dadosDonator = root.SelectNodes(xPath + "[@id =" + id + "]");
          
            foreach (XmlNode item in dadosDonator)//so para testar o output na consola
            {
                Console.WriteLine(item.InnerText);
            }

            return dadosDonator;
        }
    }
}
