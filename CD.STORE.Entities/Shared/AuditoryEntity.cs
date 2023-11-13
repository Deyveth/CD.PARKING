using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CD.STORE.Entities.Shared
{
    public class AuditoryEntity
    {
        public bool IsActive { get; set; }
        [SwaggerSchema(ReadOnly = true)]
        public bool IsDeleted { get; set; }
        [SwaggerSchema(ReadOnly = true)]
        public long UserInsId { get; set; }
        [SwaggerSchema(ReadOnly = true)]
        public DateTime InsDate { get; set; }
        [SwaggerSchema(ReadOnly = true)]
        public long UserUpdaId { get; set; }
        [SwaggerSchema(ReadOnly = true)]
        public DateTime? UpdaDate { get; set; }
        [SwaggerSchema(ReadOnly = true)]
        public long UserDelId { get; set; }
        [SwaggerSchema(ReadOnly = true)]
        public DateTime? DelDate { get; set; }

        [NotMapped]
        [SwaggerSchema(ReadOnly = true, Description = "Read only, for filter (0: all, 1: actives, 2: inactives )")]
        public int StatusFilter { get; set; }
    }
}
