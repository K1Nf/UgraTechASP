using System.ComponentModel.DataAnnotations;

namespace UgraTech.Models
{
    public class Appeals
    {
        [Key]
        public int Appeal_ID { get; set; }
        
        public string? Name { get; set; } = null;
        [Required]
        [EmailAddress]
        public int Email { get; set; }
        [Required]
        [Phone]
        public int Phone_Number { get; set; }
        [Required]
        public string Message { get; set; } = null!;

        public bool? Status { get; set; } = null;
    }
}
