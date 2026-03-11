using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Domain
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) 
            : base(options) 
        { 
            Database.EnsureCreated();
        }

        public DbSet<ToDoItem> ToDos {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoItem>().HasData(
                new ToDoItem { Id = 1, Name = "Дати завдання на Лаб1", IsCompleted = false },
                new ToDoItem { Id = 2, Name = "Дати завдання на Лаб2", IsCompleted = false },
                new ToDoItem { Id = 3, Name = "Дати завдання на Лаб3", IsCompleted = true }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
