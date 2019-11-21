using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using apis.Repositories;
using apis.Models;

namespace APIS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ClienteRepository _clienteRepository;
        public HomeController( ClienteRepository clienteRepository)
        {
            this._clienteRepository = clienteRepository;
        }

        
        [Route("cliente")]
        [HttpPost]

        public void Create(Cliente cliente)
        {
            _clienteRepository.Create(cliente);
        }

        [Route("cliente")]
        [HttpGet]
        public IEnumerable<Cliente> GetCliente()
        {
            var products = _clienteRepository.GetAll();

            return products;
        }
    }
}