using System;
using System.Collections.Generic;

namespace Contrat_AC.Models.Autorisation;

public partial class User
{
    public int UserId { get; set; }

    public string? FirstName { get; set; }

    public string AdressMail { get; set; } = null!;

    public string? Password { get; set; }

    public bool? Status { get; set; }

    public DateTime? DateCreate { get; set; }

    public bool? Connected { get; set; }

    public string? LastName { get; set; }

    public string? PasswordHash { get; set; }
}
