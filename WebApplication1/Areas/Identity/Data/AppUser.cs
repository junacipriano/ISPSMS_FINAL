using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Areas.Identity.Data;

public class AppUser : IdentityUser
{
    [Required]
    public string? Name {  get; set; }    
    [ForeignKey(nameof(subs_id))]

    public int? subs_id { get; set; }   
    public virtual Models.ConnectedSubscribers connectedSubscribers { get; set; }
}

