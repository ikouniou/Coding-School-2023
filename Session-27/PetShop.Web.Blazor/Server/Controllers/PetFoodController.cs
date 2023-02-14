﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;
using PetShop.Web.Blazor.Shared.PetFood;

namespace PetShop.Web.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class PetFoodController : ControllerBase {
        private readonly IEntityRepo<PetFood> _petFoodRepo;

        public PetFoodController(IEntityRepo<PetFood> petFoodRepo)
        {
            _petFoodRepo = petFoodRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<PetFoodListDto>> Get()
        {
            var result = _petFoodRepo.GetAll();
            return result.Select(petFood => new PetFoodListDto
            {
                Id = petFood.Id,
                AnimalType = petFood.AnimalType,
                Price = petFood.Price,
                Cost = petFood.Cost
            });
        }

        [HttpGet("{id}")]
        public async Task<PetFoodEditDto> GetById(int id)
        {
            var result = _petFoodRepo.GetById(id);
            return new PetFoodEditDto
            {
                Id = id,
                AnimalType = result.AnimalType,
                Price = result.Price,
                Cost = result.Cost
            };
        }

        [HttpPost]
        public async Task Post(PetFoodEditDto petFood)
        {
            var newPetFood = new PetFood(petFood.AnimalType, petFood.Price, petFood.Cost);
            _petFoodRepo.Add(newPetFood);
        }

        [HttpPut]
        public async Task Put(PetFoodEditDto petFood)
        {
            var itemToUpdate = _petFoodRepo.GetById(petFood.Id);
            itemToUpdate.AnimalType = petFood.AnimalType;
            itemToUpdate.Price = petFood.Price;
            itemToUpdate.Cost = petFood.Cost;
            _petFoodRepo.Update(petFood.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _petFoodRepo.Delete(id);
        }
    }
}
