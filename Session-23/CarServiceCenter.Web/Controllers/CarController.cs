using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenter.Web.Models.Car;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceCenter.Web.Controllers {
    public class CarController : Controller {

        private readonly IEntityRepo<Car> _carRepo;
        public CarController(IEntityRepo<Car> carRepo) {
            
            _carRepo = carRepo;
        }

        // GET: CarController
        public ActionResult Index() {

            var cars = _carRepo.GetAll().ToList();
            return View(model: cars);
        }

        // GET: CarController/Details/5
        public ActionResult Details(int? id) {
            
            if (id == null) {
                return NotFound();
            }

            var car = _carRepo.GetById(id.Value);
            if (car == null) {
                return NotFound();
            }

            var viewCar = new CarDetailsDto {
                Id = car.Id,
                Brand = car.Brand,
                Model = car.Model,
                CarRegistrationNumber = car.CarRegistrationNumber,
                Transactions = car.Transactions.ToList()
            };
            return View(model: viewCar);

        }

        // GET: CarController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: CarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CarCreateDto car) {

            if (!ModelState.IsValid) {
                return View();
            }

            var dbCar = new Car(car.Brand, car.Model, car.CarRegistrationNumber);
            
            _carRepo.Add(dbCar);
            return RedirectToAction("Index");
        }

        // GET: CarController/Edit/5
        public ActionResult Edit(int id) {
            
            var dbCar = _carRepo.GetById(id);
            if (dbCar == null) {
                return NotFound();
            }

            var viewCar = new CarEditDto {
                Id = dbCar.Id,
                Brand = dbCar.Brand,
                Model = dbCar.Model,
                CarRegistrationNumber = dbCar.CarRegistrationNumber
            };
            return View(model: viewCar);
        }

        // POST: CarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CarEditDto car) {

            if (!ModelState.IsValid) {
                return View();
            }

            var dbCar = _carRepo.GetById(id);
            if (dbCar == null) {
                return NotFound();
            }

            dbCar.Brand = car.Brand;
            dbCar.Model = car.Model;
            dbCar.CarRegistrationNumber = car.CarRegistrationNumber;
            _carRepo.Update(id, dbCar);
            return RedirectToAction(nameof(Index));
        }

        // GET: CarController/Delete/5
        public ActionResult Delete(int id) {

            var dbCar = _carRepo.GetById(id);
            if (dbCar == null) {
                return NotFound();
            }

            var viewCar = new CarDeleteDto {
                Id = dbCar.Id,
                Brand = dbCar.Brand,
                Model = dbCar.Model,
                CarRegistrationNumber = dbCar.CarRegistrationNumber
            };
            return View(model: viewCar);
        }

        // POST: CarController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {

            _carRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
