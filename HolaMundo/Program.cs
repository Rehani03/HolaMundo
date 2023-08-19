using System;
using System.Collections;
using System.IO;
using System.Threading;

namespace HolaMundo
{
    class Program
    {   
        static void Main(string[] args)
        {
            ColaArreglo cola = new ColaArreglo();

            cola.Add(25);
            cola.Add(30);

            cola.Remove();
            cola.Remove();
            cola.Remove();
        }

        private static void Cola()
        {
            var palabra = string.Empty;

            Queue cola = new Queue();
            cola.Enqueue("Hola");
            cola.Enqueue("soy");
            cola.Enqueue("Angel");

            for (int i = 0; i <3; i++)
            {
                palabra = (string)cola.Dequeue();
                Console.WriteLine(palabra);
            }

            Console.ReadKey();
        }

        private static void Pila()
        {
            var palabra = string.Empty;

            Stack pila = new Stack();
            pila.Push("Hola");
            pila.Push("soy");
            pila.Push("Angel");

            Console.WriteLine(pila.Contains("soy")); //Sirve para saber si contiene ese elemento devuelve booleano
          //pila.Clear(); //Este metodo sirve para borrar la pila
         // var arreglo = pila.ToArray(); //srive para convertir a un array

            Console.WriteLine(pila.Count);

            for (int i = 0; i < 3; i++)
            {
                palabra = (string)pila.Pop();
                Console.WriteLine(palabra);
            }

            //for (int i = 0; i < arreglo.Length; i++)
            //{
            //    Console.WriteLine("Datos:" + arreglo[i].ToString());
            //}



            Console.ReadKey();
        }

        private static void ArregloLista()
        {
            var arreglo = new ArrayList();

            ArrayList array = new ArrayList()
            {
                "Juan",
                25,
                "Dominican Republic",
                "Sangre o+"

            };

            Console.WriteLine(array.Contains("Pedro"));

            ////Writting
            //arreglo.Add("Rehani");
            //arreglo.Add(true);
            //arreglo.Add(25);
            //arreglo.Add(25.50);

            ////Reading
            //Read(arreglo);

            ////Removing
            ////arreglo.Remove("Rehani"); //Por elemento pasado
            ////arreglo.RemoveAt(2); //Por indice
            //arreglo.RemoveRange(0, 4); //Por rango

            //Console.WriteLine("Despues de remover");
            //Read(arreglo);

           
        }

       

        private static void Read(ArrayList arreglo)
        {
            for (int i = 0; i < arreglo.Count; i++)
            {
                Console.WriteLine("Datos:" + arreglo[i].ToString());
            }
        }

        private static void OpenFile()
        {
            string linea = string.Empty;
            int cont = 0;

            try
            {
                StreamReader sr = new StreamReader("C:\\Users/REHANI/Desktop/Archivos/Apellidos.txt");

                linea = sr.ReadLine();

                while (linea != null)
                {
                    cont++;
                    
                    Console.WriteLine("Nombre #" + cont.ToString() +":"+linea);

                    linea = sr.ReadLine();

                }

                sr.Close();
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                
            }
        }

        private static void WriteFile()
        {
            string linea = string.Empty;

            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users/REHANI/Desktop/Archivos/Apellidos.txt");

                sw.WriteLine("Cordero");
                sw.WriteLine("Gonzalez");

                sw.Close();




                Console.ReadKey();


            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }
        }

        private static void getNames()
        {
            string line = string.Empty;
            string name = string.Empty;

            //Escribe el archivo
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users/REHANI/Desktop/Archivos/Ejercicio1.txt");

                for(int i=0; i<3; i++)
                {
                    Console.WriteLine("Nombre " + (i + 1).ToString() + ":");
                    name = Console.ReadLine();
                    sw.WriteLine(name);

                }

                sw.Close();


                //Lee el archivo
                StreamReader sr = new StreamReader("C:\\Users/REHANI/Desktop/Archivos/Ejercicio1.txt");
                line = sr.ReadLine();

                while (line != null)
                {
                   
                    Console.WriteLine("Nombre #:" + line);

                    line = sr.ReadLine();

                }

                sr.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }

        }
    }
}
