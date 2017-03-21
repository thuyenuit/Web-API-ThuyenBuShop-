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
    [Table("Pages")]
    public class Page: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Column(TypeName ="varchar")]
        [Required]
        [MaxLength(256)]
        public string Alias { get; set; }

        [Required]
        [MaxLength(256)]
        public string Content { get; set; }
    }
}
