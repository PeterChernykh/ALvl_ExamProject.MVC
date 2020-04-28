using ALvl_ExamProject.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALvl_ExamProject.MVC.Areas.Admin.Controllers
{
    public class PageController : Controller
    {
        // GET: Admin/Page
        public ActionResult Index()
        {
            // get pages list and input into the view
            List<PagePL> pages;

            return View();
        }

        public ActionResult AddPage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPage(PagePL page)
        {
            if (!ModelState.IsValid)
            {
                return View(page);
            }

            //открытие соединения с БД и выхов метода криейт из БЛЛ
            // сделать проверку на пустое поле или пробел if(string.IsNullOrWhiteSpace(page.Slug))
            //if { slug = page.Title.Replace(" ", "-").ToLower(); }
            //else {slug = page.Slug.Replace(" ","-").ToLower(); }
            //Возможно стоит заменить на часть Body. Найти как 

            // if db.Any(x => x.pageBLL.Title == page.Title )
            //{ModelState.AddModelError("", "Such title aready exists in the system");
            //return  View(page)

            //else if (Pages.Any(x => x.Slug == page.Slug))
            // { ModelState.AddModelError("", "Such slug aready exists in the system")}
            //return View (page);
            //
            //Sorting = 100; Сортировку ставлю на 100


            //Пердать успешное выполнение

            TempData["SM"] = "New page has been added.";

            return RedirectToAction("Index");
        }
    }
}