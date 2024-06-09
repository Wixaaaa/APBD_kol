using APBD_kol.DTOs.Request;
using APBD_kol.DTOs.Response;
using APBD_kol.Models;
using APBD_kol.Repositories;

namespace APBD_kol.Services
{
    public class ClientService(IClientRepository clientRepository, IPaymentRepository paymentRepository) : IClientService
    {
        public async Task<ClientDTO> GetClientAsync(int id)
        {
            var client = await clientRepository.GetClientAsync(id);
            if (client == null) throw new Exception("Client not found");
            return new ClientDTO
            {
                FirstName = client.FirstName,
                LastName = client.LastName,
                Email = client.Email,
                Phone = client.Phone,
                Discount = client.Discounts.Where(d => d.DateFrom < DateTime.Now && d.DateTo > DateTime.Now)
                    .Select(d => d.Value)
                    .FirstOrDefault(),
                Subscriptions = client.Sales.Select(s => s.IdSubscriptionNav)
                    .Select(s => new SubscriptionDTO
                    {
                        IdSubscription = s.IdSubscription,
                        Name = s.Name,
                        RenewalPeriod = s.RenewalPeriod,
                        TotalPaidAmount = s.Payments.Sum(p => p.Amount)
                    })
                    .ToList()
            };
        }
    }
}