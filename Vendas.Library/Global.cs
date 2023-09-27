using Vendas.Entity.Entities;

namespace Vendas.Library
{
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
