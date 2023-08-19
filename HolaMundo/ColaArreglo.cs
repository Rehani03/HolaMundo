using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    
    public class ColaArreglo
    {

        private const int Limite = 50;
        private int pos = 0;
        private int head = 0;
        private int[] arreglo;

        public ColaArreglo()
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

            Console.WriteLine("Dato:" + arreglo[head++]);
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
