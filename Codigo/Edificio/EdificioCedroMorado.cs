using Codigo.Salon;
using Codigo.Usuario;
namespace Codigo.Edificio{

    public class EdificioCedroMorado{
        
        #region Properties
        private List<Salon> Salones;
        private List<Usuario> Usuarios;
        #endregion Properties


        #region Methods
        public EdificioCedroMorado(){
            Salones = new List<Salon>();
            Salones.Add(new Salon("402", "Disponible", false, 30, false));
            Console.Writeline(Salones[1]);
        }

        public void DesplegarHorario(){
            
        }

        public void DesplegarSalon(){
            Console.Writeline( "Escriba el ID del Salon" );
        }

        public void HacerReserva(){
            
        }

        public void CambiosAdmin(string id, string contraseña, bool admin){

        }

        #endregion Methods
    }
}