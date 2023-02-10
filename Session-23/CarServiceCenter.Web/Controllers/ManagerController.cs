using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenter.Web.Models.Customer;
using CarServiceCenter.Web.Models.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceCenter.Web.Controllers {
    public class ManagerController : Controller {

        private readonly IEntityRepo<Manager> _managerRepo;

        public ManagerController(IEntityRepo<Manager> managerRepo) {
            _managerRepo = managerRepo;
        }

        // GET: ManagerController
        public ActionResult Index() {

            var managers = _managerRepo.GetAll().ToList();
            return View(model: managers);
        }

        // GET: ManagerController/Details/5
        public ActionResult Details(int? id) {

            if (id == null) {
                return NotFound();
            }

            var manager = _managerRepo.GetById(id.Value);
            if (manager == null) {
                return NotFound();
            }

            var viewManager = new ManagerDetailsDto {
                Id = manager.Id,
                Name = manager.Name,
                Surname = manager.Surname,
                SalaryPerMonth = manager.SalaryPerMonth,
                Transactions = manager.Transactions.ToList(),
                Engineers = manager.Engineers.ToList()
            };
            return View(model: viewManager);
        }

        // GET: ManagerController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: ManagerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ManagerCreateDto manager) {

            if (!ModelState.IsValid) {
                return View();
            }

            var dbManager = new Manager(manager.Name, manager.Surname, manager.SalaryPerMonth);

            _managerRepo.Add(dbManager);
            return RedirectToAction("Index");
        }

        // GET: ManagerController/Edit/5
        public ActionResult Edit(int id) {

            var dbManager = _managerRepo.GetById(id);
            if (dbManager == null) {
                return NotFound();
            }

            var viewManager = new ManagerEditDto {
                Id = dbManager.Id,
                Name = dbManager.Name,
                Surname = dbManager.Surname,
                SalaryPerMonth = dbManager.SalaryPerMonth
            };
            return View(model: viewManager);
        }

        // POST: ManagerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ManagerEditDto manager) {

            if (!ModelState.IsValid) {
                return View();
            }

            var dbManager = _managerRepo.GetById(id);
            if (dbManager == null) {
                return NotFound();
            }

            dbManager.Name = manager.Name;
            dbManager.Surname = manager.Surname;
            dbManager.SalaryPerMonth = manager.SalaryPerMonth;
            _managerRepo.Update(id, dbManager);
            return RedirectToAction(nameof(Index));
        }

        // GET: ManagerController/Delete/5
        public ActionResult Delete(int id) {

            var dbManager = _managerRepo.GetById(id);
            if (dbManager == null) {
                return NotFound();
            }

            var viewManager = new ManagerDeleteDto {
                Id = dbManager.Id,
                Name = dbManager.Name,
                Surname = dbManager.Surname,
                SalaryPerMonth = dbManager.SalaryPerMonth
            };
            return View(model: viewManager);
        }

        // POST: ManagerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {

            _managerRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
