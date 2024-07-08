using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KazaniApp.Data.Data
{
    public class KazaniDbContext : IdentityDbContext
    {
        public KazaniDbContext(DbContextOptions<IdentityDbContext> options)
            : base(options){}


    }
}
