using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    class ReadFile
    {
        public static void Devolver()
        {
            OpenFileDialog o = new OpenFileDialog();
            o.ShowDialog();
            o.DefaultExt = "*.txt";
            String receber = File.ReadAllText(o.FileName);
            char d = '\n';
            char f = '|';
            String[] dadosPorEnter = receber.Split(d);
            int dadosSize = dadosPorEnter.Length;
            String[] dadosDivididos;
            int i;

            List<String> dados = new List<String>();
            

            for(i=1;i<dadosSize;i++)
            {
             dados.Add(dadosPorEnter[i]);
             dadosDivididos = dados[i].Split(f);
                AddDonator(dadosDivididos[0], dadosDivididos[1], dadosDivididos[2], dadosDivididos[3],
                   dadosDivididos[4], dadosDivididos[5], dadosDivididos[6], dadosDivididos[7], dadosDivididos[8],
                   dadosDivididos[9], dadosDivididos[10], dadosDivididos[11], dadosDivididos[12], dadosDivididos[13],
                   dadosDivididos[14], dadosDivididos[15], dadosDivididos[16], dadosDivididos[17], dadosDivididos[18],
                   dadosDivididos[19], dadosDivididos[20], dadosDivididos[21], dadosDivididos[22], dadosDivididos[23]);
                
            }
           
           MessageBox.Show( dados[1]);

        }

        
    }
}
