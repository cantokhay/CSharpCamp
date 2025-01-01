﻿namespace BootcampDapper.DTOs
{
    public class ResultProductDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
    }
}