using System.ComponentModel.DataAnnotations;

namespace Rocky.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
