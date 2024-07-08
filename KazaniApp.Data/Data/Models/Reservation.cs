using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KazaniApp.Data.Data.Models
{
    public class Reservation
    {
        [Key]
        [Comment("Reservation Identifier")]
        public int Id { get; set; }

        [Comment("Customer Identifier")]
        public required string CustomerId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public required IdentityUser Customer { get; set; }

        [Comment("Product Identifier")]
        public required int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public required Product Product { get; set; }

        [Comment("Date of the Reservation")]
        public required DateTime ReservationDate { get; set; }

        [Comment("Time of the Reservation")]
        public required DateTime ReservationTime { get; set; }
    }
}
