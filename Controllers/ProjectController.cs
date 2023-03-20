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
        public IActionResult Get(int id)
        {
            var project = new List<Project>
            {
                new Project{
                    Id = 1,
                    StatusId = 1,
                    Name = "1315 Blair Lane, Hoffman Estates, IL 60169",
                    Description = "We are selling our beautiful home in the suburbs.",
                    OwnerId = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Image = "house.PNG"
                },
                new Project{
                    Id = 2,
                    StatusId = 1,
                    Name = "900 N. Kingsbury St. # 821, Chicago, IL 60610",
                    Description = "We are renting out our beautiful condo in downtown Chicago.",
                    OwnerId = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Image = "condo.PNG"
                },
                new Project{
                    Id = 3,
                    StatusId = 2,
                    Name = "2208 Mellogold Way, Corona, CA 60610",
                    Description = "We are putting an offer to buy this beautiful home in Corona CA.",
                    OwnerId = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Image = "houseca.PNG"
                }
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
