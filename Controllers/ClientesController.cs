using DemoWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoWebAPI.Controllers
{
    public class ClientesController : ApiController
    {
        private static List<Cliente> clientes = new List<Cliente>();

        //1 metodo do API
        public List<Cliente> Get()
        {
            return clientes;
        }

        public void Post(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                clientes.Add(new Cliente(nome));
            }
            
        }

        public void Delete(string nome)
        {
            //utilizamos linq com expressao lambida
            clientes.RemoveAt(clientes.IndexOf(clientes.First(x => x.Nome.Equals(nome))));
        }
    }
}
