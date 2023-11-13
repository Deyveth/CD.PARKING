using CD.STORE.Entities.Inv;
using CD.STORE.Entities.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CD.STORE.Entities.Sm
{
    [Table("SaleDetail", Schema = "sm")]
    public class SaleDetail : AuditoryEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SaleDetailId { get; set; }

        [ForeignKey("Sale")]
        public int SaleId { get; set; }
        public virtual Sale Sale { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set;}
    }
}
