using Vendas.Entity.Entities;

namespace Vendas.Library
{
    public class Version
    {
        private static Version _instance { get; set; }
        public string version = "1.0.10.0 em 27/10/2023";
        
        public static Version Instance 
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Version();
                }
                return _instance;
            }
        }
    }
    public class Global
    {
        private static Global _instance { get; set; }

        public static Global Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Global();

                return _instance;
            }
        }
        public bool Distribuida { get; set; }
        public User User { get; set; } 
    }
}
