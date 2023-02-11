namespace CarServiceCenter.Web.Models.ServiceTask {
    public class ServiceTaskDetailsDto {
        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Hours { get; set; }
        public List<CarServiceCenter.Model.TransactionLine> TransactionLines { get; set; } = new List<CarServiceCenter.Model.TransactionLine>();
    }
}
