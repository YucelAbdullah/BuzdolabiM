using Microsoft.AspNetCore.Identity;

namespace BuzdolabımData
{
    public enum Genders
    {
        Male, Female
    }
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string Name { get; set; }
        public Genders? Gender { get; set; }
        public DateTime? BirthDate { get; set; }







    }
}
