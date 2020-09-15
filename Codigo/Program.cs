using System;
using System.Collections.Generic;
using Codigo.Edificio;
using Codigo.Salon;

namespace Codigo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Codigo.Edificio.EdificioCedroMorado Edif = new Codigo.Edificio.EdificioCedroMorado();
            Edif.HacerReserva();
            Edif.HacerReserva();
            Edif.HacerReserva();
            Edif.DesplegarHorario();
            Edif.HacerReserva();
        }
    }
}