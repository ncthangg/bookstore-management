﻿using System;
using System.Collections.Generic;

namespace Repository.Entities;

public partial class Book
{
    public int BookId { get; set; }

    public string BookName { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime ReleaseDate { get; set; }

    public int Quantity { get; set; }

    public double Price { get; set; }

    public int BookCategoryId { get; set; }

    public string Author { get; set; } = null!;

    public virtual BookCategory BookCategory { get; set; } = null!;
}
