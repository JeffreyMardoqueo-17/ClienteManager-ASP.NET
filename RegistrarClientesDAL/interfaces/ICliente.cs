using RegistroClientesEN;

namespace RegistrarClientesDAL.interfaces
{
    public interface ICliente
    {
        //metodo para traerlos a todos en listas
        IEnumerable<Clientes> GetClientes();

        //PARA TARER POR ID
        Clientes GetClientes(int id);

        //metodo para crear un Cliente
        void CrearCliente(int id);
        //metodo para actualizar
        void UpdateCliente(int id);
        //metodo para eliminar
        void DeleteCliente(int id);
    }
}
