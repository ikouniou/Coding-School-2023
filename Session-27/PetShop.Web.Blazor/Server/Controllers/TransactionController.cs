using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;

namespace PetShop.Web.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    { 
        private readonly IEntityRepo<Transaction> _transactionRepo;
        public TransactionController(IEntityRepo<Transaction> transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }
        [HttpGet]
        public async Task<IEnumerable<TransactionListDto>> Get()
        {
            var result = _transactionRepo.GetAll();
            return result.Select(transaction => new TransactionListDto
            {
                Id = transaction.Id,
                Date = transaction.Date,
                PetPrice = transaction.PetPrice,
                PetFoodQty = transaction.PetFoodQty,
                PetFoodPrice = transaction.PetFoodPrice,
                TotalPrice = transaction.TotalPrice
            });
        }
        [HttpGet("{id}")]
        public async Task<TransactionEditDto> GetById(int id)
        {
            var result = _transactionRepo.GetById(id);
            return new TransactionEditDto
            {
                Id = id,
                Date = result.Date,
                PetPrice = result.PetPrice,
                PetFoodQty = result.PetFoodQty,
                PetFoodPrice = result.PetFoodPrice,
                TotalPrice = result.TotalPrice
            };
        }

        [HttpPost]
        public async Task Post(TransactionEditDto transaction)
        {
            var newTransaction = new Transaction(transaction.PetPrice, transaction.PetFoodQty, transaction.PetFoodPrice, transaction.TotalPrice);
            _transactionRepo.Add(newTransaction);
        }
        [HttpPut]
        public async Task Put(TransactionEditDto transaction)
        {
            var itemToUpdate = _transactionRepo.GetById(transaction.Id);
            itemToUpdate.Date = transaction.Date;
            itemToUpdate.PetPrice = transaction.PetPrice;
            itemToUpdate.PetFoodQty = transaction.PetFoodQty;
            itemToUpdate.PetFoodPrice = transaction.PetFoodPrice;
            itemToUpdate.TotalPrice = transaction.TotalPrice;
            _transactionRepo.Update(transaction.Id, itemToUpdate);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _transactionRepo.Delete(id);
        }
    }
}
