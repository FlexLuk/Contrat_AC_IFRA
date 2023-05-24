using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Contrat_AC.Models.Autorisation;

public partial class User
{
    public int UserId { get; set; }

    public string? FirstName { get; set; }

    [Required(ErrorMessage = "Email est obligatoire")]
    [EmailAddress(ErrorMessage = "Format email incorrect.")]
    public string AdressMail { get; set; } = null!;

    [Required(ErrorMessage = "Mot de passe est obligatoire")]
    [StringLength(8, ErrorMessage = "Lmot de passe doit contenir au minimum 8 caractères."), MinLength(8)]
    public string? Password { get; set; }

    public bool? Status { get; set; }

    public DateTime? DateCreate { get; set; }

    public bool? Connected { get; set; }

    public string? LastName { get; set; }

    public string? PasswordHash { get; set; }
}
