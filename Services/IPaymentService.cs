using APBD_kol.DTOs.Request;

namespace APBD_kol.Services
{
    public interface IPaymentService
    {
        Task<int> PayForSubscriptionAsync(PaymentDTO paymentDTO, int idSubscription, int IdClient);
    }
}