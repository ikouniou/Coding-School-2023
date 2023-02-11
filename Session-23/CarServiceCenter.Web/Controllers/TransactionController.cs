using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenter.Web.Models.Engineer;
using CarServiceCenter.Web.Models.Transaction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult Details(int id) {
            return View();
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
            return View();
        }

        // POST: TransactionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: TransactionController/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: TransactionController/Delete/5
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
