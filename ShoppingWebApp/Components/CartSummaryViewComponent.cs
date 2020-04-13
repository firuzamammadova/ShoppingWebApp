using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ShoppingWebApp.Infrastructure;
using ShoppingWebApp.ViewModels;

namespace ShoppingWebApp.Components
{
    public class CartSummaryViewComponent:ViewComponent
    {
        public string Invoke()
        {
            return HttpContext.Session.GetJSon<Cart>("Cart")?.Products.Count().ToString() ?? "0";
        }
    }
}
