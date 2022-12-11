using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Data.Sqlite;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PersonController : Controller
    { 
        public ActionResult all()
        {
            
            Personal_info listpersons = new Personal_info();

            return View(listpersons.GetAllPerson());
            
        }


        public ActionResult person(int id)
        {
            Personal_info listpersons = new Personal_info();



            return View(listpersons.GetPerson(id));

        }


        public ActionResult search()
        {
          return View();
        }

        public ActionResult GetPerson(FormCollection collection)
        { Personal_info p = new Personal_info();
            int id = p.getid(collection["first_name"], collection["country"]);
            
            return RedirectToAction("person",new { id = id });
        }


    }
}


