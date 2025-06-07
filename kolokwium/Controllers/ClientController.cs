using kolokwium.DTO;
using kolokwium.Models;
using Microsoft.AspNetCore.Mvc;
using kolokwium.Repositories;
using Microsoft.EntityFrameworkCore;

namespace kolokwium.Controllers;

[ApiController]
[Route("api/client")]
public class ClientController : ControllerBase
{
    private readonly IDataRepository<Client> dataRepository;
    public ClientController(IDataRepository<Client> dataRepository)
    {
        this.dataRepository = dataRepository;
    }
    
    [HttpGet("{clientId:int}")]
    public ActionResult<Client> GetById(int clientId)
    {
        var client = dataRepository
            .Query()
            .Include(c => c.Subscriptions)
            .ThenInclude(s => s.Payments)
            .FirstOrDefault(c => c.IdClient == clientId);

        if (client == null) 
            return NotFound();

        var clientDto = new ClientDTO()
        {
            FirstName = client.FirstName,
            LastName  = client.LastName,
            Email     = client.Email,
            Phone     = client.Phone,
            Subscriptions = client.Subscriptions
                .Select(s => new SubscriptionDTO()
                {
                    IdSubscription    = s.IdSubscription,
                    Name              = s.Name,
                    TotalPaidAmount   = s.Payments.Count * s.Price
                })
                .ToList()
        };

        return Ok(clientDto);
    }
}