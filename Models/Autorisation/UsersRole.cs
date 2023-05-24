using System;
using System.Collections.Generic;

namespace Contrat_AC.Models.Autorisation;

public partial class UsersRole
{
    public int UserRoleId { get; set; }

    public int UserId { get; set; }

    public int RoleId { get; set; }
}
