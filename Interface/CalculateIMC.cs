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
            if (imc <= 16)
            {
                return imc;
                MessageBox.Show("Baixo peso severo");
            }
            if (imc <= 17 && 16 >= imc)
            {
                return imc;
                MessageBox.Show("Baixo peso");
            }
            if (18 <= imc && imc <= 25)
            {
                return imc;
                MessageBox.Show("Peso ideal");
            }
            if (imc < 40 && imc > 25)
            {
                return imc;
                MessageBox.Show("Pré-Obesidade");
            }
            if (imc >= 40)
            {
                return imc;
                MessageBox.Show("Obesidade");
            }
            return imc;

        }

    }

}
