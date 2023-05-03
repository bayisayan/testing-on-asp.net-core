using System.ComponentModel.DataAnnotations;

namespace Rocky.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Название")]
        [Required]
        public string Name { get; set; }
       

    }
}
