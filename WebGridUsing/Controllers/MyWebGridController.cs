using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGridUsing.Models;

namespace WebGridUsing.Controllers
{
    public class MyWebGridController : Controller
    {
        // GET: MyWebGrid
        public ActionResult Index()
        {
            Book.GenerateFakeData(50);

            return View(Book._books);
        }

        [HttpPost]
        public ActionResult Index(string searchid)
        {

            List<Book> filtered_data = Book._books.Where(x =>
              x.Name.ToLower().Contains(searchid) ||
              x.Author.ToLower().Contains(searchid) ||
              x.PublishingDate.ToString().Contains(searchid) ||
              x.price.ToString().Contains(searchid)).ToList();

            return View(filtered_data);
        }
    }
}

//Site.css birtakım kodlar yazarak ekstra düzenlemelerde bulundum.