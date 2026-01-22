using HealthCenter.Models.Base;

namespace HealthCenter.Models
{
    public class Doctor:BaseEntity
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public int RoleId { get; set; }
        

    }
}
