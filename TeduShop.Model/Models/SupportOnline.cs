using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract
{
    [Table("SupportOnline")]
    public class SupportOnline : ISwitchable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //similar to set Identity in DB
        public int ID { set; get; }
        [Required]
        [MaxLength(50)]
        public string Name{ set; get; }
        [MaxLength(50)]
        public string Department { set; get; }
        [MaxLength(50)]
        public string Skype { set; get; }
        [MaxLength(50)]
        public string Mobile { set; get; }
        [MaxLength(50)]
        public string Email { set; get; }
        [MaxLength(50)]
        public string Facebook { set; get; }

        public bool Status
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        public int? DisplayOrder { set; get; }
    }
}
