using System.ComponentModel.DataAnnotations;
namespace NotesApp.Models.DTOs;

public class CreateNoteDto {
    [Required(ErrorMessage = "Заголовоу обязателен")]
    [MaxLength(200, ErrorMessage = "Максимум 200 символов")]
    public string Title { get; set; } = string.Empty;

    [MaxLength(5000, ErrorMessage = "Максимум 5000 символов")]
    public string Content { get; set; } = string.Empty;

    [Range(1, 5, ErrorMessage = "Приоритет от 1 до 5")]
    public int Priority { get; set; } = 3;

    [Required(ErrorMessage = "Категория обязательна")]
    public int CategoryId { get; set; }
    
    public class UpdateNeteDto {
        [Required(ErrorMessage = "Заголовок обязателен")]
        [MaxLength(200, ErrorMessage = "Максимум 200 символов")]
        public string Title { get; set; } = string.Empty;

        [MaxLength(5000, ErrorMessage = "Максимум 5000 символов")]
        public string Content { get; set; } = string.Empty;

       [Range(1, 5, ErrorMessage = "Приоритет от 1 до 5")]
        public int Priority { get; set; } = 3;

        [Required(ErrorMessage = "Категория обязательна")]
        public int CategoryId { get; set; }
    }
}