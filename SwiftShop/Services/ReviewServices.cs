using SwiftShop.Interfaces.Reviews;
using SwiftShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwiftShop.Services
{
    public class ReviewServices : IReview
    {
        private SwiftShopContext _context = new SwiftShopContext();
        public ReviewServices(SwiftShopContext context)
        {
            _context = context;
        }
        public double GetAverageRating(Product product)
        {
            var _reviews = _context.Reviews.Where(prd => prd.Id == product.Id);
            double average = _reviews.Average(innerList => innerList.StarNumber);
            return average;
        }

        public string GetTotalRating(Product product)
        {
            var counter = GetAverageRating(product);
            var _star = "";
            for (int i = 0; i < (int)counter; i++)
            {
                _star += "<i class='zmdi zmdi-star color-warning'></i>";
            }
            if ((int)counter < 5)
            {
                var diff = 5 - (int)counter;
                for (int i = 0; i < diff; i++)
                {
                    _star += "<i class='zmdi zmdi-star'></i>";
                }
            }
            return _star;
        }
    }
}