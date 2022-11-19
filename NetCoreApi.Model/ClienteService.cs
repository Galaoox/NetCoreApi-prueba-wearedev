using AutoMapper;
using NetCoreApi.Data.Models;
using NetCoreApi.Data.Repositories;
using NetCoreApi.Services.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetCoreApi.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;


        public ClienteService(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }
        public async Task<List<ClienteReadDto>> GetAllClientes()
        {
            var result = await _clienteRepository.GetAllClientes();
            return _mapper.Map<List<ClienteReadDto>>(result);
        }

        public async Task<ClienteReadDto> GetClienteDetails(int id)
        {
            var cliente = await GetCliente(id);
            return _mapper.Map<ClienteReadDto>(cliente);
        }

        public async Task<bool> InsertCliente(ClienteInsertDto cliente)
        {
            return await _clienteRepository.InsertCliente(_mapper.Map<Cliente>(cliente));
        }

        public async Task<bool> UpdateCliente(int id, ClienteInsertDto cliente)
        {
            await ValidateIfExistCliente(id);
            var clienteMapped = _mapper.Map<Cliente>(cliente);
            clienteMapped.Id = id;
            return await _clienteRepository.UpdateCliente(clienteMapped);
        }

        public async Task<bool> DeleteCliente(int id)
        {
            var cliente = await GetCliente(id);
            return await _clienteRepository.DeleteCliente(cliente);
        }

        private async Task<bool> ValidateIfExistCliente(int id)
        {
            var exist = await _clienteRepository.ExistCliente(id);
            if (!exist) throw new Exception("No se encontro el cliente");
            return exist;
        }

        private async Task<Data.Models.Cliente> GetCliente(int id)
        {
            var cliente = await _clienteRepository.GetClienteDetails(id);
            if (cliente == null) throw new Exception("No se encontro el cliente");
            return cliente;
        }
    }
}
