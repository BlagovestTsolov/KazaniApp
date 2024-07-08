using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KazaniApp.Data.Data.Models
{
    public class Product
    {
        [Key]
        [Comment("Product Identifier")]
        public int Id { get; set; }

        [Comment("Product Type Identifier")]
        public required int ProductTypeId { get; set; }

        [ForeignKey(nameof(ProductTypeId))]
        public required ProductType FruitType { get; set; }

        [Comment("Product Description")]
        public required string Description { get; set; }

        [Comment("The Quantity of the Product")]
        public required int Kilograms { get; set; }
    }
}
