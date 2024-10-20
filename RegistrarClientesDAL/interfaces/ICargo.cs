using RegistroClientesEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarClientesDAL.interfaces
{
    public interface ICargo
    {
        IEnumerable<Cargo> GetCargos();
        Cargo ObtenerCargoByid(int id);
        void CrearCargo(Cargo cargo);
        void ActualizarCargo(Cargo cargo);
        void EliminarCargo(int id); 
    }
}
