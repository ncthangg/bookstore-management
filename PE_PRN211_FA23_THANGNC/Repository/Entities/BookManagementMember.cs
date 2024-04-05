using System;
using System.Collections.Generic;

namespace Repository.Entities;

public partial class BookManagementMember
{
    public int MemberId { get; set; }

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string MemberRole { get; set; } = null!;
}
