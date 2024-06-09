using APBD_kol.DTOs.Request;
using APBD_kol.DTOs.Response;

namespace APBD_kol.Services
{
    public interface IClientService
    {
        Task<ClientDTO> GetClientAsync(int id);
    }
}