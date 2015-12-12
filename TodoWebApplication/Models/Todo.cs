using System;
using System.ComponentModel.DataAnnotations;

namespace TodoWebApplication.Models
{
    public class Todo
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool Done { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}