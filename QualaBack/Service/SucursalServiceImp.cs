using AutoMapper;
using QualaBack.Dto;
using QualaBack.Model;
using QualaBack.Repository;

namespace QualaBack.Service
{
    public class SucursalServiceImp : SucursalService
    {
        SucursalRepository _sucursalRepository;
        Mapper mapper = new Mapper(new MapperConfiguration(mapper => {
            mapper.CreateMap<SucursalDto, Sucursal>();
            mapper.CreateMap<Sucursal, SucursalDto>();
        }));

        public SucursalServiceImp(SucursalRepository sucursalRepository) {
            _sucursalRepository = sucursalRepository;
        }

        SucursalDto SucursalService.CreateSucursal(SucursalDto sucursal)
        {
           
           Sucursal sucursalSave = _sucursalRepository.SaveChanges(mapper.Map<SucursalDto, Sucursal>(sucursal));
            return mapper.Map<Sucursal,SucursalDto>(sucursalSave);
        }

        Sucursal SucursalService.DeleteSucursal(SucursalDto sucursal)
        {
          return _sucursalRepository.Delete(mapper.Map<SucursalDto,Sucursal>(sucursal));
        }

        List<SucursalDto> SucursalService.GetSucursales()
        { 
            List<Sucursal> sucursales = _sucursalRepository.GetAll();
            return mapper.Map<List<Sucursal>, List<SucursalDto>>(sucursales);
        }

        SucursalDto SucursalService.UpdateSucursal(SucursalDto sucursal)
        {
            Sucursal sucursalUpdated = _sucursalRepository.UpdateChanges(mapper.Map<SucursalDto, Sucursal>(sucursal));
            return mapper.Map<Sucursal,SucursalDto>(sucursalUpdated);
        }
    }
}
