using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    [Table("product")]
    public class Product
    {
        [Column("product_id")]
        public int Id { get; set; }
        [Column("product_name")]
        public string Name { get; set; } = string.Empty;
        [Column("price")]
        public decimal Price { get; set; }
        [Column("units_in_stock")]
        public int UnitInStock { get; set; }
        [Column("image_url")]
        public string ImageUrl { get; set; }
        [Column("discount")]
        public int Discount { get; set; }
    }
}
