using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenter.Web.Models.Engineer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceCenter.Web.Controllers {
    public class EngineerController : Controller {

        private readonly IEntityRepo<Manager> _managerRepo;
        private readonly IEntityRepo<Engineer> _engineerRepo;

        public EngineerController(IEntityRepo<Manager> managerRepo, IEntityRepo<Engineer> engineerRepo) {
            _managerRepo = managerRepo;
            _engineerRepo = engineerRepo;
        }

        // GET: EngineerController
        public ActionResult Index() {
            
            var engineers = _engineerRepo.GetAll();
            return View(model: engineers);
        }

        // GET: EngineerController/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: EngineerController/Create
        public ActionResult Create() {

            var newEngineer = new EngineerCreateDto();
            var managers = _managerRepo.GetAll();
            foreach (var manager in managers) {
                newEngineer.Managers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(manager.Surname, manager.Id.ToString()));
            }

            return View(model: newEngineer);
        }

        // POST: EngineerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EngineerCreateDto engineer) {

            if (!ModelState.IsValid) {
                return View();
            }

            var dbEngineer = new Engineer(engineer.Name, engineer.Surname, engineer.SalaryPerMonth) {
                ManagerId = engineer.ManagerId
            };

            _engineerRepo.Add(dbEngineer);
            return RedirectToAction("Index");
        }

        // GET: EngineerController/Edit/5
        public ActionResult Edit(int id) {

            var dbEngineer = _engineerRepo.GetById(id);
            if (dbEngineer == null) {
                return NotFound();
            }

            var engineerDto = new EngineerEditDto {
                Id = dbEngineer.Id,
                Name = dbEngineer.Name,
                Surname = dbEngineer.Surname,
                SalaryPerMonth = dbEngineer.SalaryPerMonth,
                ManagerId = dbEngineer.ManagerId
            };

            var managers = _managerRepo.GetAll();
            foreach (var manager in managers) {
                engineerDto.Managers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(manager.Surname, manager.Id.ToString()));
            }

            return View(engineerDto);
        }

        // POST: EngineerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EngineerEditDto engineer) {

            if (!ModelState.IsValid) {
                return View();
            }

            var dbEngineer = _engineerRepo.GetById(id);
            if (dbEngineer == null) {
                return NotFound();
            }

            dbEngineer.Name = engineer.Name;
            dbEngineer.Surname = engineer.Surname;
            dbEngineer.SalaryPerMonth = engineer.SalaryPerMonth;
            dbEngineer.ManagerId = engineer.ManagerId;

            _engineerRepo.Update(id, dbEngineer);
            return RedirectToAction(nameof(Index));
        }

        // GET: EngineerController/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: EngineerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }
    }
}
