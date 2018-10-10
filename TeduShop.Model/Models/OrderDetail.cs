using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("OrderDeatils")]
    public class OrderDetail
    {
        [Key]
        public int OrderID { set; get; }
        [Key]
        public int ProductID { set; get; }

        
        [ForeignKey("OrderID")]
        public virtual Order OrderI{ get; set; }
 
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
        
        public int Quantity { get; set; }


    }
}
