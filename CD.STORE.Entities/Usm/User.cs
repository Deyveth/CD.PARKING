using CD.STORE.Entities.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CD.STORE.Entities.Usm
{
    [Table("User", Schema = "usm")]
    public class User : AuditoryEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public virtual Role? Role { get; set; }

        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}