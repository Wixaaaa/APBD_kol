using APBD_kol.Models;

namespace APBD_kol.Repositories;

public interface IPaymentRepository
{
    Task<int> AddPaymentAsync(Payment payment);
}