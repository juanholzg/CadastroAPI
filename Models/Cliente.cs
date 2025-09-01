using System.ComponentModel.DataAnnotations;

namespace CadastroAPI.Models;

public class Cliente
{
    public int Id { get; set; }
    [Required]
    [MaxLength(80, ErrorMessage = "Número de caracteres e excedido")]
    public string? Nome { get; set; }
    [Required]
    [EmailAddress]
    [MaxLength(255)]
    public string? Email { get; set; }
    [Length(9, 11)]
    public string? Telefone { get; set; }
    [Required]
    [Length(11, 14, ErrorMessage = "xxx.xxx.xxx-xx")]
    public string? Cpf { get; set; }
}