namespace CarServiceCenter.Web.Models.ServiceTask {
    public class ServiceTaskCreateDto {
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Hours { get; set; }
    }
}
