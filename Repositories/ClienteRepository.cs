using apis.Models;
using APIS.Data;
using System.Collections.Generic;

namespace apis.Repositories
{
    public class ClienteRepository
    {
        private readonly StoreDataContext _dataContext;

        public ClienteRepository(StoreDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _dataContext.Clientes;
        }

        public void Create(Cliente cliente)
        {
            _dataContext.Clientes.Add(cliente);
            _dataContext.SaveChanges();
        }
    }
}
