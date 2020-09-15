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