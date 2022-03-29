using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Models
{
    public class Portfolio
    {    [Key]
        public int PortfolioId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}