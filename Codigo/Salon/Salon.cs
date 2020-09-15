namespace Codigo.Salon{

    public class Salon{
        
        #region Properties

        private string ID{ get; set; }
        private string Estado{ get; set; }
        private bool Luz{ get; set; }
        private int Temperatura{ get; set; }
        private List<Reserva> Reservas;
        
        #endregion Properties


        #region Getters & Setters
        
        public string ID{
            get { return ID; }
            set { ID = value; }
        }
        
        public string Estado{
            get { return Estado; }
            set { Estado = value; }
        }
        
        public bool Luz{
            get { return Luz; }
            set { Luz = value; }
        }
        
        public int Temperatura{
            get { return Temperatura; }
            set { Temperatura = value; }
        }
        
        #endregion Getters & Setters


        #region Methods
        
        public void HacerReserva(){

        }

        public void MostrarReserva(){

        }

        public void CambiosAdmin(string id; string contraseña; bool admin){

        }

        #endregion Methods
    }
}