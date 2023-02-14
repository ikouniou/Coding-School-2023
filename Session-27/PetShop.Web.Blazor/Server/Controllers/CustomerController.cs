using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;
using PetShop.Web.Blazor.Shared.Customer;

namespace PetShop.Web.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        public CustomerController(IEntityRepo<Customer> customerRepo)
        {
            _customerRepo = customerRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerListDto>> Get()
        {
            var result = _customerRepo.GetAll();
            return result.Select(customer => new CustomerListDto
            {
                Name= customer.Name,
                Surname = customer.Surname,
                Phone = customer.Phone,
                Tin = customer.Tin,
                Id = customer.Id
            });
        }
        [HttpGet("{id}")]
        public async Task<CustomerEditDto> GetById(int id)
        {
            var result = _customerRepo.GetById(id);
            return new CustomerEditDto
            {
                Id = id,
                Name = result.Name,
                Surname = result.Surname,
                Phone = result.Phone,
                Tin = result.Tin
            };
        }

        [HttpPost]
        public async Task Post(CustomerEditDto customer)
        {
            var newCustomer = new Customer(customer.Name, customer.Surname, customer.Phone, customer.Tin);
            
            
            _customerRepo.Add(newCustomer);
        }

        [HttpPut]
        public async Task Put(CustomerEditDto customer)
        {
            var itemToUpdate = _customerRepo.GetById(customer.Id);
            itemToUpdate.Name = customer.Name;
            itemToUpdate.Surname = customer.Surname;
            itemToUpdate.Phone = customer.Phone;
            itemToUpdate.Tin = customer.Tin;
            _customerRepo.Update(customer.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _customerRepo.Delete(id);
        }

    }
}
