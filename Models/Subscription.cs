using System.Data.SqlTypes;

namespace APBD_kol.Models
{
    public class Subscription
    {
        public int IdSubscription {  get; set; }
        public String? Name { get; set; }
        public int RenewalPeriod { get; set; }
        public DateTime EndTime { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
