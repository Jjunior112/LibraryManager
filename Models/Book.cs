using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class Book
{
    [Required]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required(ErrorMessage = "Campo obrigatório!")]
    [StringLength(100)]
    [DisplayName("Título")]
    public string Title { get; set; } = "";

    [Required(ErrorMessage = "Campo obrigatório!")]
    [StringLength(80)]
    [DisplayName("Autor")]
    public string Author { get; set; } = "";

    [Required(ErrorMessage = "Campo obrigatório!")]
    [DisplayName("Ano")]
    public int Year { get; set; }
    [DisplayName("Disponível")]
    public bool IsAvailable { get; set; } = true;

    [DisplayName("Reservado em")]
    public DateTime ReservedAt { get; set; }
    [DisplayName("Reservado por")]
    public string User { get; set; } = "";

}