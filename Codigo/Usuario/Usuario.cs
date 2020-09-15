namespace Codigo.Usuario{

    public class Usuario{
        
        #region Properties

        private string ID{ get; set; }
        private string Contraseña{ get; set; }
        private bool Admin{ get; set; }
        
        #endregion Properties

        #region Getters & Setters

        public string getID(){
            return ID;
        }

        public void setID(string id){
            this.ID = id;
        }

        public string getContraseña(){
            return Contraseña;
        }


        public bool getAdmin(){
            return Admin;
        }

        #endregion Getters & Setters


        #region Methods

        public Usuario(string id, string contraseña, bool admin){
            this.ID = id;
            this.Contraseña = contraseña;
            this.Admin = admin;
        }

        #endregion Methods
    }
}