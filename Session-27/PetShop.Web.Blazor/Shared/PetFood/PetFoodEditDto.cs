﻿using PetShop.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Web.Blazor.Shared.PetFood {
    public class PetFoodEditDto {
        public int Id { get; set; }
		[Required]
        public AnimalType AnimalType { get; set; }
		[RegularExpression(@"^(0|[1-9][0-9]?)(.\d{1,2})?$", ErrorMessage = "Invalid Cost Number.")]
		[Range(1, 99)]
		public decimal Price { get; set; }
		[RegularExpression(@"^(0|[1-9][0-9]?)(.\d{1,2})?$", ErrorMessage = "Invalid Cost Number.")]
		[Range(1,99)]
		public decimal Cost { get; set; }
    }
}
