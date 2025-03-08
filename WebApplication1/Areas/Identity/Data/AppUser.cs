using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using WebApplication1.Models;

namespace WebApplication1.Areas.Identity.Data;

public class AppUser : IdentityUser
{
    [Required]
    public string? Conn_Name { get; set; }
    [ForeignKey(nameof(ConnectedSubscribers))]
    public virtual ConnectedSubscribers connectedSubscribers { get; set; }


    [Required]
    public string? Disconn_Name { get; set; }
    [ForeignKey(nameof(DisconnectedSubscribers))]
    public virtual DisconnectedSubscribers disconnectedSubscribers { get; set; }


    [Required]
    public string Trans_Name { get; set; }
    [ForeignKey(nameof(Transactions))]
    public virtual Transactions transactions { get; set; }


    [Required]
    public string? Username { get; set; }
    [ForeignKey(nameof(Accounts))]
    public virtual Accounts accounts { get; set; }


    [Required]
    public string? AccountName { get; set; }
    [ForeignKey(nameof(Activities))]
    public virtual Activities activities { get; set; }
}

