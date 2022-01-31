using Microsoft.AspNetCore.Identity;

namespace query.Entity;

public class Row : IdentityUser
{
    public string Fullname { get; set; }     
    public string Phone { get; set; }     
}