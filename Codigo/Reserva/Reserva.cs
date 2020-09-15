namespace Codigo.Reserva{
    public class Reserva{

        #region Properties

        private int HoraInicio{ get; set; }
        private int HoraFinal{ get; set; }
        private int Ocupante{ get; set; }
        private int HoraPrenderLuz{ get; set; }
        private int HoraApagarLuz{ get; set; }
        private int HoraPrenderTem { get; set; }
        private int HoraApagarTem { get; set; } 

        #endregion Properties


        #region Getters & Setters

        public string HoraInicio{
            get { return HoraInicio; }
            set { HoraInicio = value; }
        }

        public string HoraFinal{
            get { return HoraFinal; }
            set { HoraFinal = value; }
        }

        public bool Ocupante{
            get { return Ocupante; }
            set { Ocupante = value; }
        }

        public int Temperatura{
            get { return Temperatura; }
            set { Temperatura = value; }
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
    }
}
