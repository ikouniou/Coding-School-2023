using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Blazor.Shared.TransactionLine;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Web.Blazor.Server.Controllers {
	[Route("[controller]")]
	[ApiController]
	public class TransactionLineController : ControllerBase {
		private readonly IEntityRepo<TransactionLine> _transactionLineRepo;

		public TransactionLineController(IEntityRepo<TransactionLine> transactionLineRepo) {
			_transactionLineRepo = transactionLineRepo;
		}

		[HttpGet]
		public async Task<IEnumerable<TransactionLineListDto>> Get() {
			var result = _transactionLineRepo.GetAll();
			return result.Select(item => new TransactionLineListDto {
				Id = item.Id,
				Quantity = item.Quantity,
				ItemPrice = item.ItemPrice,
				NetValue = item.NetValue,
				DiscountPercent = item.DiscountPercent,
				DiscountValue = item.DiscountValue,
				TotalValue = item.TotalValue,
				TransactionId = item.TransactionId,
				ItemId = item.ItemId
			});
		}

		[HttpGet("{id}")]
		public async Task<TransactionLineEditDto> GetById(int id) {
			var result = _transactionLineRepo.GetById(id);
			return new TransactionLineEditDto {
				Id = id,
				Quantity = result.Quantity,
				ItemPrice = result.ItemPrice,
				NetValue = result.NetValue,
				DiscountPercent = result.DiscountPercent,
				DiscountValue = result.DiscountValue,
				TotalValue = result.TotalValue,
				TransactionId = result.TransactionId,
				ItemId = result.ItemId
			};
		}


		[HttpPost]
		public async Task Post(TransactionLineEditDto transactionLine) {
			var newTransactionLine = new TransactionLine(transactionLine.Quantity, transactionLine.ItemPrice, transactionLine.NetValue, transactionLine.DiscountPercent, transactionLine.DiscountValue, transactionLine.TotalValue) {
				TransactionId = transactionLine.TransactionId,
				ItemId = transactionLine.ItemId
			};
			_transactionLineRepo.Add(newTransactionLine);
		}

		[HttpPut]
		public async Task Put(TransactionLineEditDto transactionLine) {
			var itemToUpdate = _transactionLineRepo.GetById(transactionLine.Id);
			itemToUpdate.Quantity = transactionLine.Quantity;
			itemToUpdate.ItemPrice = transactionLine.ItemPrice;
			itemToUpdate.NetValue = transactionLine.NetValue;
			itemToUpdate.DiscountPercent = transactionLine.DiscountPercent;
			itemToUpdate.DiscountValue = transactionLine.DiscountValue;
			itemToUpdate.TotalValue = transactionLine.TotalValue;
			itemToUpdate.TransactionId = transactionLine.TransactionId;
			itemToUpdate.ItemId = transactionLine.ItemId;
			_transactionLineRepo.Update(transactionLine.Id, itemToUpdate);
		}

		[HttpDelete("{id}")]
		public async Task Delete(int id) {
			_transactionLineRepo.Delete(id);
		}
	}
}
