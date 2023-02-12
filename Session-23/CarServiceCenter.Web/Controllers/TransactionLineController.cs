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

            var dbTransactionLine = _transactionLineRepo.GetById(id);
            if (dbTransactionLine == null) {
                return NotFound();
            }

            var transactionLineDto = new TransactionLineEditDto {
                Id = dbTransactionLine.Id,
                Hours = dbTransactionLine.Hours,
                PricePerHour = dbTransactionLine.PricePerHour,
                Price = dbTransactionLine.Price,
                TransactionId = dbTransactionLine.TransactionId,
                ServiceTaskId = dbTransactionLine.ServiceTaskId,
                EngineerId = dbTransactionLine.EngineerId
            };

            var transactions = _transactionRepo.GetAll();
            foreach (var transaction in transactions) {
                string transactionFullDetails = $"{transaction.Date} {transaction.Customer.Name} {transaction.Customer.Surname} {transaction.Car.CarRegistrationNumber}";
                transactionLineDto.Transactions.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(transactionFullDetails, transaction.Id.ToString()));
            }
            var serviceTasks = _serviceTaskRepo.GetAll();
            foreach (var serviceTask in serviceTasks) {
                string serviceTaskFullDetails = $"{serviceTask.Code} {serviceTask.Description}";
                transactionLineDto.ServiceTasks.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(serviceTaskFullDetails, serviceTask.Id.ToString()));
            }
            var engineers = _engineerRepo.GetAll();
            foreach (var engineer in engineers) {
                string engineerFullName = $"{engineer.Name} {engineer.Surname}";
                transactionLineDto.Engineers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(engineerFullName, engineer.Id.ToString()));
            }

            return View(transactionLineDto);
        }

        // POST: TransactionLineController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TransactionLineEditDto transactionLine) {

            if (!ModelState.IsValid) {
                return View();
            }

            var dbTransactionLine = _transactionLineRepo.GetById(id);
            if (dbTransactionLine == null) {
                return NotFound();
            }

            dbTransactionLine.Hours = transactionLine.Hours;
            dbTransactionLine.PricePerHour = transactionLine.PricePerHour;
            dbTransactionLine.Price = transactionLine.Price;
            dbTransactionLine.TransactionId = transactionLine.TransactionId;
            dbTransactionLine.ServiceTaskId = transactionLine.ServiceTaskId;
            dbTransactionLine.EngineerId = transactionLine.EngineerId;

            _transactionLineRepo.Update(id, dbTransactionLine);
            return RedirectToAction(nameof(Index));
        }

        // GET: TransactionLineController/Delete/5
        public ActionResult Delete(int id) {

            var dbTransactionLine = _transactionLineRepo.GetById(id);
            if (dbTransactionLine == null) {
                return NotFound();
            }

            var viewTransactionLine = new TransactionLineDeleteDto {
                Id = dbTransactionLine.Id,
                Hours = dbTransactionLine.Hours,
                PricePerHour = dbTransactionLine.PricePerHour,
                Price = dbTransactionLine.Price,
                TransactionId = dbTransactionLine.TransactionId,
                ServiceTaskId = dbTransactionLine.ServiceTaskId,
                EngineerId = dbTransactionLine.EngineerId,
                TransactionDate = dbTransactionLine.Transaction.Date,
                TransactionTotalPrice = dbTransactionLine.Transaction.TotalPrice,
                ServiceTaskCode = dbTransactionLine.ServiceTask.Code,
                ServiceTaskDescription = dbTransactionLine.ServiceTask.Description,
                ServiceTaskHours = dbTransactionLine.ServiceTask.Hours,
                EngineerName = dbTransactionLine.Engineer.Name,
                EngineerSurname = dbTransactionLine.Engineer.Surname
            };
            return View(model: viewTransactionLine);
        }

        // POST: TransactionLineController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {

            _transactionLineRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
