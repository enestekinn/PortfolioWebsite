using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace EntityLayer.Models
{
    public class Announcement
    {
        [Key] public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string Content { get; set; }
    }
}