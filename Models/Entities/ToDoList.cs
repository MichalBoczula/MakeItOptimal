namespace MakeItOptimal.Models.Entities
{
    public record ToDoList
    {
        public int Id { get; set; }
        public required int Name { get; set; }
        public List<ToDoTask>? Tasks { get; set; }
        public required int ToDoBoardId { get; set; }
        public ToDoBoard ToDoBoardRef { get; set; }
    }
}
