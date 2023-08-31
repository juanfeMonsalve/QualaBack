using QualaBack.Configuration;
using QualaBack.Model;

namespace QualaBack.Repository
{
    public class SucursalRepositoryImp : SucursalRepository
    {
        public Sucursal Delete(Sucursal sucursal)
        {
            using (var context = new ApiContext()) {
                context.Remove(sucursal);
                context.SaveChanges();
                return sucursal;
            }
        }

        public List<Sucursal> GetAll()
        {
            using (var context = new ApiContext())
            {
                return context.sucursales.ToList();
            }
        }

        public Sucursal SaveChanges(Sucursal sucursal)
        {
            using (var context = new ApiContext())
            {
                 Sucursal sucursalDb = context.Add(sucursal).Entity;
                context.SaveChanges();
                return sucursalDb;
            }
        }

        public Sucursal UpdateChanges(Sucursal sucursal)
        {
            using (var context = new ApiContext())
            {
                context.Update(sucursal);
                context.SaveChanges();
                return sucursal;
            }
        }
    }
}
