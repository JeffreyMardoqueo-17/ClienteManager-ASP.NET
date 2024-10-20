using RegistroClientesEN;
using System.Collections.Generic;

namespace RegistrarClientesDAL.Interfaces
{
    public interface ICliente
    {
        // Método para obtener todos los clientes en una lista
        IEnumerable<Clientes> GetClientes();

        // Método para obtener un cliente por su ID
        Clientes GetClienteById(int id);

        // Método para crear un cliente
        void CrearCliente(Clientes cliente);

        // Método para actualizar un cliente
        void UpdateCliente(Clientes cliente);

        // Método para eliminar un cliente por su ID
        void DeleteCliente(int id);
    }
}
