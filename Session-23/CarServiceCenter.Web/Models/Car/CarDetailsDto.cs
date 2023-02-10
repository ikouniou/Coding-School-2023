namespace CarServiceCenter.Web.Models.Car {
    public class CarDetailsDto {
        public int Id { get; set; }
        public string Brand { get; set; } = null!;
        public string Model { get; set; } = null!;
        public string CarRegistrationNumber { get; set; } = null!;

        public List<CarServiceCenter.Model.Transaction> Transactions { get; set; } = new List<CarServiceCenter.Model.Transaction>();
    }
}
