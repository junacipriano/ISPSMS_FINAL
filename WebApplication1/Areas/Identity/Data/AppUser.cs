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
    public int? ConnectedSubscribersId { get; set; }
    public virtual ConnectedSubscribers connectedSubscribers { get; set; }


    [Required]
    public string? Disconn_Name { get; set; }
    [ForeignKey(nameof(DisconnectedSubscribers))]
    public int? DisconnectedSubscribersId { get; set; }
    public virtual DisconnectedSubscribers disconnectedSubscribers { get; set; }


    [Required]
    public string Trans_Name { get; set; }
    [ForeignKey(nameof(Transactions))]
    public int? TransactionId { get; set; }
    public virtual Transactions transactions { get; set; }


    [Required]
    public string? Username { get; set; }
    [ForeignKey(nameof(Accounts))]
    public int? AccountId { get; set; }
    public virtual Accounts accounts { get; set; }


    [Required]
    public string? AccountName { get; set; }
    [ForeignKey(nameof(Activities))]
    public int? ActivitiesId { get; set; }
    public virtual Activities activities { get; set; }
}

