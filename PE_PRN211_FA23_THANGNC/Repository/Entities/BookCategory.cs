﻿using System;
using System.Collections.Generic;

namespace Repository.Entities;

public partial class BookCategory
{
    public int BookCategoryId { get; set; }

    public string BookGenreType { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
