using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //similar to set Identity in DB
        [MaxLength(50)]
        public int ID { set; get; }
        [MaxLength(50)]
        [Required]
        public string Name { set; get; }
        [MaxLength(50)]
        [Required]
        public string Type { set; get; }
        //public virtual IEnumerable<PostTag> PostTags { set; get; } //Declare foreign key that will be referenced
        //public virtual IEnumerable<ProductTag> ProductTags { set; get; } //Declare foreign key that will be referenced
    }
}
