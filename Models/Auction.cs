using System;
using System.ComponentModel.DataAnnotations;

namespace HangfireTest.Models
{
    public class Auction
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime? StartAt { get; set; } 
        public String Status { get; set; } = "No Start";
    }
}