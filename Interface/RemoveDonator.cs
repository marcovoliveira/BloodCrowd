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
        public static void RemoverDonator(int id)
        {
            
            XmlDocument doc = new XmlDocument();
            doc.Load(@"BaseDados.xml");
            XmlNode node = doc.SelectSingleNode("//Donator[@id=" + id + "]");
            XmlNode root = doc.DocumentElement;
            root.RemoveChild(node);
            doc.Save(@"BaseDados.xml");

            MessageBox.Show("Donator with id "+ id +" Removed.");

        }


    }
}
