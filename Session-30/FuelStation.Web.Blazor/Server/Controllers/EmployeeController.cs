using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Blazor.Shared.Employee;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Web.Blazor.Server.Controllers {
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
            return result.Select(employee => new EmployeeListDto {
                Id = employee.Id,
                Name = employee.Name,
                Surname = employee.Surname,
                HireDateStart = employee.HireDateStart,
                HireDateEnd = employee.HireDateEnd,
                SallaryPerMonth = employee.SallaryPerMonth,
                EmployeeType = employee.EmployeeType
            });
        }
    }
}
