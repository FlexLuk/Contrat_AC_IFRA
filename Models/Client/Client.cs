using System;
using System.Collections.Generic;

namespace Contrat_AC.Models.Client;

public partial class Client
{
    public long Clientid { get; set; }

    public string? Nom { get; set; }

    public string Prenom { get; set; } = null!;

    public string? Nationalite { get; set; }

    public string? Fonction { get; set; }

    public string? TypeIdentite { get; set; }

    public string? NumeroPiece { get; set; }

    public DateTime? DateNaissance { get; set; }

    public string? LieuNaissance { get; set; }

    public DateTime? DelivreLe { get; set; }

    public string? DelivreA { get; set; }

    public string? Adresse { get; set; }

    public string? Pays { get; set; }

    public string? Ville { get; set; }

    public string? CodePostal { get; set; }

    public string? Telephone { get; set; }

    public string? Email { get; set; }

    public string? NomCompletPere { get; set; }

    public string? NomCompletMere { get; set; }
}
