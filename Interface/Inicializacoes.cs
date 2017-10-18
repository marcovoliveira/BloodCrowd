using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Interface
{
    class Inicializacoes
    {
        public static void Iniciar()
        {
            List<BloodDonator> ListDonators = new List<BloodDonator>();

            XDocument doc = XDocument.Load(@"teste2.xml");

            foreach (var dm in doc.Descendants("Donator"))
            {
                ListDonators.Add(new BloodDonator(Convert.ToInt32(dm.Attribute("id").Value), ));
//                
//                    dm.Attribute("id").Value,
//                    dm.Element("Sexo").Value,
//                    dm.Element("Primeiro_Nome").Value +" "+ dm.Element("Ultimo_Nome").Value,
//                    dm.Element("Idade").Value,
//                    dm.Element("Tipo_Sanguineo").Value,
//                    dm.Element("Telefone").Value,
//                    dm.Element("Cidade").Value
                }
                
            }

        }
    }
}
