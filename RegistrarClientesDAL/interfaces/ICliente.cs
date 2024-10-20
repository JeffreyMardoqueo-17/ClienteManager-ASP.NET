using RegistroClientesEN;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RegistrarClientesDAL.Interfaces
{
    public interface ICliente
    {
     
        Task<IEnumerable<Clientes>> GetClientesAsync();

       
        Task<Clientes> GetClienteByIdAsync(int id);

      
        Task CrearClienteAsync(Clientes cliente);
      
        Task UpdateClienteAsync(Clientes cliente);

        Task DeleteClienteAsync(int id);
    }
}
