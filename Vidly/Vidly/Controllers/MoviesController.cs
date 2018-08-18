using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random 
        public ActionResult Random() //returns action result
        {
            var movie = new Movie() { Name = "Shrek!" }; //Movie class from models.
            return View(movie); //render the movie var.
        }
    }
}