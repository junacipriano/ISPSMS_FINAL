using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ISPSMS_JUHACA.Data
{
    public class AppUser: IdentityUser 

    {
        [Required]
        public string? Name { get; set; }
        [ForeignKey(nameof(subs_id))]
        public int? subs_id { get; set; }

        public virtual Domain.Models.ConnectedSubscribers ConnectedSubscribers { get; set; }
    }
}
