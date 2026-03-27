using System.ComponentModel.DataAnnotations;

namespace api.Models;

public class Reservation
{
    public int Id { get; set; }

    [Required, MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required, EmailAddress, MaxLength(200)]
    public string Email { get; set; } = string.Empty;

    [Required, Phone, MaxLength(30)]
    public string Phone { get; set; } = string.Empty;

    [Required]
    public DateOnly Date { get; set; }

    [Required, MaxLength(10)]
    public string Time { get; set; } = string.Empty;

    [Range(1, 20, ErrorMessage = "Guest count must be between 1 and 20.")]
    public int Guests { get; set; }

    [MaxLength(500)]
    public string SpecialRequests { get; set; } = string.Empty;

    public ReservationStatus Status { get; set; } = ReservationStatus.Pending;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}

public enum ReservationStatus
{
    Pending,
    Confirmed,
    Cancelled
}
