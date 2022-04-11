using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SınavOlusturma.Models
{
    public class Exam
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public virtual Question[] Questions { get; set; }

        public Exam()
        {
            Questions = new Question[4];
        }

        public void addQuestion(Question q, int index)
        {
            this.Questions[index] = q;
        }
    }
}
