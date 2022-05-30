using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public class DbClients
    {
        List<Client> clientes = new List<Client>();
        

        public DbClients()
        {            
            clientes.Add(new Client(1,"Juan Pérez"));
            clientes.Add(new Client(2,"Jorge Fernández"));
            clientes.Add(new Client(3,"Bill Gates"));
        }

        public List<Client> getAllClients()
        {  
            return clientes;
        }

        public Client getClient(int id)
        {
            Client c = clientes.First(a => a.Id == id);
            return c;
        }

        public void newClient(int id, string name)
        {
            clientes.Add(new Client(id, name));            
        }

    }
}
