using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos numeros al azar para asignar memoriamaxima a las maquinas y asignar cuantas partes se van a procesar
            Random numero = new Random();
            int partes = numero.Next(1, 100);
            Console.WriteLine("Se van a procesar " + partes + " partes a traves de las maquinas");

            //Creamos cada maquina, asignamos su memoria maxima de manera aleatoria a cada maquina
            Recepcion recepcion = new Recepcion(numero.Next(1, 100));
            Almacenamiento almacenamiento = new Almacenamiento(numero.Next(1, 100));
            Ensamblaje ensamblaje = new Ensamblaje(numero.Next(1, 100));
            Verificacion verificacion = new Verificacion(numero.Next(1, 100));
            Empaque empaque = new Empaque(numero.Next(1, 100));

            //Iniciamos fabrica encendiendo las maquinas
            recepcion.Encendido();
            almacenamiento.Encendido();
            ensamblaje.Encendido();
            verificacion.Encendido();
            empaque.Encendido();

            Console.WriteLine();
            int i = 0;
            //el while sigue hasta que todas las partes pasan por las maquinas
            while(partes - i != 0)
            {
                if(recepcion.memoria == recepcion.memoriaMax)
                {
                    Console.WriteLine("La Memoria de la Maquina de Recepcion se ha llenado");
                    recepcion.Reinicio();  
                    Console.WriteLine();
                }
                if (almacenamiento.memoria == almacenamiento.memoriaMax)
                {
                    Console.WriteLine("La Memoria de la Maquina de Almacenamiento se ha llenado");
                    almacenamiento.Reinicio(); 
                    Console.WriteLine();
                }
                if (ensamblaje.memoria == ensamblaje.memoriaMax)
                {
                    Console.WriteLine("La Memoria de la Maquina de Ensamblaje se ha llenado");
                    ensamblaje.Reinicio();
                    Console.WriteLine();
                }
                if (verificacion.memoria == verificacion.memoriaMax)
                {
                    Console.WriteLine("La Memoria de la Maquina de Verificacion se ha llenado");
                    verificacion.Reinicio();
                    Console.WriteLine();
                }
                if (empaque.memoria == empaque.memoriaMax)
                {
                    Console.WriteLine("La Memoria de la Maquina de Empaque se ha llenado");
                    empaque.Reinicio(); 
                    Console.WriteLine();
                }
                
                //aqui hacemos que la parte pase por las maquinas               
                i ++; 
                recepcion.memoria++;
                almacenamiento.memoria++;
                ensamblaje.memoria++;
                verificacion.memoria++;
                empaque.memoria++;
            }
            //una vez termina el while ya no quedan mas partes por pasar y por tanto se termino el dia
            Console.WriteLine("Ya no Quedan Más Partes para Procesar por Hoy");
            Console.WriteLine();
            recepcion.Apagado();
            almacenamiento.Apagado();
            ensamblaje.Apagado();
            verificacion.Apagado();
            empaque.Apagado();

            Console.ReadLine();
        }
    }
}
