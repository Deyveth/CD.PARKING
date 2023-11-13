using CD.STORE.Entities.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CD.STORE.Entities.Sm
{
    [Table("Sale", Schema = "sm")]
    public class Sale : AuditoryEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SaleId { get; set; }
        public int DocumentNumber { get; set; }
        public string PaymentType { get; set; }
        public decimal Total { get; set; }
    }
}
