using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Models
{
    public class Service
    {    [Key]
        public int ServiceId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}