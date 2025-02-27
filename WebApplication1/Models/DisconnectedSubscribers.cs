using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Areas.Identity.Data;

namespace WebApplication1.Models
{
    internal class DisconnectedSubscribers
    {
        [Key]
        public int subs_id { get; set; }
        public string Disconn_Name { get; set; }

        [Phone]
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
        public decimal MonthlyCharge { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalCharge { get; set; }

        [ForeignKey(nameof(AppUser))]
        public string UserId { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
