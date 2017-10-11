using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JamiiCS.Models
{
    public class GroupProject
    {
        [Key]
        [Column(Order = 1)]
        public int GroupId { get; set; }        
        [Key]
        [Column(Order = 2)]
        public int ProjectId { get; set; }

        [ForeignKey("GroupId")]
        public virtual Group Group { get; set; }

        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }
    }
}