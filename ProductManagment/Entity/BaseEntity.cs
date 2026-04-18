using System.ComponentModel.DataAnnotations;

namespace ProductManagment.Entity
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
