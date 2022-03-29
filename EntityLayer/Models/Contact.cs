using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Models
{
    public class Conctact
    {    [Key]
        public int ContactId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
    }
}