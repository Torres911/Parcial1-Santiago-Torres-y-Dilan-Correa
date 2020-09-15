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

            Usuarios = new List<Usuario.Usuario>();
            Usuarios.Add(new Usuario.Usuario("Dilan", "1234", true));
            Usuarios.Add(new Usuario.Usuario("Santiago", "4321", false));
        }

        public void DesplegarHorario(){
            for (int i = 0; i < Salones.Count; i++){
                Salones[i].getReservas();
            }
        }

        public void DesplegarSalon(){
            string id = "";
            bool flag = false;
            Console.WriteLine( "Escriba el ID del Salon: " );
            id = Console.ReadLine();

            for (int i = 0; i < Salones.Count; i++){
                if(id == Salones[i].getID()){
                    Salones[i].getReservas();
                    flag = true;
                }
            }

            if(flag == false){
                Console.WriteLine("El salon no existe");
            }
        }

        public void HacerReserva(){
            string idname = "";
            string pw = "";
            string idsala = "";
            bool flag = false;
            bool flag2 = false;
            Console.WriteLine( "Digite su nombre: " );
            idname = Console.ReadLine();
            Console.WriteLine( "Digite su contraseña: " );
            pw = Console.ReadLine();
            for( int i=0; i < Usuarios.Count; i++ ){
                if(idname == Usuarios[i].getID() && pw == Usuarios[i].getContraseña() && Usuarios[i].getAdmin() == false || Usuarios[i].getAdmin() == true){
                    Console.WriteLine( " Digite el id de la sala: " );
                    idsala = Console.ReadLine();
                    flag = true;
                    for (int j = 0; j < Salones.Count; j++){
                        if(idsala == Salones[j].getID() && Salones[j].getEstado() != "Mantenimiento"){
                            flag2 = true;
                            string hi, hf, dia;
                            Console.WriteLine( "Digite el dia de la clase: " );
                            dia = Console.ReadLine();
                            Console.WriteLine( "Digite la hora de inicio de la clase (Hora Militar): " );
                            hi = Console.ReadLine();
                            Console.WriteLine( "Digite la hora de fin de la clase (Hora Militar): " );
                            hf = Console.ReadLine();
                            if(Salones[j].)
                            Salones[j].setReservas(hi, hf, dia, idname);
                        }
                    }
                    if(flag2 == false){
                        Console.WriteLine("La sala no existe");
                    }
                }
            }
            if(flag == false){
                Console.WriteLine("Usuario no existe");
            }
        }

        public void CambiosAdmin(){
            string idname = "";
            string pw = "";
            Console.WriteLine( "Digite su nombre: " );
            idname = Console.ReadLine();
            Console.WriteLine( "Digite su contraseña: " );
            pw = Console.ReadLine();
            bool flag = false;

            for( int i=0; i < Usuarios.Count; i++ ){
                if(idname == Usuarios[i].getID() && pw == Usuarios[i].getContraseña() && Usuarios[i].getAdmin() == true){
                    flag = true;
                }
            }
            
            if(flag == false){
                Console.WriteLine("No es Administrador. No tiene accesso a este menu");
            }
        }

        #endregion Methods
    }
}