﻿namespace CarServiceCenter.Web.Models.Customer {
    public class CustomerDeleteDto {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Tin { get; set; } = null!;
    }
}
