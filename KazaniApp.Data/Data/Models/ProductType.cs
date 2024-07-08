using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static KazaniApp.Data.Data.Constants.Constants;

namespace KazaniApp.Data.Data.Models
{
    public class ProductType
    {
        [Key]
        [Comment("Product Type Identifier")]
        public int Id { get; set; }

        [MaxLength(FruitNameMaxLength)]
        [Comment("Name of the used fruits")]
        public required string FruitName { get; set; }

        public IList<Product> Products { get; set; } = new List<Product>();
    }
}
