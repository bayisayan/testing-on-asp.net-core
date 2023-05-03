using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rocky.Models
{
    public class Exam
    {
        [Key]
        public int QId { get; set; }
        [Required]
        [Display(Name = "Выберите тему")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        

        public virtual Category Category { get; set; }
        [Display(Name = "Введите вопрос")]
        public string Question { get; set; }

        [Display(Name = "Вариант 1")]
        public string options1 { get; set; }
        [Display(Name = "Вариант 2")]
        public string options2 { get; set; }
        [Display(Name = "Вариант 3")]
        public string options3 { get; set; }
        [Display(Name = "Вариант 4")]
        public string options4 { get; set; }

        [Display(Name = "Правильный ответ")]
        public string Correctans { get; set; }
        


    }
}
