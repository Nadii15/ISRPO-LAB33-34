namespace NotesApp.Models.DTOs;

public class NoteResponseDto {
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public bool IsPinned { get; set; }
    public bool IsArchived{ get; set; }
    public int Priority { get; set; }
    public DateTime CreatedAt{ get; set; }
    public DateTime UpdatedAt { get; set; }
    public int CategoryId { get; set; }
    public string CategoryName { get; set; } = string.Empty;
    public string CategoryColor { get; set; } = string.Empty;
}

public class NoteFilterDto {
    public int? CategoryId { get; set; }
    public bool? IsPinned { get; set; }
    public bool Archived { get; set; } = false;
    public string? Search { get; set; }
    public int? MinPriority { get; set; }
    public string SortBy { get; set; } = "createdAt";
    public bool Descending { get; set; } = true;
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}