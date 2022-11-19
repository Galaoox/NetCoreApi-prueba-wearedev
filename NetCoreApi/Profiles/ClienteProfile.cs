using AutoMapper;
using NetCoreApi.Data.Models;
using NetCoreApi.Services.Models;

namespace NetCoreApi.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<ClienteInsertDto, Cliente>();
            CreateMap<Cliente, ClienteInsertDto>();
            CreateMap<ClienteReadDto, Cliente>();
            CreateMap<Cliente, ClienteReadDto > ();


        }
    }
}
