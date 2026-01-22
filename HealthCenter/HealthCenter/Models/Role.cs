using HealthCenter.Models.Base;

namespace HealthCenter.Models
{
    public class Role:BaseEntity
    {
        public string Name { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}
