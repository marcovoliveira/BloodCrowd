using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    class CalculateIMC
    {
        public static double CalcularIMC(double peso, double altura)
        {
            double imc;
            imc = peso / ((altura * altura)/10000);
            return imc;

        }

    }

}
