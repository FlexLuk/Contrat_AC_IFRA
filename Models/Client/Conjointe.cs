using System;
using System.Collections.Generic;

namespace Contrat_AC.Models.Client;

public partial class Conjointe
{
    public long Conjointeid { get; set; }

    public long Clientid { get; set; }

    public string? Nom { get; set; }

    public string? Prenom { get; set; }

    public DateTime? DateNaissance { get; set; }

    public string? LieuNaissance { get; set; }

    public string? Cin { get; set; }

    public string? DelivreA { get; set; }

    public DateTime? DelivreLe { get; set; }

    public string? Type { get; set; }
}
