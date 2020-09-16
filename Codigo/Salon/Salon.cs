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

        public bool getValidator(string dia, string hi, string hf){
            bool flag = false;

            for(int i=0; i < Reservas.Count; i++){
                if(Reservas[i].getDia() == dia && Reservas[i].getHoraInicio() == hi && 
                    Reservas[i].getHoraFinal() == hf){
                    return flag = true;
                }
            }


            return flag;
        }

        public void modReserva(string dia1, string hi1, string hf1, string dia2, string hi2, string hf2){
            for(int i=0; i < Reservas.Count; i++){
                if(Reservas[i].getDia() == dia1 && Reservas[i].getHoraInicio() == hi1 && Reservas[i].getHoraFinal() == hf1){
                    Reservas[i].setDia(dia2);
                    Reservas[i].setHoraInicio(hi2);
                    Reservas[i].setHoraFinal(hf2);
                    ordenarReservas();
                }
            }
            Console.WriteLine("**********************************");
            Console.WriteLine(" Modificacion exitosa. \n");
            Console.WriteLine("**********************************");
        }

        public void removeReserva(string dia, string hi, string hf){
            for(int i=0; i < Reservas.Count; i++){
                if(Reservas[i].getDia() == dia && Reservas[i].getHoraInicio() == hi && Reservas[i].getHoraFinal() == hf){
                    Reservas.RemoveAt(i);
                } 
            }
        }

        public void getReservas(){
            if(Reservas.Count == 1 && Reservas[0].getHoraInicio() == "0000" && Reservas[0].getHoraFinal() == "0000"){
                Console.WriteLine("La Sala no tiene reservas.");
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

        public void ordenarHorayTemp(){
            for( int i=0; i < Reservas.Count-1; i++ ){
                if(Reservas[i].getHoraInicio() == Reservas[i+1].getHoraFinal()){
                    Reservas[i].setHoraApagarLuz("NULL");
                    Reservas[i].setHoraApagarTem("NULL");
                    Reservas[i+1].setHoraPrenderLuz("NULL");
                    Reservas[i+1].setHoraPrenderTem("NULL");
                }
            }
        }
        public void ordenarReservas(){
            int hora;
            for( int i=0; i < Reservas.Count-1; i++ ){
                hora = int.Parse(Reservas[i].getHoraInicio());
                for( int j=i+1; j < Reservas.Count; j++ ){
                    if( hora > int.Parse(Reservas[j].getHoraInicio()) ){
                        string val1, val2, val3, val4, val5, val6, val7, val8;
                        val1 = Reservas[i].getHoraInicio();
                        val2 = Reservas[i].getHoraFinal();
                        val3 = Reservas[i].getOcupante();
                        val4 = Reservas[i].getDia();
                        val5 = Reservas[i].getHoraPrenderLuz();
                        val6 = Reservas[i].getHoraPrenderTem();
                        val7 = Reservas[i].getHoraApagarLuz();
                        val8 = Reservas[i].getHoraApagarTem();
                        Reservas[i].setHoraInicio(Reservas[j].getHoraInicio());
                        Reservas[i].setHoraFinal(Reservas[j].getHoraFinal());
                        Reservas[i].setOcupante(Reservas[j].getOcupante());
                        Reservas[i].setDia(Reservas[j].getDia());
                        Reservas[i].setHoraPrenderLuz(Reservas[j].getHoraPrenderLuz());
                        Reservas[i].setHoraPrenderTem(Reservas[j].getHoraPrenderTem());
                        Reservas[i].setHoraApagarLuz(Reservas[j].getHoraApagarLuz());
                        Reservas[i].setHoraApagarTem(Reservas[j].getHoraApagarTem());
                        Reservas[j].setHoraInicio(val1);
                        Reservas[j].setHoraFinal(val2);
                        Reservas[j].setOcupante(val3);
                        Reservas[j].setDia(val4);
                        Reservas[j].setHoraPrenderLuz(val5);
                        Reservas[j].setHoraPrenderTem(val6);
                        Reservas[j].setHoraApagarLuz(val7);
                        Reservas[j].setHoraApagarTem(val8);                    
                    }
                }
            }
            ordenarHorayTemp();
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
            }else{
                Reservas.Add(new Reserva.Reserva(hi, hf, id, dia, pl.ToString(), al.ToString(), pt.ToString(), at.ToString()));
                ordenarReservas();
            }
        }

        
        #endregion Methods
    }
}