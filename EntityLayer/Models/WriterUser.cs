using Microsoft.AspNetCore.Identity;

namespace EntityLayer.Models
{
    public class WriterUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
    }
}