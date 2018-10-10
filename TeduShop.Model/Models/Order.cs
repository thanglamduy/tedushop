using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order : ISwitchable
    {
        public string CreatedBy
        {
            get;

            set;      
        }

        public DateTime? CreatedDate
        {
            get;
            set;
        }

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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //similar to set Identity in DB
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerName { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerAddress { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerEmail { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerMobile { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerMessage { set; get; }
        [Required]
        [MaxLength(256)]
        public string PaymentMethod { set; get; }
        [Required]
        [MaxLength(256)]
        public string PaymentStatus { set; get; }
        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; } //Declare foreign key that will be referenced , son class have a referenced


    }
}
