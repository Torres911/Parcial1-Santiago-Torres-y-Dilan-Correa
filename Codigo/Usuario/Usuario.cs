namespace Codigo.Usuario{

    public class Usuario{
        
        #region Properties

        private string ID{ get; set; }
        private string Contraseña{ get; set; }
        private bool Admin{ get; set; }
        
        #endregion Properties

        #region Methods

        public Usuario(string id, string contraseña, bool admin){
            this.ID = id;
            this.Contraseña = contraseña;
            this.Admin = admin;
        }
        
        #endregion Methods
    }
}