using APBD_kol.Models;

namespace APBD_kol.Repositories;

public interface IClientRepository
{
    Task<Client> GetClientAsync(int id);
}