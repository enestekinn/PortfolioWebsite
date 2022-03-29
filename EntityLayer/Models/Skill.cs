using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Models
{
    public class Skill
    {    [Key]
        public int SkillId { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
    }
}