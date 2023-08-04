using TicketBooking.API.Enum;

namespace TicketBooking.API.Dtos
{
  public class SeatResponse
  {
    public string Name { get; set; }
    public string Id { get; set; }
    public SeatType Type { get; set; }
  }
}