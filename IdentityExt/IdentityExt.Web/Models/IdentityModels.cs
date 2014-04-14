using Microsoft.AspNet.Identity.EntityFramework;

namespace IdentityExt.Web.Models
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}