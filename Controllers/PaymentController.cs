using APBD_kol.DTOs.Request;
using APBD_kol.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_kol.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentController(IPaymentService paymentService) : ControllerBase
    {
        [HttpPost("{idSubscription:int}/{IdClient:int}")]
        public async Task<IActionResult> PayForSubscription(PaymentDTO paymentDTO, int idSubscription, int IdClient)
        {
            try
            {
                var paymentId = await paymentService.PayForSubscriptionAsync(paymentDTO, idSubscription, IdClient);
                return Ok(paymentId);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}