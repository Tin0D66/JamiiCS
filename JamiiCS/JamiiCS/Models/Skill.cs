using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JamiiCS.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public virtual IList<ApplicationUser> Users { get; set; }
    }
}