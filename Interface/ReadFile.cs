﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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
            XmlDocument doc = new XmlDocument();

            for(i=1;i<dadosSize;i++)
            {
             dados.Add(dadosPorEnter[i]);
             dadosDivididos = dados[i].Split(f);
                AddNewDonator.AddDonator(Convert.ToInt32(dadosDivididos[0]), dadosDivididos[1], dadosDivididos[2], dadosDivididos[3],
                   dadosDivididos[4], dadosDivididos[5], dadosDivididos[6], dadosDivididos[7], dadosDivididos[8],
                   dadosDivididos[9], dadosDivididos[10], Convert.ToInt64(dadosDivididos[11]), dadosDivididos[12], Convert.ToDateTime(dadosDivididos[13]),
                    Convert.ToInt32(dadosDivididos[14]), dadosDivididos[15], dadosDivididos[16], dadosDivididos[17], dadosDivididos[18],
                   float.Parse(dadosDivididos[19]), float.Parse(dadosDivididos[20]), dadosDivididos[21], Convert.ToDouble(dadosDivididos[22]),
                    Convert.ToDouble(dadosDivididos[23]), doc);
                
                //Culture info wtf
            }
           
           MessageBox.Show( dados[1]);

        }

        
    }
}
