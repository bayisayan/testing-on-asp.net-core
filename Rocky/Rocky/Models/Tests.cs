using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Rocky.Models
{
    public class Tests
    {
        public int Id { get; set; }
        [Display(Name = "Название")]
        public string Name { get; set; }
    }
}
