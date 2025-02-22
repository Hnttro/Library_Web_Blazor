﻿namespace NT_21K4080057.Components.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public DateTime PublishedDate { get; set; }
        public string? Category { get; set; }
        public string? Description { get; set; }
        public bool Available { get; set; }
        public string? Anh { get; set; }
    }
}
