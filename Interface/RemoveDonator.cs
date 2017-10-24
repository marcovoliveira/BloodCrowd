using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Interface
{
    class RemoveDonator
    {
        public static void RemoverDonator(int[] posicao)
        {
            string oi="";
            XmlDocument doc = new XmlDocument();
            doc.Load(@"BaseDados.xml");
            for (int i = 0; i < posicao.Count(); i++)
            {
                XmlNodeList nodes = doc.SelectNodes("//Donator[@id=" + posicao[i] + "]");

                nodes[i].ParentNode.RemoveChild(nodes[i]);
                doc.Save(@"BaseDados.xml");
                
            }
           
        }


    }
}
