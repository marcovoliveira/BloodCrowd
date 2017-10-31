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
        public static bool RemoverDonator(int id)
        {
            bool sucesso = true; 
            try
            {

                XmlDocument doc = new XmlDocument();
                doc.Load(@"BaseDados.xml");
                XmlNode node = doc.SelectSingleNode("//Donator[@id=" + id + "]");
                XmlNode root = doc.DocumentElement;
                root.RemoveChild(node);
                doc.Save(@"BaseDados.xml");


            }
            catch (Exception e)
            {
                sucesso = false; 
            }


            return sucesso;
        }


    }
}
