namespace Codigo.Reserva{
    public class Reserva{

        #region Properties

        private string HoraInicio;
        private string HoraFinal;
        private string Ocupante;
        private string Dia;
        private string HoraPrenderLuz;
        private string HoraApagarLuz;
        private string HoraPrenderTem;
        private string HoraApagarTem;

        #endregion Properties

        #region Getters & Setters

        public string getHoraInicio(){
            return HoraInicio;
        }

        public void setHoraInicio(string hi){
            this.HoraInicio = hi;
        }

        public string getHoraFinal(){
            return HoraFinal;
        }

        public void setHoraFinal(string hf){
            this.HoraFinal = hf;
        }

        public string getOcupante(){
            return Ocupante;
        }

        public void setOcupante(string oc){
            this.Ocupante = oc;
        }

        public void setDia(string dia){
            this.Dia = dia;
        }

        public string getDia(){
            return Dia;
        }

        public string getHoraPrenderLuz(){
            return HoraPrenderLuz;
        }

        public void setHoraPrenderLuz(string hpl){
            this.HoraPrenderLuz = hpl;
        }

        public string getHoraApagarLuz(){
            return HoraApagarLuz;
        }

        public void setHoraApagarLuz(string hal){
            this.HoraApagarLuz = hal;
        }

        public string getHoraPrenderTem(){
            return HoraPrenderTem;
        }

        public void setHoraPrenderTem(string hpt){
            this.HoraPrenderTem = hpt;
        }

        public string getHoraApagarTem(){
            return HoraApagarTem;
        }

        public void setHoraApagarTem(string hat){
            this.HoraApagarTem = hat;
        }

        #endregion Getters & Setters

        #region Methods
        public Reserva(string hi, string hf, string oc, string dia, string hpl, string hal, string hpt, string hat){
            this.HoraInicio = hi;
            this.HoraFinal = hf;
            this.Ocupante = oc;
            this.Dia = dia;
            this.HoraPrenderLuz = hpl;
            this.HoraApagarLuz = hal;
            this.HoraPrenderTem = hpt;
            this.HoraApagarTem = hat;
        }
        #endregion Methods
        
    }
}