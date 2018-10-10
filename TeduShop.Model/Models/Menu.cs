using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //similar to set Identity in DB
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        public string URL { get; set; }

        public int? DisplayOrder { get; set; }

        
        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { set; get; } //reference to MenuGroup

        [Required]
        public int GroupID { get; set; }

        [MaxLength(10)]
        public string Target { set; get; }

        public bool Status { set; get; }
    }
}