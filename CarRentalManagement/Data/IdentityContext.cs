using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Data;

namespace CarRentalManagement.Data
{
    public class IdentityContext(DbContextOptions<IdentityContext> options) : IdentityDbContext<CarRentalManagementUser>(options)
    {
    }
}
