using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SwiftShop.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int SellerId { get; set; }
        public int CategoryId { get; set; }
        public int ImageId { get; set; }
        public decimal Price { get; set; }
        public decimal CompareAtPrice { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
    }
}