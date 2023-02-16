using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;
using PetShop.Model.Enums;
using PetShop.Web.Blazor.Shared.PetReport;

namespace PetShop.Web.Blazor.Server.Controllers {

    [Route("[controller]")]
    [ApiController]
    public class PetReportController : ControllerBase{
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Pet> _petRepo;
        private readonly IEntityRepo<PetFood> _petFoodRepo;

        public PetReportController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Pet> petRepo, IEntityRepo<PetFood> petFoodRepo) {
            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _petRepo = petRepo;
            _petFoodRepo = petFoodRepo;
        }

        [HttpGet]
        public IEnumerable<PetReportListDto> Get(int year, int month, AnimalType animalType) {
            var transactions = _transactionRepo.GetAll()
                .Where(t => t.Date.Year == year && t.Date.Month == month);

            var pets = _petRepo.GetAll()
                .Where(p => p.AnimalType == animalType);

            var petReportList = pets.Select(pet => new PetReportListDto {
                AnimalType = pet.AnimalType,
                TotalSold = transactions.Count(t => t.PetId == pet.Id)
            }).ToList();

            return petReportList;
        }
    }
}
