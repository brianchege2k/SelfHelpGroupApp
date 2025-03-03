using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SelfHelpGroupAPI.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int MemberId { get; set; }

        [ForeignKey("MemberId")]
        public required Member Member { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public required string Type { get; set; } // "Deposit" or "Withdrawal"

        [Required]
        public DateTime TransactionDate { get; set; } = DateTime.UtcNow;
    }
}
