using System;
namespace MauiAutomapper.Models
{
    public class Parent
    {
        public string Name { get; set; }
        public IEnumerable<Child> Children { get; set; }
    }
}

