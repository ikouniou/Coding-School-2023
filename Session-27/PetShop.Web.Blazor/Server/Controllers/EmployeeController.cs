using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;
using PetShop.Model.Enums;
using PetShop.Web.Blazor.Shared.Employee;
using System.Security.Cryptography;

namespace PetShop.Web.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase {
        private readonly IEntityRepo<Employee> _employeeRepo;

        public EmployeeController(IEntityRepo<Employee> employeeRepo) {
            _employeeRepo = employeeRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeListDto>> Get() {
            var result = _employeeRepo.GetAll();
            return result.Select(todo => new EmployeeListDto {
                Id = todo.Id,
                Name = todo.Name,
                Surname = todo.Surname,
                EmployeeType = todo.EmployeeType,
                SalaryPerMonth = todo.SalaryPerMonth
            });
        }

        [HttpGet("{id}")]
        public async Task<EmployeeEditDto> GetById(int id) {
            var result = _employeeRepo.GetById(id);
            return new EmployeeEditDto {
                Id = id,
                Name = result.Name,
                Surname = result.Surname,
                EmployeeType = result.EmployeeType,
                SalaryPerMonth = result.SalaryPerMonth
            };
        }

        [HttpPost]
        public async Task Post(EmployeeEditDto employee) {
            var newEmployee = new Employee(employee.Name, employee.Surname, employee.EmployeeType, employee.SalaryPerMonth);
            _employeeRepo.Add(newEmployee);
        }

        [HttpPut]
        public async Task Put(EmployeeEditDto employee) {
            var itemToUpdate = _employeeRepo.GetById(employee.Id);
            itemToUpdate.Name = employee.Name;
            itemToUpdate.Surname = employee.Surname;
            itemToUpdate.EmployeeType = employee.EmployeeType;
            itemToUpdate.SalaryPerMonth = employee.SalaryPerMonth;
            _employeeRepo.Update(employee.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            _employeeRepo.Delete(id);
        }
    }
}