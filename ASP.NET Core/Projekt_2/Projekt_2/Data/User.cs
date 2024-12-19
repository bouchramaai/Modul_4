using System;
using System.Collections.Generic;

namespace Projekt_2.Data;

public partial class User
{
    public string UserId { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? SecondName { get; set; }

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string AddressId { get; set; } = null!;

    public virtual Address Address { get; set; } = null!;
}
