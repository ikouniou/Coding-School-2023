namespace CarServiceCenter.Web.Models.Manager {
    public class ManagerDetailsDto {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int SalaryPerMonth { get; set; }

        public List<CarServiceCenter.Model.Transaction> Transactions { get; set; } = new List<CarServiceCenter.Model.Transaction>();

        public List<CarServiceCenter.Model.Engineer> Engineers { get; set; } = new List<CarServiceCenter.Model.Engineer>();
    }
}
