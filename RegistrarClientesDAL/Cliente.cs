using Microsoft.EntityFrameworkCore;
using RegistrarClientesDAL.Interfaces;
using RegistroClientesEN;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrarClientesDAL
{
    public class ClienteDAL : ICliente
    {
        private readonly DBContext _context;

        public ClienteDAL(DBContext context)
        {
            _context = context;
        }

        // Método para obtener todos los clientes (asíncrono)
        public async Task<IEnumerable<Clientes>> GetClientesAsync()
        {
            return await _context.Clientes.ToListAsync();
        }

        // Método para obtener un cliente por ID (asíncrono)
        public async Task<Clientes> GetClienteByIdAsync(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }

        // Método para crear un cliente (asíncrono)
        public async Task CrearClienteAsync(Clientes cliente)
        {
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
        }

        // Método para actualizar un cliente (asíncrono)
        public async Task UpdateClienteAsync(Clientes cliente)
        {
            _context.Clientes.Update(cliente);
            await _context.SaveChangesAsync();
        }

        // Método para eliminar un cliente por ID (asíncrono)
        public async Task DeleteClienteAsync(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }
    }
}
