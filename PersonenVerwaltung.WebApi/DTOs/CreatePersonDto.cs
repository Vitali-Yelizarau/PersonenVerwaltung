using System.ComponentModel.DataAnnotations;

namespace PersonenVerwaltung.WebApi.DTOs;

public class CreatePersonDto
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = null!;

    [Required]
    [MaxLength(100)]
    public string Vorname { get; set; } = null!;

    public DateOnly Geburtsdatum { get; set; }

    public List<AnschriftDto> Anschriften { get; set; } = new();

    public List<string> Telefonnummern { get; set; } = new();
}