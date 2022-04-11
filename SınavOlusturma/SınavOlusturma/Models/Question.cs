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
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ExamId { get; set; }
        public string Text { get; set; }
        public virtual Answer[] Answers { get; set; }

        public Question()
        {
            this.Answers = new Answer[4];
        }

        public void addAnswer(Answer a, int index)
        {
            this.Answers[index] = a;
        }


    }
}
