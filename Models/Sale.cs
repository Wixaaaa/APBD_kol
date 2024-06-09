namespace APBD_kol.Models
{
    public class Sale
    {
        public int IdSale { get; set; }
        public int IdClient {  get; set; }
        public int idSubscription { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Client IdClientNav { get; set; } = null!;
        public virtual Subscription IdSubscriptionNav { get; set; } = null!;
    }
}