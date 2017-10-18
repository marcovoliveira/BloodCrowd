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
 ListDonators.Add(new BloodDonator(Convert.ToInt32(dm.Attribute("id").Value),dm.Element("Sexo").Value, dm.Element("Primeiro_Nome").Value,
 dm.Element("Ultimo_Nome").Value, dm.Element("Rua").Value, dm.Element("Cidade").Value,dm.Element("Distrito").Value, dm.Element("Codigo_Postal").Value, dm.Element("Email").Value,
 dm.Element("Username").Value, dm.Element("Password").Value, Convert.ToInt32(dm.Element("Telefone").Value),
 dm.Element("Nome_da_mae").Value, Convert.ToDateTime(dm.Element("Data_Nascimento").Value), Convert.ToInt32(dm.Element("Idade").Value),
 dm.Element("Ocupaçao").Value, dm.Element("Empresa").Value, dm.Element("Veiculo").Value, dm.Element("Tipo_Sanguineo").Value,
Convert.ToInt64(dm.Element("Peso").Value), Convert.ToInt64(dm.Element("Altura").Value), dm.Element("GUID").Value, Convert.ToDouble(dm.Element("Latitude").Value),
Convert.ToDouble(dm.Element("Longitude").Value)));
          
                }
            foreach(BloodDonator bd in ListDonators)
            {
                MessageBox.Show(bd.FirstName); 
            }
                
            }

        }
    }

