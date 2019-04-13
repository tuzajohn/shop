using SwiftShop.Helpers.ViewModels;
using SwiftShop.Interfaces.Products;
using SwiftShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwiftShop.Services
{
    public class ProductServices : IProduct
    {
        private SwiftShopContext _context = new SwiftShopContext();
        public ProductServices(SwiftShopContext context)
        {
            _context = context;
        }
        public Product GetProduct(string product_name)
        {
            var _product = _context.Products.FirstOrDefault(prod => prod.Name == product_name);
            if (_product is null) { return new Product(); }
            return _product;
        }

        public List<Product> GetProducts()
        {
            var _products = _context.Products.OrderByDescending(prod => prod.Date).Take(10).ToList();
            return _products;
        }

        public List<Product> GetProducts(int start, int count)
        {
            var _products = _context.Products.Skip(start).Take(count).OrderByDescending(prod => prod.Date).ToList();
            return _products;
        }

        public (bool check, string message) Save(ProductViewModel product)
        {
            var _product = _context.Products.FirstOrDefault(p => p.Name == product.Name.Trim());
            if (_product != null)
            {
                return (false, "");
            }
            try
            {
                if (product.FirstImage == null)
                {
                    return (false, "");
                }

            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }
    }
}