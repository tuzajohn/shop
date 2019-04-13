using SwiftShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwiftShop.Interfaces.Reviews
{
    public interface IReview
    {
        double GetAverageRating(Product product);
        string GetTotalRating(Product product);
    }
}