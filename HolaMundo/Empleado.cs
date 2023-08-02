using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    public class Empleado : Persona
    {
        protected double sueldo;
       public double Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }
        new public void ImprimirDatos()
        {
            base.ImprimirDatos();
            Console.WriteLine("El sueldo es:" + sueldo.ToString());
        }
    }
}
