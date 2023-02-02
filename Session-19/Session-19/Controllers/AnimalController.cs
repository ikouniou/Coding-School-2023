using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Session_19.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class AnimalController : ControllerBase{

        [HttpGet(Name = "GetAnimal")]
        public List<Animal> Get() {

            List<Animal> animals = new List<Animal>();

            Animal animal1 = new Animal() {
                Name = "Max",
                Type = "Dog",
                OwnerName = "Ioanna"
            };

            Animal animal2 = new Animal() {
                Name = "Betty",
                Type = "Hamster",
                OwnerName = "Ioanna"
            };

            animals.Add(animal1);
            animals.Add(animal2);

            return animals;
        }

    }
}
