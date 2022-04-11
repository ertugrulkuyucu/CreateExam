using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SınavOlusturma.Models
{
    public class Question
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[ForeignKey("QuestionExamId")]
        public int Id { get; set; }
        public int ExamId { get; set; }
        public string Text { get; set; }
        public virtual List<Answer> Answers { get; set; }

    }
}
