namespace CarServiceCenter.Web.Models.Engineer {
    public class EngineerDetailsDto {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int SalaryPerMonth { get; set; }
        public int ManagerId { get; set; }
        public string ManagerName { get; set; } = null!;
        public string ManagerSurname { get; set; } = null!;
        public List<CarServiceCenter.Model.TransactionLine> TransactionLines { get; set; } = new List<CarServiceCenter.Model.TransactionLine>();
    }
}
