using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;
using PetShop.Model.Enums;
using PetShop.Web.Blazor.Shared.Employee;
using System.Security.Cryptography;

namespace PetShop.Web.Blazor.Server.Controllers {
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
    }
}