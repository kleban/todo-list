using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp.Domain.Entities
{
    public class ToDoItem
    {
        public int Id {  get; set; }
        public string TaskName { get; set; }
        public bool IsCompleted { get; set; }
    }
}
