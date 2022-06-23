﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Computer_Store.Models
{
    public class CartItems
    {   

        public int Id { get; set; }
        
        public int ProductID { get; set; }

        [Required]
        [ForeignKey("Cart")]
        public int CartID { get; set; }
 
        public Cart Cart { get; set; }  
    }
}
