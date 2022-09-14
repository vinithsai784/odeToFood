﻿using oddToFood.web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace oddToFood.web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index(string name)
        {
            var model = new GreetingViewModel();
            model.Name = name ?? "no name ";
           // var name = HttpContext.Request.QueryString["name"];
            model.Message = ConfigurationManager.AppSettings["message"];
            return View(model);
        }
    }
}