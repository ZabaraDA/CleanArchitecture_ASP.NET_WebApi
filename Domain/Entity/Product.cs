﻿
using System.Text.Json.Serialization;

namespace Domain.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public byte[]? Photo { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
