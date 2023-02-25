using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Blazor.Shared.Transaction;
using FuelStation.Web.Blazor.Shared.TransactionLine;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Web.Blazor.Server.Controllers {
	[Route("[controller]")]
	[ApiController]
	public class TransactionController : ControllerBase {
		private readonly IEntityRepo<Transaction> _transactionRepo;

		public TransactionController(IEntityRepo<Transaction> transactionRepo) {
			_transactionRepo = transactionRepo;
		}

		[HttpGet]
		public async Task<IEnumerable<TransactionListDto>> Get() {
			var result = _transactionRepo.GetAll();
			return result.Select(item => new TransactionListDto {
				Id = item.Id,
				Date = item.Date,
				PaymentMethod = item.PaymentMethod,
				TotalValue = item.TotalValue,
				CustomerId = item.CustomerId,
				EmployeeId = item.EmployeeId,
				TransactionLines = item.TransactionLines.Select(transactionLine => new TransactionLineListDto {
					Id = transactionLine.Id,
					Quantity = transactionLine.Quantity,
					ItemPrice = transactionLine.ItemPrice,
					NetValue = transactionLine.NetValue,
					DiscountPercent = transactionLine.DiscountPercent,
					DiscountValue = transactionLine.DiscountValue,
					TotalValue = transactionLine.TotalValue,
					TransactionId = transactionLine.TransactionId,
					ItemId = transactionLine.ItemId
				}).ToList()
			});
		}

		[HttpGet("{id}")]
		public async Task<TransactionEditDto> GetById(int id) {
			var result = _transactionRepo.GetById(id);
			return new TransactionEditDto {
				Id = id,
				Date = result.Date,
				PaymentMethod = result.PaymentMethod,
				TotalValue = result.TotalValue,
				CustomerId = result.CustomerId,
				EmployeeId = result.EmployeeId,
				TransactionLines = result.TransactionLines.Select(transactionLine => new TransactionLineEditDto {
					Id = transactionLine.Id,
					Quantity = transactionLine.Quantity,
					ItemPrice = transactionLine.ItemPrice,
					NetValue = transactionLine.NetValue,
					DiscountPercent = transactionLine.DiscountPercent,
					DiscountValue = transactionLine.DiscountValue,
					TotalValue = transactionLine.TotalValue,
					TransactionId = transactionLine.TransactionId,
					ItemId = transactionLine.ItemId
				}).ToList()
			};
		}


		[HttpPost]
		public async Task Post(TransactionEditDto transaction) {
			var newTransaction = new Transaction(transaction.PaymentMethod, transaction.TotalValue) {
				CustomerId = transaction.CustomerId,
				EmployeeId = transaction.EmployeeId,
				//TransactionLines = transaction.TransactionLines
			};
			_transactionRepo.Add(newTransaction);
		}

		[HttpPut]
		public async Task Put(TransactionEditDto transaction) {
			var itemToUpdate = _transactionRepo.GetById(transaction.Id);
			itemToUpdate.Date = transaction.Date;
			itemToUpdate.PaymentMethod = transaction.PaymentMethod;
			itemToUpdate.TotalValue = transaction.TotalValue;
			itemToUpdate.CustomerId = transaction.CustomerId;
			itemToUpdate.EmployeeId = transaction.EmployeeId;
			//itemToUpdate.TransactionLines = transaction.TransactionLines;
			_transactionRepo.Update(transaction.Id, itemToUpdate);
		}

		[HttpDelete("{id}")]
		public async Task Delete(int id) {
			_transactionRepo.Delete(id);
		}
	}
}

