using System.ComponentModel.DataAnnotations;

namespace ProductsAPI.Models
{
    public class Product
    {
        //Variables

        [Key]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }

        public string Description { get; set; }
        [Required]

        public double Price { get; set; }

        public byte[]image { get; set; }

        public DateTime CreatedDate { get; set; }

        public double Rating { get; set; }
    }
}
