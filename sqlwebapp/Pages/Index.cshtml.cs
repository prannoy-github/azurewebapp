﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sqlwebapp.models;
using sqlwebapp.Services;

namespace sqlwebapp.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> Products;

        public void OnGet()
        {
            ProductService productservice = new ProductService();
            Products = productservice.GetProducts();
        }
    }
}