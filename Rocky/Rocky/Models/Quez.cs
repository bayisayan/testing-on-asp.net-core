using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rocky.Models
{
    public class Quez
    {
        [Key]
        public int QuestionNumber { set; get; }
        public IEnumerable<QuestionOption> Options { set; get; }
        public int RightAnswer { set; get; }
    }
    public class QuestionOption
    {
        [Key]
        public int Index { set; get; }
        
        public string Option { set; get; }

    }
}
