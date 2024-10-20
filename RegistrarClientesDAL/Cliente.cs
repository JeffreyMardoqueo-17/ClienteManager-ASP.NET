using Microsoft.EntityFrameworkCore;
using RegistrarClientesDAL.Interfaces;
using RegistroClientesEN;
using System.Collections.Generic;
using System.Linq;

namespace RegistrarClientesDAL
{
    public class ClienteDAL : ICliente
    {
        private readonly DBContext _context; //lo del DBContex

        public ClienteDAL(DBContext context)
        {
            _context = context;
        }

        //metodo para obtener todos los clientees
        public IEnumerable<Clientes> GetClientes()
        {
            return _context.Clientes.ToList();
        }

        // metodo para obtener un cliente por ID
        public Clientes GetClienteById(int id)
        {
            return _context.Clientes.Find(id);
        }

        // metodos para crear un cliente
        public void CrearCliente(Clientes cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        // metodo para actualizar un cliente
        public void UpdateCliente(Clientes cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }

        // metodo para eliminar un cliente por ID
        public void DeleteCliente(int id)
        {
            var cliente = _context.Clientes.Find(id); 
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
        }
    }
}
