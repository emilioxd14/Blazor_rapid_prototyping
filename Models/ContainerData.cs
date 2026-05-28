using System.ComponentModel.DataAnnotations;

namespace FH_Kufstein_Blazor_WebAppProject.Models;

public class ContainerData
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string Name { get; set; } = string.Empty;

    public DateTime DateTime { get; set; }

    [Required(ErrorMessage = "La ubicación es obligatoria")]
    public string Location { get; set; } = string.Empty;

    [Required(ErrorMessage = "El tipo es obligatorio")]
    public string ContainerType { get; set; } = string.Empty;

    [Range(1, 10000, ErrorMessage = "La capacidad debe ser mayor a 0")]
    public int Capacity { get; set; }

    [Range(0, 10000, ErrorMessage = "El nivel debe ser positivo")]
    public int CurrentLevel { get; set; }

    public string[]? Measurements { get; set; }
}