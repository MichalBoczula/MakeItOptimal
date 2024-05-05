using MakeItOptimal.Models.Enums;

namespace MakeItOptimal.Models.Entities
{
    public record ToDoTask
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required Status Status { get; set; }
        public required int ToDoListId { get; set; }
        public ToDoList ToDoListRef { get; set; }
    }
}
