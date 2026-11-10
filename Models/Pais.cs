using System.ComponentModel.DataAnnotations;

namespace GestionPersonas.Models;

public class Pais
{
    public int Id { get; set; }

    [Required, StringLength(100)]
    public string Nombre { get; set; } = string.Empty;

    public ICollection<Ciudad> Ciudades { get; set; } = new List<Ciudad>();
}
