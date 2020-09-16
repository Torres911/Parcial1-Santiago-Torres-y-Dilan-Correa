using System;
using System.Collections.Generic;
using Codigo.Edificio;
using Codigo.Salon;

namespace Codigo
{
    class Program
    {
        static void Main(string[] args){
            Codigo.Edificio.EdificioCedroMorado Edif = new Codigo.Edificio.EdificioCedroMorado();
            int opc;
            do{
                Console.WriteLine("**********************************");
                Console.WriteLine(" Seleccione una opcion: \n 1. Crear Reserva\n 2. Mostrar todo el horario\n 3. Mostrar horario salon\n 4. Modificar Horario Administrador\n 5. Salir");
                opc = int.Parse(Console.ReadLine());
                Console.WriteLine("**********************************");
                switch (opc){
                    case 1:
                        Edif.HacerReserva();
                        break;

                    case 2:
                        Edif.DesplegarHorario();
                        break;

                    case 3:
                        Edif.DesplegarSalon();
                        break;

                    case 4:
                        Edif.CambiosAdmin();
                        break;
                    
                    default:
                        Console.WriteLine("**********************************");
                        Console.WriteLine("    Digite una opcion valida.     ");
                        Console.WriteLine("**********************************");
                        break;
                }
            }while(opc != 5);
        }
    }
}