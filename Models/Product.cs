using System.ComponentModel.DataAnnotations;

namespace SportsStore.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [StringLength(100,MinimumLength =2)]
        public required string ProductName { get; set; }

        public string? ProductDescription { get; set; }


        public string? ProductCategory { get; set; }
        [StringLength(50, MinimumLength = 2)]

        [Required]
        public required decimal ProductPrice { get; set; }
    }
}
