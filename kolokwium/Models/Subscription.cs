using System.ComponentModel.DataAnnotations;

namespace kolokwium.Models;

public class Subscription
{
    [Key]
    public int IdSubscription { get; set; }
    public string Name { get; set; }
    public int RenewalPeriod { get; set; }
    public DateTime EndTime { get; set; }
    public float Price { get; set; }
    
    public List<Payment> Payments { get; set; }
}