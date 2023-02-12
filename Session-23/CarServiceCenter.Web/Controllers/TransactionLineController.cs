using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenter.Web.Models.Transaction;
using CarServiceCenter.Web.Models.TransactionLine;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceCenter.Web.Controllers {
    public class TransactionLineController : Controller {

        private readonly IEntityRepo<TransactionLine> _transactionLineRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<ServiceTask> _serviceTaskRepo;
        private readonly IEntityRepo<Engineer> _engineerRepo;

        public TransactionLineController(IEntityRepo<TransactionLine> transactionLineRepo, IEntityRepo<Transaction> transactionRepo, IEntityRepo<ServiceTask> serviceTaskRepo, IEntityRepo<Engineer> engineerRepo) {
            _transactionLineRepo = transactionLineRepo;
            _transactionRepo = transactionRepo;
            _serviceTaskRepo = serviceTaskRepo;
            _engineerRepo = engineerRepo;
        }

        // GET: TransactionLineController
        public ActionResult Index() {

            var transactionLines = _transactionLineRepo.GetAll();
            return View(model: transactionLines);
        }

        // GET: TransactionLineController/Details/5
        public ActionResult Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var transactionLine = _transactionLineRepo.GetById(id.Value);
            if (transactionLine == null) {
                return NotFound();
            }

            var viewTransactionLine = new TransactionLineDetailsDto {
                Id = transactionLine.Id,
                Hours = transactionLine.Hours,
                PricePerHour = transactionLine.PricePerHour,
                Price = transactionLine.Price,
                TransactionId = transactionLine.TransactionId,
                ServiceTaskId = transactionLine.ServiceTaskId,
                EngineerId = transactionLine.EngineerId,
                TransactionDate = transactionLine.Transaction.Date,
                TransactionTotalPrice = transactionLine.Transaction.TotalPrice,
                ServiceTaskCode = transactionLine.ServiceTask.Code,
                ServiceTaskDescription = transactionLine.ServiceTask.Description,
                ServiceTaskHours = transactionLine.ServiceTask.Hours,
                EngineerName = transactionLine.Engineer.Name,
                EngineerSurname = transactionLine.Engineer.Surname
            };
            return View(model: viewTransactionLine);
        }

        // GET: TransactionLineController/Create
        public ActionResult Create() {

            var newTransactionLine = new TransactionLineCreateDto();
            var transactions = _transactionRepo.GetAll();
            foreach (var transaction in transactions) {
                string transactionFullDetails = $"{transaction.Date} {transaction.Customer.Name} {transaction.Customer.Surname} {transaction.Car.CarRegistrationNumber}";
                newTransactionLine.Transactions.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(transactionFullDetails, transaction.Id.ToString()));
            }
            var serviceTasks = _serviceTaskRepo.GetAll();
            foreach (var serviceTask in serviceTasks) {
                string serviceTaskFullDetails = $"{serviceTask.Code} {serviceTask.Description}";
                newTransactionLine.ServiceTasks.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(serviceTaskFullDetails, serviceTask.Id.ToString()));
            }
            var engineers = _engineerRepo.GetAll();
            foreach (var engineer in engineers) {
                string engineerFullName = $"{engineer.Name} {engineer.Surname}";
                newTransactionLine.Engineers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(engineerFullName, engineer.Id.ToString()));
            }

            return View(model: newTransactionLine);
        }

        // POST: TransactionLineController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionLineCreateDto transactionLine) {

            if (!ModelState.IsValid) {
                return View();
            }

            var dbTransactionLine = new TransactionLine(transactionLine.Hours, transactionLine.PricePerHour, transactionLine.Price) {
                TransactionId = transactionLine.TransactionId,
                ServiceTaskId = transactionLine.ServiceTaskId,
                EngineerId = transactionLine.EngineerId
            };

            _transactionLineRepo.Add(dbTransactionLine);
            return RedirectToAction("Index");
        }

        // GET: TransactionLineController/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: TransactionLineController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: TransactionLineController/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: TransactionLineController/Delete/5
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
