﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.WriterMessageNotification
{
    public class WriterMessageNotification : ViewComponent
    {

        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}