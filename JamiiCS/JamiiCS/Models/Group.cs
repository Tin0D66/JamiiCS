using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JamiiCS.Models
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public virtual IList<ApplicationUser> Mambers { get; set; }
    }
}