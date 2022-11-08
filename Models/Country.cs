using System.ComponentModel.DataAnnotations;

namespace MVCAjax.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Code { get; set; }
        [Required]
        [MaxLength(75)]
        public string Name { get; set; }
        [MaxLength(75)]
        public string CurrencyName { get; set; }
    }
}
