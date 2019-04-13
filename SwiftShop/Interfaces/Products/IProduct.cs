using SwiftShop.Helpers.ViewModels;
using SwiftShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwiftShop.Interfaces.Products
{
    public interface IProduct
    {
        Product GetProduct(string product_name);
        List<Product> GetProducts();
        List<Product> GetProducts(int start, int count);

        (bool check, string message) Save(ProductViewModel product);
    }
}