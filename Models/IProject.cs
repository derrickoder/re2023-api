namespace re2023_api.Models
{
    public interface IProject
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        public string Image { get; set; }
        int StatusId { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime UpdatedDate { get; set; }
        int OwnerId { get; set; }
    }
}
