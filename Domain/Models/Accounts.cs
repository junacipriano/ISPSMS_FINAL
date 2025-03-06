using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Accounts
    {
        [Key]
        public int account_id { get; set; }
        public string Username { get; set; }
        public string AccountName { get; set; }
        public string AccountPassword { get; set; }
        public string AccountRole { get; set; }
        public string AccountEmail { get; set; }
        public string AccountPhone { get; set; } = string.Empty;
        public string AccountAddress { get; set; } = string.Empty;
    }
}
