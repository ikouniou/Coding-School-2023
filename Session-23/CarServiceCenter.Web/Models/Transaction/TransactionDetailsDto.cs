namespace CarServiceCenter.Web.Models.Transaction {
    public class TransactionDetailsDto {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public int ManagerId { get; set; }
        public int CustomerId { get; set; }
        public int CarId { get; set; }

        public string ManagerName { get; set; } = null!;
        public string ManagerSurname { get; set; } = null!;
        public string CustomerName { get; set; } = null!;
        public string CustomerSurname { get; set; } = null!;
        public string CarBrand { get; set; } = null!;
        public string CarModel { get; set; } = null!;
        public string CarRegistrationNumber { get; set; } = null!;

        public List<CarServiceCenter.Model.TransactionLine> TransactionLines { get; set; } = new List<CarServiceCenter.Model.TransactionLine>();
    }
}
