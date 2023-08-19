using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    public class PilaArreglo
    {
        private const int Limite = 50;
        private int pos = 0;
        private int[] arreglo;

        public PilaArreglo()
        {
            this.arreglo = new int[Limite];
        }
        public void Add(int dato)
        {
            if (Full())
            {
                Console.WriteLine("Hola Llena");
                return;
            }

            arreglo[pos++] = dato;

        }

        public void Remove()
        {
            if (Empty())
            {
                Console.WriteLine("La cola esta llena");
                return;
            }

            pos--;
            Console.WriteLine("Dato:" + arreglo[pos]);
        }

        private bool Full()
        {
            return pos == Limite;
        }

        public bool Empty()
        {
            return pos == 0;
        }

        private void Clear()
        {
            pos = 0;
        }
    }
}
