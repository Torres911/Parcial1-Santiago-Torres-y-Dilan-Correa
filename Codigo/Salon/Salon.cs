using System.Collections.Generic;
using Codigo.Reserva;
namespace Codigo.Salon{

    public class Salon{
        
        #region Properties

        private string ID{ get; set; }
        private string Estado{ get; set; }
        private bool Luz{ get; set; }
        private int Temperatura{ get; set; }
        private bool Puerta{ get; set; }
        private List<Codigo.Reserva.Reserva> Reservas;
        
        #endregion Properties


        #region Methods
        public Salon(string id, string est, bool luz, int temp, bool pu){
            Reservas = new List<Codigo.Reserva.Reserva>();

            this.ID = id;
            this.Estado = est;
            this.Luz = luz;
            this.Temperatura = temp;
            this.Puerta = pu;

            Reservas.Add(new Codigo.Reserva.Reserva(0000, 0000, id, 0000, 0000, 0000, 0000));

        }
        #endregion Methods
    }
}