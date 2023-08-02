using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        
        public string Nombre
        {
            set
            {
                nombre = value;
            }

            get
            {
                return nombre;
            }
        }

        public string Apellido
        {
            set
            {
                apellido = value;
            }
            get
            {
                return apellido;
            }

        }

        public void ImprimirDatos()
        {
            Console.WriteLine("El nombre es:" + nombre);
            Console.WriteLine("El apellido es:" + apellido);
        }
    }
}
