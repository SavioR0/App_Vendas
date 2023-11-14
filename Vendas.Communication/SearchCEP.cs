using System.ServiceModel;
using Vendas.Entity.Entities;

namespace Vendas.Communication
{
    public static class SearchCEP
    {
        public static Address LocalizeCEP(string cep){
            if (!string.IsNullOrWhiteSpace(cep)) 
            {
                    using (var ws = new WSCorreios.AtendeClienteClient( 
                                new BasicHttpBinding(BasicHttpSecurityMode.Transport),
                                new EndpointAddress("https://apps.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente?wsdl"))) {
                   
                    var address = ws.consultaCEP(cep.Trim());
                    if (address != null)
                    {
                        return new Address
                        {
                            State = address.uf,
                            City = address.cidade,
                            District = address.bairro,
                            Street = address.end,
                        };
                    }
                } 
            }
            return null;
        } 
    }
}
