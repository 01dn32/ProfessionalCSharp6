﻿using Microsoft.Data.Entity;

namespace BooksSample
{
    public class BooksContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

    }
}