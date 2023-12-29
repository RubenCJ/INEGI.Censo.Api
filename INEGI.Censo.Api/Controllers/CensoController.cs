using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace INEGI.Censo.Api.Controllers
{
    public class CensoController : Controller
    {
        // GET: CensoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CensoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CensoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CensoController/Create
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

        // GET: CensoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CensoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: CensoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CensoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
