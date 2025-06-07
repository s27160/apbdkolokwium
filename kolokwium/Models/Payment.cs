using System.ComponentModel.DataAnnotations;

namespace kolokwium.Models;

public class Payment
{
    [Key]
    public int IdPayment { get; set; }   
    public int IdClient { get; set; }   
    public int IdSubscription { get; set; }   
    public DateTime Date { get; set; }   
}