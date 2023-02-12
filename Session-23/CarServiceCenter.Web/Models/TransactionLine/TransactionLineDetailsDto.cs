namespace CarServiceCenter.Web.Models.TransactionLine {
    public class TransactionLineDetailsDto {
        public int Id { get; set; }
        public decimal Hours { get; set; }
        public decimal PricePerHour { get; set; }
        public decimal Price { get; set; }
        public int TransactionId { get; set; }
        public int ServiceTaskId { get; set; }
        public int EngineerId { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal TransactionTotalPrice { get; set; }
        public string ServiceTaskCode { get; set; } = null!;
        public string ServiceTaskDescription { get; set; } = null!;
        public decimal ServiceTaskHours { get; set; }
        public string EngineerName { get; set;} = null!;
        public string EngineerSurname { get; set; } = null!;

    }
}
