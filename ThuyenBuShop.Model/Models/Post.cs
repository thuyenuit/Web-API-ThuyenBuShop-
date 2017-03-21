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
    [Table("Posts")]
    public class Post: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Column(TypeName = "varchar")]
        [Required]
        [MaxLength(250)]
        public string Alias { get; set; }

        [Required]
        public int PostCategoryID { get; set; }

        [MaxLength(500)]
        public string Image { get; set; }

        [MaxLength(500)]
        public string Discription { get; set; }

        [MaxLength(500)]
        public string Content { get; set; }

        public bool? HomeFlag { get; set; }
        public bool? HostFlag { get; set; }
        public int? ViewCount { get; set; }

        [ForeignKey("PostCategoryID")]
        public virtual PostCategory PostCategories { get; set; }
    }
}
