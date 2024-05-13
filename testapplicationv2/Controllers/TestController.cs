 using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace testapplicationv2.Controllers
{
    public class TestController : Controller
    {
        // GET: TestController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TestController/Details/5
        public string Details(int id)
        {
            return "hello world";
        }

        // GET: TestController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TestController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

       

        // GET: TestController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

      
    }
}
