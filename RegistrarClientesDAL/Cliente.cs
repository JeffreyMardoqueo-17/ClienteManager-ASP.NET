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
            return await _context.Usuarios.ToListAsync();
        }

        // Método para obtener un cliente por ID (asíncrono)
        public async Task<Clientes> GetClienteByIdAsync(int id)
        {
            return await _context.Usuarios.FindAsync(id);
        }

        // Método para crear un cliente (asíncrono)
        public async Task CrearClienteAsync(Clientes cliente)
        {
            cliente.FechaRegistro = DateTime.Now;  // Asegurarse de que la fecha de registro sea la fecha actual
            await _context.Usuarios.AddAsync(cliente);
            await _context.SaveChangesAsync();
        }

        // Método para actualizar un cliente (asíncrono)
        public async Task UpdateClienteAsync(Clientes cliente)
        {
            _context.Usuarios.Update(cliente);
            await _context.SaveChangesAsync();
        }

        // Método para eliminar un cliente por ID (asíncrono)
        public async Task DeleteClienteAsync(int id)
        {
            var cliente = await _context.Usuarios.FindAsync(id);
            if (cliente != null)
            {
                _context.Usuarios.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }
    }
}
