namespace Codigo.Reserva{
    public class Reserva{

        #region Properties

        private int HoraInicio{ get; set; }
        private int HoraFinal{ get; set; }
        private string Ocupante{ get; set; }
        private int HoraPrenderLuz{ get; set; }
        private int HoraApagarLuz{ get; set; }
        private int HoraPrenderTem { get; set; }
        private int HoraApagarTem { get; set; } 

        #endregion Properties


        #region Getters & Setters

        public int HoraInicio{
            get { return HoraInicio; }
            set { HoraInicio = value; }
        }

        public int HoraFinal{
            get { return HoraFinal; }
            set { HoraFinal = value; }
        }

        public string Ocupante{
            get { return Ocupante; }
            set { Ocupante = value; }
        }

        public int HoraPrenderLuz{
            get { return HoraPrenderLuz; }
            set { HoraPrenderLuz = value; }
        }

        public int HoraApagarLuz{
            get { return HoraApagarLuz; }
            set { HoraApagarLuz = value; }
        }

        public int HoraPrenderTem{
            get { return HoraPrenderTem; }
            set { HoraPrenderTem = value; }
        }

        public int HoraApagarTem{
            get { return HoraApagarTem; }
            set { HoraApagarTem = value; }
        }
        #endregion Getters & Setters

        #region Methods
        public Reserva(int hi, int hf, string oc, int hpl, int hal, int hpt, int hat){
            this.HoraInicio = hi;
            this.HoraFinal = hf;
            this.Ocupante = oc;
            this.HoraPrenderLuz = hpl;
            this.HoraApagarLuz = hal;
            this.HoraPrenderTem = hpt;
            this.HoraApagarTem = hat;
        }
        #endregion Methods
        
    }
}