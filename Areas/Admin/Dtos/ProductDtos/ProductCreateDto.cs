﻿using System;
using System.ComponentModel.DataAnnotations;
using Pustok.Models;

namespace Pustok.Areas.Admin.Dtos
{
    public class ProductCreateDto
	{
        public string Name { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public int RevardPoints { get; set; }
        public bool IsStock { get; set; }
        public decimal Price { get; set; }
        [Range(0,100)]
        public decimal Discount { get; set; }
        [Range(0,6)]
        public decimal Rating { get; set; }
        public string ShortDescription { get; set; } = null!;
        public string LongDescription { get; set; } = null!;
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }

        public IFormFile MainFile { get; set; } = null!;
        public IFormFile HoverFile { get; set; } = null!;
        public List<IFormFile> AdditionalFiles { get; set; } = new();
        public List<int> TagIds { get; set; } = new();
    }
}

