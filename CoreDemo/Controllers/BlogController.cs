using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlockListWithCategory();
            return View(values);
        }
        public IActionResult BlogReadAll(int id )
        {
            ViewBag.i = id;   // bloglara yorumları blog id sine göre getirmek için kullanıyoruz.
            var values = bm.GetBlogByID(id);
            return View(values);
        } 

    }
}
