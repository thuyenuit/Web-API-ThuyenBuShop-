using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThuyenBuShop.Model.Abstract;

namespace ThuyenBuShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string CustomerName { get; set; }

        [MaxLength(256)]
        public string CustomerAddress { get; set; }

        [MaxLength(50)]
        public string CustomerEmail { get; set; }

        [MaxLength(15)]
        public string CustomerMobile { get; set; }

        [MaxLength(256)]
        public string CustomerMessage { get; set; }
      
        [MaxLength(50)]
        public string PaymentMethod { get; set; }

        [MaxLength(50)]
        public string PaymentStatus { get; set; }

        public DateTime? CreatedDate { get; set; }

        [MaxLength(256)]
        public string CreatedBy { get; set; }

        public bool? Status { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
