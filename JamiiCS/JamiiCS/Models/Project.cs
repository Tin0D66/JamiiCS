using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JamiiCS.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public string Images { get; set; }
        public string Url { get; set; }
        public string User_Id { get; set; }
        [ForeignKey("User_Id")]
        public virtual ApplicationUser Creator { get; set; }
    }
}