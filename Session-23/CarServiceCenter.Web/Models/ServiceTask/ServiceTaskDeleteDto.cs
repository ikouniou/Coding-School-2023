namespace CarServiceCenter.Web.Models.ServiceTask {
    public class ServiceTaskDeleteDto {
        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Hours { get; set; }
    }
}
