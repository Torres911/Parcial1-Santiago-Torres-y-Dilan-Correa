using System;
using System.Collections.Generic;
using Codigo.Salon;
using Codigo.Usuario;
namespace Codigo.Edificio{

    public class EdificioCedroMorado{
        
        #region Properties
        private List<Codigo.Salon.Salon> Salones;
        private List<Codigo.Usuario.Usuario> Usuarios;
        #endregion Properties


        #region Methods
        public void EdificioCedroMorado(){
            Salones = new List<Codigo.Salon.Salon>();
            Salones.Add(new Codigo.Salon.Salon("402", "Disponible", false, 30, false));
            Console.WriteLine(Salones[0]);
        }

        public void DesplegarHorario(){
            
        }

        public void DesplegarSalon(){
            Console.WriteLine( "Escriba el ID del Salon" );
        }

        public void HacerReserva(){
            
        }

        public void CambiosAdmin(string id, string contraseña, bool admin){

        }

        #endregion Methods
    }
}