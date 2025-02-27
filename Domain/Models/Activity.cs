using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Activity
    {
        [Key]
        public int activities_id {  get; set; }
        public string AccountName {  get; set; }
        public string AccountRole {  get; set; }
        public string ActivitiesDone {  get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ActivitiesDateTime { get; set; }
    }
}
