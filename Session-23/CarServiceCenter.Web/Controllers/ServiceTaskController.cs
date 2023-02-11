using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenter.Web.Models.Customer;
using CarServiceCenter.Web.Models.ServiceTask;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceCenter.Web.Controllers {
    public class ServiceTaskController : Controller {

        private readonly IEntityRepo<ServiceTask> _serviceTaskRepo;

        public ServiceTaskController(IEntityRepo<ServiceTask> serviceTaskRepo) {
            _serviceTaskRepo = serviceTaskRepo;
        }

        // GET: ServiceTaskController
        public ActionResult Index() {

            var serviceTasks = _serviceTaskRepo.GetAll().ToList();
            return View(model: serviceTasks);
        }

        // GET: ServiceTaskController/Details/5
        public ActionResult Details(int? id) {

            if (id == null) {
                return NotFound();
            }

            var serviceTask = _serviceTaskRepo.GetById(id.Value);
            if (serviceTask == null) {
                return NotFound();
            }

            var viewServiceTask = new ServiceTaskDetailsDto {
                Id = serviceTask.Id,
                Code = serviceTask.Code,
                Description = serviceTask.Description,
                Hours = serviceTask.Hours,
                TransactionLines = serviceTask.TransactionLines.ToList()
            };
            return View(model: viewServiceTask);
        }

        // GET: ServiceTaskController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: ServiceTaskController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ServiceTaskCreateDto serviceTask) {

            if (!ModelState.IsValid) {
                return View();
            }

            var dbServiceTask = new ServiceTask(serviceTask.Code, serviceTask.Description, serviceTask.Hours);

            _serviceTaskRepo.Add(dbServiceTask);
            return RedirectToAction("Index");
        }

        // GET: ServiceTaskController/Edit/5
        public ActionResult Edit(int id) {

            var dbServiceTask = _serviceTaskRepo.GetById(id);
            if (dbServiceTask == null) {
                return NotFound();
            }

            var viewServiceTask = new ServiceTaskEditDto {
                Id = dbServiceTask.Id,
                Code = dbServiceTask.Code,
                Description = dbServiceTask.Description,
                Hours = dbServiceTask.Hours
            };
            return View(model: viewServiceTask);
        }

        // POST: ServiceTaskController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ServiceTaskEditDto serviceTask) {

            if (!ModelState.IsValid) {
                return View();
            }

            var dbServiceTask = _serviceTaskRepo.GetById(id);
            if (dbServiceTask == null) {
                return NotFound();
            }

            dbServiceTask.Code = serviceTask.Code;
            dbServiceTask.Description = serviceTask.Description;
            dbServiceTask.Hours = serviceTask.Hours;
            _serviceTaskRepo.Update(id, dbServiceTask);
            return RedirectToAction(nameof(Index));
        }

        // GET: ServiceTaskController/Delete/5
        public ActionResult Delete(int id) {

            var dbServiceTask = _serviceTaskRepo.GetById(id);
            if (dbServiceTask == null) {
                return NotFound();
            }

            var viewServiceTask = new ServiceTaskDeleteDto {
                Id = dbServiceTask.Id,
                Code = dbServiceTask.Code,
                Description = dbServiceTask.Description,
                Hours = dbServiceTask.Hours
            };
            return View(model: viewServiceTask);
        }

        // POST: ServiceTaskController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {

            _serviceTaskRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
