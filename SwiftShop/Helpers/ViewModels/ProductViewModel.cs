using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwiftShop.Helpers.ViewModels
{
    public class ProductViewModel
    {
        public HttpPostedFileBase FirstImage { get; set; }
        public HttpPostedFileBase SecondImage { get; set; }
        public HttpPostedFileBase ThirdImage { get; set; }
        public HttpPostedFileBase FourthImage { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int CompareAt { get; set; }
        public int MyProperty { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }
}