using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class ConnectedSubscribers
    {
        [Key]
        public int subs_id { get; set; }
        public string Conn_Name { get; set; }

        [Phone]
        [RegularExpression(@"^09\d{9}$", ErrorMessage = "Contact number must be 11 digits and start with 09.")]
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string Plan { get; set; }
        public string Status { get; set; }
        public string Duedate { get; set; }

        [DataType(DataType.Date)]
        public DateTime CurrentDuedate { get; set; }

        [DataType(DataType.Date)]
        public DateTime InstallationDate { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Charge { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal MonthlyCharge { get; set; }

    }
}
