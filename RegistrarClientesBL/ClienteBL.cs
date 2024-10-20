using RegistrarClientesDAL.Interfaces;
using RegistroClientesEN;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RegistrarClientesBL
{
    public class ClienteBL
    {
        private readonly ICliente _cliente;

        public ClienteBL(ICliente cliente)
        {
            _cliente = cliente;
        }

        public async Task<IEnumerable<Clientes>> ObtenerClientesAsync()
        {
            return await _cliente.GetClientesAsync();
        }

        public async Task<Clientes> ObtenerClientePorIdAsync(int id)
        {
            return await _cliente.GetClienteByIdAsync(id);
        }

        public async Task CrearClienteAsync(Clientes cliente)
        {
            await _cliente.CrearClienteAsync(cliente);
        }

        public async Task ActualizarClienteAsync(Clientes cliente)
        {
            await _cliente.UpdateClienteAsync(cliente);
        }

        public async Task EliminarClienteAsync(int id)
        {
            await _cliente.DeleteClienteAsync(id);
        }
    }
}
