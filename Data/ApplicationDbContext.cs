using Microsoft.EntityFrameworkCore;
using identity_angular.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace identity_angular.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions options)
        : base(options)
    {

    }
}
