using APBD_kol.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD_kol.Repositories;

public class ClientRepository(Context context) : IClientRepository
{
    public async Task<Client> GetClientAsync(int id)
    {
        return (await context.Clients
            .Include(c => c.Sales)
            .ThenInclude(s => s.IdSubscriptionNav)
            .ThenInclude(s => s.Payments)
            .FirstOrDefaultAsync(c => c.IdClient == id))!;
    }
}