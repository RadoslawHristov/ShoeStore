﻿namespace ShoeStore.Models.models
{
    public class Shoe
    {
        public int Id { get; set; }
        public int Size { get; set; }

        public int BrandId;

        public DateTime ReleaseDate { get; set; }
    }
}
