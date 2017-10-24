using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Interface
{
    class RemoveDonator
    {
        public static void RemoverDonator(int[] posicao)
        {
            
            XmlDocument doc = new XmlDocument();
            doc.Load(@"BaseDados.xml");
            XmlNode node;
            XmlNode root = doc.DocumentElement;
            
            for (int i = 0; i < posicao.Count(); i++)
            {

                node = doc.SelectSingleNode("//Donator[@id=" + posicao[i] + "]");
                root.RemoveChild(node);
                doc.Save(@"BaseDados.xml");
                
            }
           
        }


    }
}
