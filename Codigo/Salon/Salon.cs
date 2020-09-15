using System;
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
        private List<Reserva.Reserva> Reservas  = new List<Reserva.Reserva>();
        
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

            this.ID = id;
            this.Estado = est;
            this.Luz = luz;
            this.Temperatura = temp;
            this.Puerta = pu;

            Reservas.Add(new Reserva.Reserva("0000", "0000", id, "", "0000", "0000", "0000", "0000"));

        }

        public void getReservas(){
            if(Reservas.Count == 1 && Reservas[0].getHoraInicio() == "0000" && Reservas[0].getHoraFinal() == "0000"){
                Console.WriteLine("La Sala no tiene reservas.\n");
            }else{
                for( int i=0; i < Reservas.Count; i++ ){
                    Console.WriteLine(Reservas[i].getHoraInicio());
                    Console.WriteLine(Reservas[i].getHoraFinal());
                    Console.WriteLine(Reservas[i].getOcupante());
                    Console.WriteLine(Reservas[i].getDia());
                    Console.WriteLine(getTemperatura());
                    Console.WriteLine(getEstado());
                }
            }
        }

        public void setReservas(string hi, string hf, string dia, string id){
            int pl, pt, al, at;
            pl = int.Parse(hi) - 45;
            pt = int.Parse(hi) - 50;
            al = int.Parse(hf) + 10;
            at = int.Parse(hf) + 5;
            if(Reservas.Count == 1 && Reservas[0].getHoraInicio() == "0000"){
                Reservas[0].setHoraInicio(hi);
                Reservas[0].setHoraFinal(hf);
                Reservas[0].setOcupante(id);
                Reservas[0].setDia(dia);
                Reservas[0].setHoraPrenderLuz(pl.ToString());
                Reservas[0].setHoraPrenderTem(pt.ToString());
                Reservas[0].setHoraApagarLuz(al.ToString());
                Reservas[0].setHoraApagarTem(at.ToString());
                setEstado("Ocupado");
                setTemperatura(23);
                setPuerta(true);
            }else{
                Reservas.Add(new Reserva.Reserva(hi, hf, id, dia, pl.ToString(), al.ToString(), pt.ToString(), at.ToString()));
                setEstado("Ocupado");
                setTemperatura(23);
                setPuerta(true);
            }
        }
        #endregion Methods
    }
}