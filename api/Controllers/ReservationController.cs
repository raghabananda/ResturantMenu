using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using api.Data;
using api.Models;

namespace api.Controllers;

[ApiController]
[Route("api/reservations")]
public class ReservationController : ControllerBase
{
    [HttpPost]
    public ActionResult<Reservation> Create([FromBody] Reservation reservation)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var created = DataStore.AddReservation(reservation);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpGet("{id:int}")]
    [Authorize]
    public ActionResult<Reservation> GetById(int id)
    {
        var reservation = DataStore.Reservations.FirstOrDefault(r => r.Id == id);
        return reservation is null ? NotFound() : Ok(reservation);
    }

    [HttpGet]
    [Authorize]
    public ActionResult<IEnumerable<Reservation>> GetAll()
        => Ok(DataStore.Reservations.OrderByDescending(r => r.CreatedAt));

    [HttpPut("{id:int}/status")]
    [Authorize]
    public ActionResult<Reservation> UpdateStatus(int id, [FromBody] UpdateStatusRequest request)
    {
        if (!Enum.TryParse<ReservationStatus>(request.Status, true, out var status))
            return BadRequest(new { message = "Invalid status. Use Pending, Confirmed, or Cancelled." });

        var updated = DataStore.UpdateReservationStatus(id, status);
        return updated is null ? NotFound() : Ok(updated);
    }
}

public record UpdateStatusRequest(string Status);
