using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using re2023_api.Models;

namespace re2023_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors]
    public class ProjectController : Controller
    {
        [HttpGet]
        public IActionResult Get(int id) {
            var project = new Project 
            { 
                Id = 1,
                StatusId = 1,
                Name = "Project 1",
                Description = "This is project 1",
                OwnerId = 1,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            var jsonData = JsonConvert.SerializeObject(project);
            return Ok(jsonData);
        }

        ////// GET: ProjectController
        ////public ActionResult Index()
        ////{
        ////    return View();
        ////}

        ////// GET: ProjectController/Details/5
        ////public ActionResult Details(int id)
        ////{
        ////    return View();
        ////}

        ////// GET: ProjectController/Create
        ////public ActionResult Create()
        ////{
        ////    return View();
        ////}

        ////// POST: ProjectController/Create
        ////[HttpPost]
        ////[ValidateAntiForgeryToken]
        ////public ActionResult Create(IFormCollection collection)
        ////{
        ////    try
        ////    {
        ////        return RedirectToAction(nameof(Index));
        ////    }
        ////    catch
        ////    {
        ////        return View();
        ////    }
        ////}

        ////// GET: ProjectController/Edit/5
        ////public ActionResult Edit(int id)
        ////{
        ////    return View();
        ////}

        ////// POST: ProjectController/Edit/5
        ////[HttpPost]
        ////[ValidateAntiForgeryToken]
        ////public ActionResult Edit(int id, IFormCollection collection)
        ////{
        ////    try
        ////    {
        ////        return RedirectToAction(nameof(Index));
        ////    }
        ////    catch
        ////    {
        ////        return View();
        ////    }
        ////}

        ////// GET: ProjectController/Delete/5
        ////public ActionResult Delete(int id)
        ////{
        ////    return View();
        ////}

        ////// POST: ProjectController/Delete/5
        ////[HttpPost]
        ////[ValidateAntiForgeryToken]
        ////public ActionResult Delete(int id, IFormCollection collection)
        ////{
        ////    try
        ////    {
        ////        return RedirectToAction(nameof(Index));
        ////    }
        ////    catch
        ////    {
        ////        return View();
        ////    }
        ////}
    }
}
