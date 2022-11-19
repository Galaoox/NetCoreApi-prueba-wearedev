using NetCoreApi.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetCoreApi.Services
{
    public interface IClienteService
    {
        Task<List<ClienteReadDto>> GetAllClientes();
        Task<ClienteReadDto> GetClienteDetails(int id);
        Task<bool> InsertCliente(ClienteInsertDto cliente);
        Task<bool> UpdateCliente(int id, ClienteInsertDto cliente);
        Task<bool> DeleteCliente(int id);

    }
}
