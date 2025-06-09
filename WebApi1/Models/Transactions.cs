using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal Amount { get; set; }

    }
}