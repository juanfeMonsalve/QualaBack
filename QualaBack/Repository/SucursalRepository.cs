using QualaBack.Model;

namespace QualaBack.Repository
{
    public interface SucursalRepository
    {
        public List<Sucursal> GetAll();
        public Sucursal SaveChanges(Sucursal sucursal);
        public Sucursal UpdateChanges(Sucursal sucursal);
        public Sucursal Delete(Sucursal sucursal);

    }
}
