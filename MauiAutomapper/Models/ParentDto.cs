using System;
namespace MauiAutomapper.Models
{
    public class ParentDto
    {
        public string Name { get; set; }
        public IEnumerable<ChildDto> Children { get; set; }
    }
}

