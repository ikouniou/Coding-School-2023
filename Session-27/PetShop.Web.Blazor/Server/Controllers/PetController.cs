using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;
using PetShop.Model.Enums;
using PetShop.Web.Blazor.Shared.Customer;
using PetShop.Web.Blazor.Shared.Pet;

namespace PetShop.Web.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IEntityRepo<Pet> _petRepo;
        public PetController(IEntityRepo<Pet> petRepo)
        {
            _petRepo = petRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<PetListDto>> Get()
        {
            var result = _petRepo.GetAll();
            return result.Select(pet => new PetListDto
            {
                Id = pet.Id,
                Breed = pet.Breed,
                AnimalType = pet.AnimalType,
                PetStatus= pet.PetStatus,
                Price = pet.Price,
                Cost = pet.Cost,
               
            });
        }

        [HttpGet("{id}")]
        public async Task<PetEditDto> GetById(int id)
        {
            var result = _petRepo.GetById(id);
            return new PetEditDto
            {
                Id = id,
                Breed = result.Breed,
                AnimalType = result.AnimalType,
                PetStatus = result.PetStatus,
                Price = result.Price,
                Cost = result.Cost,
             
            };
        }

        [HttpPost]
        public async Task Post(PetEditDto pet)
        {
            var newPet = new Pet(pet.Breed, pet.AnimalType, pet.PetStatus, pet.Price, pet.Cost );


            _petRepo.Add(newPet);
        }
        [HttpPut]
        public async Task Put(PetEditDto pet)
        {
            var itemToUpdate = _petRepo.GetById(pet.Id);
            itemToUpdate.Breed = pet.Breed;
            itemToUpdate.AnimalType = pet.AnimalType;
            itemToUpdate.PetStatus = pet.PetStatus;
            itemToUpdate.Price = pet.Price;
            itemToUpdate.Cost = pet.Cost;
            _petRepo.Update(pet.Id, itemToUpdate);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _petRepo.Delete(id);
        }
    }
}
