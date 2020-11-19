using ApiMeatTemp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApiMeatTemp.Controllers
{
    public class UserController : Controller
    {
        User user = new User();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(Models.User inloggning)
        {
            if (inloggning.UserName == null || inloggning.Password == null)
            {
                ModelState.AddModelError("", "Du måste fylla i både användarnamn och lösenord");
                return View();
            }
            bool validUser = false;
            validUser = System.Web.Security.FormsAuthentication.Authenticate(inloggning.UserName, inloggning.Password);


            if (validUser == true)
            {
                System.Web.Security.FormsAuthentication.RedirectFromLoginPage(inloggning.UserName, false);
            }
            ModelState.AddModelError("", "Inloggningen ej godkänd");
            return View();
        }


        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
