using System.ComponentModel.DataAnnotations;

namespace GestionPersonas.Models;

public class Ciudad
{
    public int Id { get; set; }

    [Required, StringLength(100)]
    public string Nombre { get; set; } = string.Empty;

    public int PaisId { get; set; }

    public Pais? Pais { get; set; }
}
