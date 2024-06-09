namespace APBD_kol.DTOs.Response
{
    public class SubscriptionDTO
    {
        public int IdSubscription { get; set; }
        public string Name { get; set; } = null!;
        public int RenewalPeriod { get; set; }
        public double TotalPaidAmount { get; set; }
    }
}
