﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Almacenamiento : ComputadorCentral, IFunciones
    {
        public Almacenamiento(int memoriaMax)
        {
            this.memoriaMax = memoriaMax;
        }
        public void Encendido()
        {
            memoria = 0;
            Console.WriteLine("La Maquina de Almacenamiento se Encendio y tiene " + memoriaMax + " de Capacidad de Memoria");
        }

        public void Reinicio()
        {
            memoria = 0;
            Console.WriteLine("La Maquina de Almacenamiento se esta Reiniciando");
        }

        public void Apagado()
        {
            Console.WriteLine("La Maquina de Almacenamiento se Apago");
        }
    }
}
