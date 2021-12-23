using MP2_FinalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MP2_FinalProject.Models
{
    public class TaskViewModel
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [StringLength(160, MinimumLength = 0)]
        public string Description { get; set; }

        [StringLength(20, MinimumLength = 3)]
        public string Importance { get; set; }

        [Display(Name = "Ending Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
ApplyFormatInEditMode = true)]
        public DateTime EndingDate { get; set; }

        [StringLength(20, MinimumLength = 3)]
        public string Status { get; set; }

        [StringLength(30, MinimumLength = 3)]
        public string Employee { get; set; }
    }

    public class TaskDBContext : DbContext
    {
        public TaskDBContext()
        {
        }
        public DbSet<TaskViewModel> Tasks { get; set; }
    }
}