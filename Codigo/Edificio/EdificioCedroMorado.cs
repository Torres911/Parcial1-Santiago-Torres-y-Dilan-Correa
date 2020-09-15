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
            Console.WriteLine( "Escriba el ID del Salon: " );
            id = Console.ReadLine();

            for (int i = 0; i < Salones.Count; i++){
                if(id == Salones[i].getID()){
                    Salones[i].getReservas();
                }
            }

        }

        public void HacerReserva(){
            string idname = "";
            string pw = "";
            string idsala = "";
            Console.WriteLine( "Digite su nombre: " );
            idname = Console.ReadLine();
            Console.WriteLine( "Digite su contraseña: " );
            pw = Console.ReadLine();
            for( int i=0; i < Usuarios.Count; i++ ){
                if(idname == Usuarios[i].getID() && pw == Usuarios[i].getContraseña() && Usuarios[i].getAdmin() == false){
                    Console.WriteLine( " Digite el id de la sala: " );
                    idsala = Console.ReadLine();
                    for (int j = 0; j < Salones.Count; j++){
                        if(idsala == Salones[j].getID() && Salones[j].getEstado() != "Mantenimiento"){
                            string hi, hf;
                            Console.WriteLine( " Digite la hora de inicio de la clase (Hora Militar): " );
                            hi = Console.ReadLine();
                            Console.WriteLine( " Digite la hora de fin de la clase (Hora Militar): " );
                            hf = Console.ReadLine();
                            Salones[j].setReservas(hi, hf, idname);
                        }
                    }
                }
            }
        }

        public void CambiosAdmin(string id, string contraseña, bool admin){

        }

        #endregion Methods
    }
}