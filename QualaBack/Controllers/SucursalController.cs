using Microsoft.AspNetCore.Mvc;
using QualaBack.Dto;
using QualaBack.Model;
using QualaBack.Service;

namespace QualaBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SucursalController : Controller
    {
        private SucursalService _sucursalService;

        public SucursalController(SucursalService sucursalService) {
            _sucursalService = sucursalService;
        }

        [HttpPost]
        public ActionResult<SucursalDto> Create(SucursalDto sucursal)
        {
            try
            {
                return _sucursalService.CreateSucursal(sucursal);
            }
            catch
            {
                return View();
            }
        }

        [HttpPatch]
        public ActionResult<SucursalDto> Update(SucursalDto sucursal)
        {
            try
            {
                return _sucursalService.UpdateSucursal(sucursal);
            }
            catch
            {
                return View();
            }
        }

        [HttpDelete]
        public ActionResult<Sucursal> Delete(SucursalDto sucursal)
        {
            try
            {
               return _sucursalService.DeleteSucursal(sucursal);
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult<List<SucursalDto>> Get() {
            try
            {
                return _sucursalService.GetSucursales();
            }
            catch
            {
                return View();
            }
        }
    }
}
