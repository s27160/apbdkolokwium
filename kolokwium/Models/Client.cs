using System.ComponentModel.DataAnnotations;

namespace kolokwium.Models;

public class Client
{
    [Key]
    public int IdClient { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    
    public List<Subscription> Subscriptions { get; set; }
}