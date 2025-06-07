using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kolokwium.Models;

public class Payment
{
    [Key]
    public int IdPayment { get; set; }   
    
    [ForeignKey(nameof(Client))]
    public int IdClient { get; set; }   
    
    [ForeignKey(nameof(Subscription))]
    public int IdSubscription { get; set; }   
    public DateTime Date { get; set; }   
}