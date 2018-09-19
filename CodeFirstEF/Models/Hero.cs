﻿namespace CodeFirstEF.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
    }
}