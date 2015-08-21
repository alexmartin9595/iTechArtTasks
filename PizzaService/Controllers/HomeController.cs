﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using PizzaService.BusinessLogic;
using PizzaService.Entities;

namespace PizzaService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //IngredientLogic.GetInstance().AddIngredient(new Ingredient { Name = "tomato", Photo = "../images/ingredients/tomato-sauce.jpg", Price = 9000, Weight = 100});
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult GetAllIngredients()
        {
            IEnumerable<Ingredient> ingredients = IngredientLogic.GetInstance().GetAllIngredients();
            return Json(ingredients, JsonRequestBehavior.AllowGet) ;
        }

        [HttpGet]
        public ActionResult GetIngredientById(int id)
        {
            Ingredient ingredients = IngredientLogic.GetInstance().GetIngredientById(id);
            return Json(ingredients, JsonRequestBehavior.AllowGet);
        }
    }
}