using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class ProductViewModel
    {
        [StringLength(20)]
        public string Name { get; set; }
        [Range(1, 50000)]
        public int Price { get; set; }
        public int Count { get; set; }
        public int InventoryValue { get; set; }
    }
}
