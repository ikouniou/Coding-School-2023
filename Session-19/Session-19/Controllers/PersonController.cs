using Microsoft.AspNetCore.Mvc;

namespace Session_19.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase {

        [HttpGet(Name = "GetPerson")]
        public Person Get() {


            Person person = new Person() {
                Name = "Ioanna",
                Surname = "Kouniou"
            };

            return person;
        }
    }
}
