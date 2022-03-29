using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Models
{
    public class SocialMedia
    {    [Key]
        public int SocialMediaId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public string Status { get; set; }
    }
}