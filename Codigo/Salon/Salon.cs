using System.Collections.Generic;
using Codigo.Reserva;
namespace Codigo.Salon{

    public class Salon{
        
        #region Properties

        private string ID;
        private string Estado;
        private bool Luz;
        private int Temperatura;
        private bool Puerta;
        private List<Reserva.Reserva> Reservas;
        
        #endregion Properties


        #region Getters & Setters

        public string getID(){
            return ID;
        }

        public void setID(string id){
            this.ID = id;
        }

        public string getEstado(){
            return Estado;
        }

        public void setEstado(string est){
            this.Estado = est;
        }

        public bool getLuz(){
            return Luz;
        }

        public void setLuz(bool luz){
            this.Luz = luz;
        }

        public int getTemperatura(){
            return Temperatura;
        }

        public void setTemperatura(int temp){
            this.Temperatura = temp;
        }

        public bool getPuerta(){
            return Puerta;
        }

        public void setPuerta(bool pu){
            this.Puerta = pu;
        }

        #endregion Getters & Setters


        #region Methods
        public Salon(string id, string est, bool luz, int temp, bool pu){
            Reservas = new List<Reserva.Reserva>();

            this.ID = id;
            this.Estado = est;
            this.Luz = luz;
            this.Temperatura = temp;
            this.Puerta = pu;

            Reservas.Add(new Reserva.Reserva(0000, 0000, id, 0000, 0000, 0000, 0000));

        }

        public List<Reserva.Reserva> getReservas(){
            return Reservas;
        }
        #endregion Methods
    }
}