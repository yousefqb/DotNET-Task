/*
 
* 1- 
EF Core Naming Conventions: Automatically recognizes properties named Id or <EntityName>Id (case-insensitively) as the entity's primary key by default.
Convention over Configuration: Follows framework default rules to eliminate redundant code declarations (e.g., [Key] attribute or Fluent API .HasKey()).
Automatic Identity Generation: Automatically maps integer numeric key types (int, long) to auto-incrementing identity columns in relational databases.
 
* 2-
 Optional Field Defaults: Reference types (string or string?)
 are treated as optional fields by EF Core unless explicitly configured with [Required] or Fluent API .IsRequired().
 Nullable Reference Types (NRT) Rule: In C# 8+, explicitly declaring string? Country maps directly to a nullable column (NULL), 
 while string Country with NRT enabled generates NOT NULL.

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF03.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        public DateTime? PublishedDate { get; set; }
    }
}
