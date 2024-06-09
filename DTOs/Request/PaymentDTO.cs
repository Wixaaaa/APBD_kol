namespace APBD_kol.DTOs.Request
{
    public class PaymentDTO
    {
        public int IdPayment { get; set; }
        public DateTime Date { get; set; }
        public int IdClient { get; set; }
        public int IdSubscription { get; set; }
        public int Amount { get; set; }
    }
}
