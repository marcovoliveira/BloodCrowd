using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Interface
{
    class CreateListDonators
    {
        public static List<BloodDonator> ListDonators()
        {
            List<BloodDonator> ListDonators = new List<BloodDonator>();


            
           
            IFormatProvider culture = new System.Globalization.CultureInfo("en-US", true);

            try
            {
                XDocument doc = XDocument.Load(@"BaseDados.xml");

                foreach (var dm in doc.Descendants("Donator"))
                {
                    int id = Convert.ToInt32(dm.Attribute("id").Value);
                    String sexo = dm.Element("Sexo").Value;
                    String primeiro_nome = dm.Element("Primeiro_Nome").Value;
                    String ultimo_nome = dm.Element("Ultimo_Nome").Value;
                    String rua = dm.Element("Rua").Value;
                    String cidade = dm.Element("Cidade").Value;
                    String distrito = dm.Element("Distrito").Value;
                    String codigo_postal = dm.Element("Distrito").Value;
                    String email = dm.Element("Email").Value;
                    String username = dm.Element("Username").Value;
                    String password = dm.Element("Password").Value;
                    long telefone = Convert.ToInt64(dm.Element("Telefone").Value);
                    String nome_mae = dm.Element("Nome_da_mae").Value;
                    DateTime data_nascimento = DateTime.Parse(dm.Element("Data_Nascimento").Value, culture, DateTimeStyles.AssumeLocal);
                    int idade = Convert.ToInt32(dm.Element("Idade").Value);
                    String ocupacao = dm.Element("Ocupaçao").Value;
                    String empresa = dm.Element("Empresa").Value;
                    String veiculo = dm.Element("Veiculo").Value;
                    String tipo_sangue = dm.Element("Tipo_Sanguineo").Value;
                    double peso = Convert.ToDouble(dm.Element("Peso").Value);
                    double altura = Convert.ToDouble(dm.Element("Altura").Value);
                    String guid = dm.Element("GUID").Value;
                    String latitude = dm.Element("Latitude").Value;
                    String longitude = dm.Element("Longitude").Value;
                    double IMC = CalculateIMC.CalcularIMC(peso, altura);

                    ListDonators.Add(new BloodDonator(id, sexo, primeiro_nome, ultimo_nome, rua, cidade, distrito, codigo_postal, email, username,
                        password, telefone, nome_mae, data_nascimento, idade, ocupacao, empresa, veiculo, tipo_sangue, peso, altura,
                        guid, latitude, longitude, IMC));

                }
            }
            catch (Exception e)
            {
               

            }

            return ListDonators; 
        }

        }
    }

