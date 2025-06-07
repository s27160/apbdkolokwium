using kolokwium.DTO;
using kolokwium.Models;
using kolokwium.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace kolokwium.Controllers;

[ApiController]
[Route("api/subscription")]
public class SubscriptionController : ControllerBase
{
    private readonly IDataRepository<Subscription> dataRepository;
    public SubscriptionController(IDataRepository<Subscription> dataRepository)
    {
        this.dataRepository = dataRepository;
    }

    [HttpPost("payment")]
    public ActionResult<Subscription> Payment(
        int clientId,
        int subscriptionId,
        [FromBody] PaymentRequestDTO paymentRequest
        )
    {
        return Ok();
    }
}