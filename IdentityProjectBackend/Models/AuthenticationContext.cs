using Microsoft.EntityFrameworkCore;

namespace IdentityProjectBackend.Models {
    public class AuthenticationContext:DbContext {

        public AuthenticationContext(DbContextOptions<AuthenticationContext> options):base(options)
        {
            
        }

        public DbSet<ApplicationUser> ApplicationUsers {get; set;}
    }
}