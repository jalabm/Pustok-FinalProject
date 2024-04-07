﻿using System;
using Pustok.Models.baseModels;

namespace Pustok.Models
{
	public class Tag:BaseModel
	{
		public string Name { get; set; } = null!;
		public ICollection<ProductTag> ProducTags { get; set; } = new List<ProductTag>();
	}
}

