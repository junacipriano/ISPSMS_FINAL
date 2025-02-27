using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Areas.Identity.Data;

namespace WebApplication1.Models
{
    public class Activities
    {
        [Key]
        public int activities_id { get; set; }
        public string AccountName { get; set; }
        public string AccountRole { get; set; }
        public string ActivitiesDone { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ActivitiesDateTime { get; set; }

        [ForeignKey(nameof(AppUser))]
        public string UserId { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
