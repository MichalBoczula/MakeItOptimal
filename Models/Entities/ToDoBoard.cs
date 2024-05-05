namespace MakeItOptimal.Models.Entities
{
    public record ToDoBoard
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<ToDoList>? Lists { get; set; }
    }
}
