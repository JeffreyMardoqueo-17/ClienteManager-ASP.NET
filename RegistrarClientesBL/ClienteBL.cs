using RegistrarClientesDAL.Interfaces;
using RegistroClientesEN;
using System.Collections.Generic;

namespace RegistrarClientesBL
{
    public class ClienteBL
    {
        private readonly ICliente _cliente;
        public ClienteBL(ICliente cliente)
        {
            _cliente = cliente;
        }
        public IEnumerable<Clientes> ObtenerClientes()
        {
            return _cliente.GetClientes();
        }
        public Clientes ObtenerClientespoId(int id)
        {
            return _cliente.GetClienteById(id);
        }
        public void CrearCliente(Clientes cliente)
        {
            _cliente.CrearCliente(cliente);
        }
        public void UpdateCliente(Clientes cliente)
        {
            _cliente.UpdateCliente(cliente);
        }
        public void DeleteCliente(int id)
        {
            _cliente.DeleteCliente(id);
        }
    }
}
