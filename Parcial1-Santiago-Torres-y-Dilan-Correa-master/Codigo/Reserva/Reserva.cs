namespace Codigo.Salon{

    public class Salon{
        
        #region Properties

        private int HoraInicio{ get; set; }
        private int HoraFinal{ get; set; }
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
    }
}