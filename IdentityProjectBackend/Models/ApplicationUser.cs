using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace IdentityProjectBackend.Models {
    public class ApplicationUser:IdentityUser{
        
        [Column(TypeName = "varchar(150)")]
        public string FullName { get; set; }
    }
}