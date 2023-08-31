using QualaBack.Dto;
using QualaBack.Model;

namespace QualaBack.Service
{
    public interface SucursalService
    {
        public SucursalDto CreateSucursal(SucursalDto sucursal);
        public SucursalDto UpdateSucursal(SucursalDto sucursal);
        public Sucursal DeleteSucursal(SucursalDto sucursal);
        public List<SucursalDto> GetSucursales();
    }
}
