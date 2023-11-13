using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CD.STORE.Entities.Sm
{
    [Table("SalesDocumentNumber", Schema = "sm")]
    public class SalesDocumentNumber
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalesDocumentNumberId { get; set; }
        public int LastNumber { get; set; }
    }
}
