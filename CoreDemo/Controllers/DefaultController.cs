using CoreDemo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class DefaultController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(writerClasses);
            return Json(jsonWriters);
        }
        public static List<WriterClass> writerClasses = new List<WriterClass>
    {
        new WriterClass
        {
            Id=1,
            Name="Ayşe"

        },
        new WriterClass
        {
            Id=2,
            Name="Ahmet"

        },
        new WriterClass
        {
            Id=3,
            Name="Buse"

        }
         };
    }


}
