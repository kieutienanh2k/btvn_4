using Examp_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Examp_3.Controllers
{
    public class UserController : Controller
    {
        public static List<UserModel> users = new List<UserModel>();
        // GET: User
        public ActionResult Index()
        {

            return View(users);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            var model = users[id-1];
            return View(model);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(UserModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View();
                }
                model.Id = users.Count + 1;
                users.Add(model);

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
            var user = users[id-1];
            return View(user);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, UserModel model)
        {
            try
            {
                // TODO: Add update logic here
                var user = users.FirstOrDefault(m => m.Id == id);
                if (user == null)
                {
                    return View();
                }
                user.Name = model.Name;
                user.Email = model.Email;
                user.Password = model.Password;
                user.ConfirmPassword = model.ConfirmPassword;
                users.Add(user);

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
            var user = users.Find(m => m.Id == id);
            users.Remove(user);
            return View("Index", users);
            // return user != null ? View(user) : View();
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
