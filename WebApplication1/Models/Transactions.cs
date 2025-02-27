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
    public class Transactions
    {
        [Key]
        public int trans_id { get; set; }
        public int subs_id { get; set; }
        public string Trans_Name { get; set; }
        public string Address { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PaidAmount { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; }
        public string Note { get; set; }
        public string Duedate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime TransactionDateTime { get; set; }

        [ForeignKey(nameof(AppUser))]
        public string UserId { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
