using System;
using System.Collections.Generic;
using Codigo.Salon;
using Codigo.Usuario;
namespace Codigo.Edificio{

    public class EdificioCedroMorado{
        
        #region Properties
        private List<Salon.Salon> Salones;
        private List<Usuario.Usuario> Usuarios;
        #endregion Properties


        #region Methods
        public EdificioCedroMorado(){
            Salones = new List<Salon.Salon>();
            Salones.Add(new Salon.Salon("401", "Disponible", false, 30, false));
            Salones.Add(new Salon.Salon("402", "Disponible", false, 30, false));
            Salones.Add(new Salon.Salon("403", "Disponible", false, 30, false));

            Usuarios = new List<Usuario.Usuario>();
            Usuarios.Add(new Usuario.Usuario("Dilan", "1234", true));
            Usuarios.Add(new Usuario.Usuario("Santiago", "4321", false));
        }

        public void DesplegarHorario(){
            for (int i = 0; i < Salones.Count; i++){
                Console.WriteLine("**********************************");
                Console.WriteLine("Salon: "+Salones[i].getID());
                Salones[i].getReservas();
                Console.WriteLine("**********************************");
            }
        }

        public void DesplegarSalon(){
            string id = "";
            bool flag = false;
            Console.WriteLine("**********************************");
            Console.WriteLine( "Escriba el ID del Salon: " );
            id = Console.ReadLine();
            Console.WriteLine("**********************************");

            for (int i = 0; i < Salones.Count; i++){
                if(id == Salones[i].getID()){
                    Console.WriteLine("**********************************");
                    Console.WriteLine("Salon: "+Salones[i].getID());
                    Console.WriteLine("**********************************");
                    Salones[i].getReservas();
                    Console.WriteLine("**********************************");
                    flag = true;
                }
            }

            if(flag == false){
                Console.WriteLine("**********************************");
                Console.WriteLine("El salon no existe");
                Console.WriteLine("**********************************");
            }
        }

        public void HacerReserva(){
            string idname = "";
            string pw = "";
            string idsala = "";
            bool flag = false;
            bool flag2 = false;
            Console.WriteLine("**********************************");
            Console.WriteLine( "Digite su nombre: " );
            idname = Console.ReadLine();
            Console.WriteLine("**********************************");
            Console.WriteLine( "Digite su contraseña: " );
            pw = Console.ReadLine();
            Console.WriteLine("**********************************");
            for( int i=0; i < Usuarios.Count; i++ ){
                if(idname == Usuarios[i].getID() && pw == Usuarios[i].getContraseña() && Usuarios[i].getAdmin() == false){
                    Console.WriteLine("**********************************");
                    Console.WriteLine( " Digite el id de la sala: " );
                    idsala = Console.ReadLine();
                    Console.WriteLine("**********************************");
                    flag = true;
                    for (int j = 0; j < Salones.Count; j++){
                        if(idsala == Salones[j].getID() && Salones[j].getEstado() != "Mantenimiento"){
                            flag2 = true;
                            string hi, hf, dia;
                            Console.WriteLine("**********************************");
                            Console.WriteLine( "Digite el dia de la clase: " );
                            dia = Console.ReadLine();
                            Console.WriteLine("**********************************");
                            Console.WriteLine( "Digite la hora de inicio de la clase (Hora Militar): " );
                            hi = Console.ReadLine();
                            Console.WriteLine("**********************************");
                            Console.WriteLine( "Digite la hora de fin de la clase (Hora Militar): " );
                            hf = Console.ReadLine();
                            Console.WriteLine("**********************************");
                            if( Salones[j].getValidator(dia, hi, hf) == false ){
                                Console.WriteLine("**********************************");
                                Salones[j].setReservas(hi, hf, dia, idname);
                                Console.WriteLine("**********************************");
                                Salones[j].setEstado("Ocupado");
                                Salones[j].setTemperatura(23);
                                Salones[j].setPuerta(true);
                                break;
                            } else{
                                Console.WriteLine("**********************************");
                                Console.WriteLine("Ya existe una reserva");
                                Console.WriteLine("**********************************");
                            }
                        }
                    }
                    if(flag2 == false){
                        Console.WriteLine("**********************************");
                        Console.WriteLine("La sala no existe");
                        Console.WriteLine("**********************************");
                    }
                }
            }
            if(flag == false){
                Console.WriteLine("**********************************");
                Console.WriteLine("Usuario no existe");
                Console.WriteLine("**********************************");
            }
        }

        public void CambiosAdmin(){
            string idname = "";
            string idsala = "";
            string pw = "";
            Console.WriteLine("**********************************");
            Console.WriteLine( "Digite su nombre: " );
            idname = Console.ReadLine();
            Console.WriteLine("**********************************");
            Console.WriteLine( "Digite su contraseña: " );
            pw = Console.ReadLine();
            Console.WriteLine("**********************************");
            bool flag = false;
            int opc;

            string dia1, hi1,  hf1,  dia2,  hi2,  hf2, newEst;
            int newT;

            for( int i=0; i < Usuarios.Count; i++ ){
                if(idname == Usuarios[i].getID() && pw == Usuarios[i].getContraseña() && Usuarios[i].getAdmin() == true){
                    flag = true;
                    Console.WriteLine("**********************************");
                    Console.WriteLine(" Seleccione una opcion: \n 1. Modificar Reserva\n 2. Eliminar Reserva\n 3. Habilitar / Deshabilitar Mantenimiento\n 4. Salir");
                    opc = int.Parse(Console.ReadLine());
                    Console.WriteLine("**********************************");
                    do{
                        switch (opc){
                            case 1:
                            Console.WriteLine("**********************************");
                                Console.WriteLine( "Digite el id de la sala: " );
                                idsala = Console.ReadLine();
                                Console.WriteLine("**********************************");
                                Console.WriteLine( "Digite el dia de la clase: " );
                                dia1 = Console.ReadLine();
                                Console.WriteLine("**********************************");
                                Console.WriteLine( "Digite la hora de inicio de la clase (Hora Militar): " );
                                hi1 = Console.ReadLine();
                                Console.WriteLine("**********************************");
                                Console.WriteLine( "Digite la hora de fin de la clase (Hora Militar): " );
                                hf1 = Console.ReadLine();
                                Console.WriteLine("**********************************");
                                Console.WriteLine( "Digite el nuevo dia de la clase: " );
                                dia2 = Console.ReadLine();
                                Console.WriteLine("**********************************");
                                Console.WriteLine( "Digite la nueva hora de inicio de la clase (Hora Militar): " );
                                hi2 = Console.ReadLine();
                                Console.WriteLine("**********************************");
                                Console.WriteLine( "Digite la nueva hora de fin de la clase (Hora Militar): " );
                                hf2 = Console.ReadLine();
                                Console.WriteLine("**********************************");
                                Console.WriteLine( "Digite La nueva temperatura de la clase (Celsius): " );
                                newT = int.Parse(Console.ReadLine());
                                Console.WriteLine("**********************************");
                                Console.WriteLine( "Digite el nueva estado la clase (Disponible, Ocupado): " );
                                newEst = Console.ReadLine();
                                Console.WriteLine("**********************************");
                                for (int j = 0; j < Salones.Count; j++){
                                    if(idsala == Salones[j].getID()){
                                        Salones[j].modReserva(dia1, hi1, hf1, dia2, hi2, hf2);
                                        Salones[j].setEstado(newEst);
                                        Salones[j].setTemperatura(newT);
                                    }                                
                                }
                                break;
                            case 2:
                                Console.WriteLine("**********************************");
                                Console.WriteLine( " Digite el id de la sala: " );
                                idsala = Console.ReadLine();
                                Console.WriteLine("**********************************");
                                Console.WriteLine( "Digite el dia de la clase: " );
                                dia1 = Console.ReadLine();
                                Console.WriteLine("**********************************");
                                Console.WriteLine( "Digite la hora de inicio de la clase (Hora Militar): " );
                                hi1 = Console.ReadLine();
                                Console.WriteLine("**********************************");
                                Console.WriteLine( "Digite la hora de fin de la clase (Hora Militar): " );
                                hf1 = Console.ReadLine();
                                Console.WriteLine("**********************************");
                                for (int j = 0; j < Salones.Count; j++){
                                    if(idsala == Salones[j].getID()){
                                        Salones[j].removeReserva(dia1, hi1, hf1);
                                    }                                
                                }
                                break;
                            case 3:
                                Console.WriteLine("**********************************");
                                Console.WriteLine( " Digite el id de la sala: " );
                                idsala = Console.ReadLine();
                                Console.WriteLine("**********************************");
                                for (int j = 0; j < Salones.Count; j++){
                                    if(idsala == Salones[j].getID() && (Salones[j].getEstado() == "Disponible" || Salones[j].getEstado() == "Ocupado")){
                                        Salones[j].setEstado("Mantenimiento");
                                    }else{
                                        Salones[j].setEstado("Disponible");
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("**********************************");
                                Console.WriteLine("Digite una opcion valida");
                                Console.WriteLine("**********************************");
                                break;
                        }                        
                    } while (opc != 4);
                }
            }
            
            if(flag == false){
                Console.WriteLine("**********************************");
                Console.WriteLine("No es Administrador. No tiene accesso a este menu");
                Console.WriteLine("**********************************");
            }
        }

        #endregion Methods
    }
}