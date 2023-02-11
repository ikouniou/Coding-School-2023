using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenter.Web.Models.Engineer;
using CarServiceCenter.Web.Models.Transaction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;

namespace CarServiceCenter.Web.Controllers {
    public class TransactionController : Controller {

        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Manager> _managerRepo;
        private readonly IEntityRepo<Car> _carRepo;

        public TransactionController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Manager> managerRepo, IEntityRepo<Car> carRepo) {
            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _managerRepo = managerRepo;
            _carRepo = carRepo;
        }

        // GET: TransactionController
        public ActionResult Index() {

            var transactions = _transactionRepo.GetAll();
            return View(model: transactions);
        }

        // GET: TransactionController/Details/5
        public ActionResult Details(int? id) {

            if (id == null) {
                return NotFound();
            }

            var transaction = _transactionRepo.GetById(id.Value);
            if (transaction == null) {
                return NotFound();
            }

            var viewTransaction = new TransactionDetailsDto {
                Id = transaction.Id,
                TotalPrice = transaction.TotalPrice,
                Date = transaction.Date,
                ManagerId = transaction.ManagerId,
                ManagerName = transaction.Manager.Name,
                ManagerSurname = transaction.Manager.Surname,
                CustomerId = transaction.CustomerId,
                CustomerName = transaction.Customer.Name,
                CustomerSurname = transaction.Customer.Surname,
                CarId = transaction.CarId,
                CarBrand = transaction.Car.Brand,
                CarModel = transaction.Car.Model,
                CarRegistrationNumber = transaction.Car.CarRegistrationNumber,
                TransactionLines = transaction.TransactionLines.ToList()
            };
            return View(model: viewTransaction);
        }

        // GET: TransactionController/Create
        public ActionResult Create() {

            var newTransaction = new TransactionCreateDto();
            var managers = _managerRepo.GetAll();
            foreach (var manager in managers) {
                string managerFullName = $"{manager.Name} {manager.Surname}";
                newTransaction.Managers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(managerFullName, manager.Id.ToString()));
            }
            var customers = _customerRepo.GetAll();
            foreach (var customer in customers) {
                string customerFullName = $"{customer.Name} {customer.Surname}";
                newTransaction.Customers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(customerFullName, customer.Id.ToString()));
            }
            var cars = _carRepo.GetAll();
            foreach (var car in cars) {
                string carFullDetails = $"{car.Brand} {car.Model} {car.CarRegistrationNumber}";
                newTransaction.Cars.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(carFullDetails, car.Id.ToString()));
            }

            return View(model: newTransaction);
        }

        // POST: TransactionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionCreateDto transaction) {

            if (!ModelState.IsValid) {
                return View();
            }

            var dbTransaction = new Transaction(transaction.TotalPrice) {
                Date = DateTime.Now,
                ManagerId = transaction.ManagerId,
                CustomerId = transaction.CustomerId,
                CarId = transaction.CarId
            };

            _transactionRepo.Add(dbTransaction);
            return RedirectToAction("Index");
        }

        // GET: TransactionController/Edit/5
        public ActionResult Edit(int id) {

            var dbTransaction = _transactionRepo.GetById(id);
            if (dbTransaction == null) {
                return NotFound();
            }

            var transactionDto = new TransactionEditDto {
                Id = dbTransaction.Id,
                Date = dbTransaction.Date,
                TotalPrice = dbTransaction.TotalPrice,
                ManagerId = dbTransaction.ManagerId,
                CustomerId = dbTransaction.CustomerId,
                CarId = dbTransaction.CarId
            };

            var managers = _managerRepo.GetAll();
            foreach (var manager in managers) {
                string managerFullName = $"{manager.Name} {manager.Surname}";
                transactionDto.Managers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(managerFullName, manager.Id.ToString()));
            }
            var customers = _customerRepo.GetAll();
            foreach (var customer in customers) {
                string customerFullName = $"{customer.Name} {customer.Surname}";
                transactionDto.Customers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(customerFullName, customer.Id.ToString()));
            }
            var cars = _carRepo.GetAll();
            foreach (var car in cars) {
                string carFullDetails = $"{car.Brand} {car.Model} {car.CarRegistrationNumber}";
                transactionDto.Cars.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(carFullDetails, car.Id.ToString()));
            }

            return View(transactionDto);
        }

        // POST: TransactionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TransactionEditDto transaction) {

            if (!ModelState.IsValid) {
                return View();
            }

            var dbTransaction = _transactionRepo.GetById(id);
            if (dbTransaction == null) {
                return NotFound();
            }

            dbTransaction.Date = transaction.Date;
            dbTransaction.TotalPrice = transaction.TotalPrice;
            dbTransaction.ManagerId = transaction.ManagerId;
            dbTransaction.CustomerId = transaction.CustomerId;
            dbTransaction.CarId = transaction.CarId;

            _transactionRepo.Update(id, dbTransaction);
            return RedirectToAction(nameof(Index));
        }

        // GET: TransactionController/Delete/5
        public ActionResult Delete(int id) {

            var dbTransaction = _transactionRepo.GetById(id);
            if (dbTransaction == null) {
                return NotFound();
            }

            var viewTransaction = new TransactionDeleteDto {
                Id = dbTransaction.Id,
                TotalPrice = dbTransaction.TotalPrice,
                Date = dbTransaction.Date,
                ManagerId = dbTransaction.ManagerId,
                ManagerName = dbTransaction.Manager.Name,
                ManagerSurname = dbTransaction.Manager.Surname,
                CustomerId = dbTransaction.CustomerId,
                CustomerName = dbTransaction.Customer.Name,
                CustomerSurname = dbTransaction.Customer.Surname,
                CarId = dbTransaction.CarId,
                CarBrand = dbTransaction.Car.Brand,
                CarModel = dbTransaction.Car.Model,
                CarRegistrationNumber = dbTransaction.Car.CarRegistrationNumber
            };
            return View(model: viewTransaction);
        }

        // POST: TransactionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {

            _transactionRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
