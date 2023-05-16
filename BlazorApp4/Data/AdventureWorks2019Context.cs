using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazerApp4.Data;

public class AdventureWorks2019Context : IdentityDbContext
{
    public AdventureWorks2019Context(DbContextOptions<AdventureWorks2019Context> options)
        : base(options)
    {
    }
}