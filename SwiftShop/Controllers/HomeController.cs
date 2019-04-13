using SwiftShop.Models;
using SwiftShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwiftShop.Controllers
{
    public class HomeController : Controller
    {
        private ProductServices _productServices;
        private ReviewServices _reviewServices;
        public HomeController(SwiftShopContext context)
        {
            _productServices = new ProductServices(context);
            _reviewServices = new ReviewServices(context);
        }
        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }
        public JsonResult PartialLoading(int start)
        {
            var count = 10;
            var _products = _productServices.GetProducts(start, count);
            var d = "";
            foreach (var _product in _products)
            {
                d += $@"
                <div class='col-lg-4 col-md-6 col-xs-12 mix laptop apple' data-price='{_product.Price.ToString("N")}' data-date='20160901' style='display: inline-block;' data-bound=''>
                    <div class='card ms-feature'>
                        <div class='card-block text-center'>
                        <a href='#{_product.Name}'>
                            <img src='assets/img/demo/products/macbook.png' alt='' class='img-responsive center-block'>
                        </a>
                        <h4 class='text-normal text-center'>{_product.Name}</h4>
                        <p>{_product.Description}</p>
                        <div class='mt-2'>
                            <span class='mr-2'>
                                {_reviewServices.GetTotalRating(_product)}
                            </span>
                            <span class='ms-tag ms-tag-success'>UGX {_product.Price.ToString("N")}</span>
                        </div>
                        <a href='javascript:void(0)' class='btn btn-primary btn-sm btn-block btn-raised mt-2 no-mb'>
                            <i class='zmdi zmdi-shopping-cart-plus'></i> Add to Cart</a>
                        </div>
                    </div>
                </div>";
            }
            return Json(new { isempty = !_products.Any(), data = d});
        }
        public ActionResult Login()
        {
            return Json(new { });
        }
    }
}