﻿using System;
using System.Collections.Generic;

namespace EFDatabaseFirstDemo.Domain.Models
{
    public partial class Category
    {
        public Category()
        {
            Todos = new HashSet<Todo>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Todo> Todos { get; set; }
    }
}
