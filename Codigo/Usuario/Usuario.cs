namespace Codigo.Usuario{

    public class Usuario{
        
        #region Properties

        private string ID{ get; set; }
        private string Contraseña{ get; set; }
        private bool Admin{ get; set; }
        
        #endregion Properties
        

        #region Getters & Setters
        
        public string ID{
            get { return ID; }
            set { ID = value; }
        }
        
        public string Contraseña{
            get { return Contraseña; }
            set { Contraseña = value; }
        }
        
        public bool Admin{
            get { return Admin; }
            set { Admin = value; }
        }
        
        #endregion Getters & Setters
    }
}