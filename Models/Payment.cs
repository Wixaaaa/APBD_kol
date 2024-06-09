namespace APBD_kol.Models
{
    public class Payment
    {
        public int IdPayment { get; set; }
        public DateTime Date { get; set; }
        public int IdClient { get; set; }
        public int IdSubscription { get; set; }
        public int Amount { get; set; }

        public virtual Client IdClientNav { get; set; } = null!;
        public virtual Subscription IdSubscriptionNav { get; set; } = null!;
    }
}