using System.ComponentModel.DataAnnotations;

namespace Rocky.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

    }
}
