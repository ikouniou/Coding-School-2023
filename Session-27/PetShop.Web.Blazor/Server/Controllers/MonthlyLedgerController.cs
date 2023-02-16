using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;
using PetShop.Web.Blazor.Shared.Pet;
using PetShop.Web.Blazor.Shared.Transaction;

namespace PetShop.Web.Blazor.Server.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class MonthlyLedgerController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Pet> _petRepo;
        private readonly IEntityRepo<PetFood> _petFoodRepo;
        public MonthlyLedgerController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Pet> petRepo, IEntityRepo<PetFood> petFoodRepo)
        {
            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _petRepo = petRepo;
            _petFoodRepo = petFoodRepo;
        }

		[HttpGet]
		public async Task<IEnumerable<TransactionListDto>> Get()
        {
            var result = _transactionRepo.GetAll();
            var pets = _petRepo.GetAll();
            return result.Select(transaction => new TransactionListDto
            {
                Id = transaction.Id,
                Date = transaction.Date,
                PetPrice = transaction.PetPrice,
                PetFoodQty = transaction.PetFoodQty,
                PetFoodPrice = transaction.PetFoodPrice,
                TotalPrice = transaction.TotalPrice,
                PetId = transaction.PetId,
                PetFoodId = transaction.PetFoodId,
                PetFoodAnimalType = transaction.PetFood.AnimalType,
                PetBreed = transaction.Pet.Breed,
				
			});
        }
    }
}
