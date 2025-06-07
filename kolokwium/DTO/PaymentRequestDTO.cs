namespace kolokwium.DTO;

public class PaymentRequestDTO
{
    public decimal  Amount      { get; set; }
    public DateTime PeriodStart { get; set; }
    public DateTime PeriodEnd   { get; set; }
}