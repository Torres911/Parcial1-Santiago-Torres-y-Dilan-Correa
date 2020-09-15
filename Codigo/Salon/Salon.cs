using Codigo.Reserva;
namespace Codigo.Salon{

    public class Salon{
        
        #region Properties

        private string ID{ get; set; }
        private string Estado{ get; set; }
        private bool Luz{ get; set; }
        private int Temperatura{ get; set; }
        private bool Puerta{ get; set; }
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

        public bool Puerta{
            get { return Puerta; }
            set { Puerta = value; }
        }
        
        #endregion Getters & Setters

        #region Methods
        public Salon(string id, string est, bool luz, int temp, bool pu){
            List<Codigo.Reserva> Reservas = new List<Codigo.Reserva>();

            this.ID = id;
            this.Estado = est;
            this.Luz = luz;
            this.Temperatura = temp;
            this.Puerta = pu;

            Reservas.Add(new Reserva(0000, 0000, id, 0000, 0000, 0000, 0000));

        }
        #endregion Methods
    }
}