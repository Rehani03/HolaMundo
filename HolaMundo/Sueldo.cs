using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    public class Sueldo
    {
        private double SueldoBase = 0;
        private const double afp = 0.0287;
        private const double ars = 0.0304;

        public Sueldo(double sueldo)
        {
            this.SueldoBase = sueldo;
        }
        public double CalculoAFP()
        {
            double resultado = SueldoBase * afp;

            return resultado;
        }

        public double CalculoARS()
        {
            double resultado = SueldoBase * ars;

            return resultado;
        }

        public double CalculoISR(double ARS, double AFP)
        {
            double resultado, salario, SalarioAnual;

            resultado = ARS + AFP;
            salario = SueldoBase - resultado;
            SalarioAnual = salario * 12;

            if (SalarioAnual <= 416220.00)
                return (0);
            else
            if (SalarioAnual >= 416220.01 || SalarioAnual <= 624329.00)
                return ((SalarioAnual - 416220.01) * 0.15) / 12;
            else
            if (SalarioAnual >= 624329.01 || SalarioAnual <= 867123.00)
                return (((SalarioAnual - 624329.01) * 0.20) + 31216.00) / 12;
            else
            if (SalarioAnual >= 867123.01)
                return (((SalarioAnual - 867123.01) * 0.25) + 79.776) / 12;

            return 0;
           
        }

    }
}
