using Interface.ServiceReference1;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        // Este metodo é responsável por decidir que tipo de exportação vai ser utilizada, json ou xml, definindo que utilizadores
        //vai exportar e a lista de donators
        public static void ExportDonator(int tipo, List<int> posicao)
        {
            string caminho;
            string caminho2;
            
            Service1Client client = new Service1Client();
            

            if (tipo == 0)
            {
                 caminho = Path("ExportDocumentXML.xml", "XML|*.xml");

                if (caminho != null)
                {
                    if (client.ExportarXML(posicao.ToArray(), caminho)) // Metodo ExportXML devolve um bool 
                    {
                        MessageBox.Show("Donators successfully exported to XML!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to export to XML!");
                    }
                }

            }
            if (tipo == 1)
            {
                caminho = Path("ExportDocumentJson.json", "JSON|*.json");

                if (caminho != null)
                {
                    if (client.ExportJSON(posicao.ToArray(), caminho))
                    {
                        MessageBox.Show("Donators successfully exported to Json!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to export to Json!");
                    }
                }
               
            }
            if (tipo == 2)
            {
                caminho = Path("ExportDocumentXML.xml", "XML|*.xml");
                caminho2 = Path("ExportDocumentJson.json", "JSON|*.json");

                if (caminho != null && caminho2 == null)
                {
                    if (client.ExportarXML(posicao.ToArray(), caminho))
                    {
                        MessageBox.Show("Donators successfully exported to XML");
                    }
                    else
                    {
                        MessageBox.Show("Failed to export to XML");
                    }
                }

                if (caminho == null && caminho2 != null)
                {
                    if (client.ExportJSON(posicao.ToArray(), caminho2))
                    {
                        MessageBox.Show("Donators successfully exported to Json");
                    }
                    else
                    {
                        MessageBox.Show("Failed to export to Json");
                    }
                }

                if (caminho != null && caminho2 != null)
                {
                    if (client.ExportarXML(posicao.ToArray(), caminho) && client.ExportJSON(posicao.ToArray(), caminho2))
                    {
                        MessageBox.Show("Donators successfully exported to XML & Json");
                    }
                    else
                    {
                        MessageBox.Show("Failed to export to XML & Json");
                    }
                }


            }
        }
        //metodo responsável por exportar em xml
        

        
        private static string Path(string placeholder, string filter)
        {
            
            SaveFileDialog sfd = new SaveFileDialog();
            string export = placeholder; 
            sfd.FileName = export;
            sfd.Filter = filter;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.InitialDirectory + sfd.FileName;
                return path;
            }
            else
            {
                MessageBox.Show("Please chose a valid path!");
                return null;
            }
        }
    }
}
    

