using RegistrarClientesDAL.interfaces;
using RegistroClientesEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarClientesDAL
{
    public class CargoDAL:ICargo
    {
        private readonly DBContext _dbContext;
        public CargoDAL(DBContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public IEnumerable<Cargo> GetCargos()
        {
            return _dbContext.Cargos.ToList();
        }
        public Cargo ObtenerCargoByid(int id)
        {
            return _dbContext.Cargos.Find(id);
        }
        public void CrearCargo(Cargo cargo)
        {
            _dbContext.Cargos.Add(cargo);
        }
    }
}
